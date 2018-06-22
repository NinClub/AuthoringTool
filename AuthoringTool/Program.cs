// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.Program
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using Nintendo.Authoring.AuthoringLibrary;
using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class Program
  {
    private static FileStream OpenReadOnlyFileStream(string path, FileOptions options = FileOptions.SequentialScan)
    {
      return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, options);
    }

    private static FileStream OpenNewFileStream(string path, FileOptions options = FileOptions.RandomAccess)
    {
      using (File.Create(path))
        ;
      FileAttributes fileAttributes = File.GetAttributes(path) | FileAttributes.SparseFile;
      File.SetAttributes(path, fileAttributes);
      return new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, options);
    }

    internal static void CreateFs(Option option)
    {
      AuthoringConfiguration config = option.Config;
      CreateFsOption createFs = option.CreateFs;
      Directory.CreateDirectory(Path.GetDirectoryName(createFs.OutputFile));
      string str = createFs.InputAdfFile;
      if (createFs.Format != ArchiveFormatType.Invalid)
      {
        List<Pair<FilterType, Regex>> fdf = FilterDescription.ParseFdf(createFs.InputFdfPath);
        str = Path.GetDirectoryName(createFs.OutputFile) + "\\" + Path.GetFileName(createFs.OutputFile) + ".adf";
        switch (createFs.Format)
        {
          case ArchiveFormatType.PartitionFs:
            new PartitionFsAdfWriter(str).Write(createFs.InputDir);
            break;
          case ArchiveFormatType.RomFs:
            new RomFsAdfWriter(str).Write(createFs.InputDir, fdf);
            break;
          default:
            throw new NotImplementedException();
        }
      }
      if (createFs.IsOnlyAdf)
        return;
      switch (ContentArchiveLibraryInterface.GetArchiveType(str))
      {
        case ArchiveFormatType.PartitionFs:
        case ArchiveFormatType.RomFs:
          using (FileStream fileStream = Program.OpenNewFileStream(createFs.OutputFile, FileOptions.RandomAccess))
            ContentArchiveLibraryInterface.CreateArchiveFromAdf((Stream) fileStream, str, config);
          if (createFs.IsSaveAdf)
            break;
          File.Delete(str);
          break;
        default:
          throw new FormatException("invalid formatType is indicated by .adf file.");
      }
    }

    internal static void CreateNca(Option option)
    {
      AuthoringConfiguration config = option.Config;
      CreateNcaOption createNca = option.CreateNca;
      Directory.CreateDirectory(Path.GetDirectoryName(createNca.OutputFile));
      string str = createNca.InputAdfFile;
      if (createNca.ContentType != null)
      {
        List<Pair<FilterType, Regex>> fdf = FilterDescription.ParseFdf(createNca.InputFdfPath);
        str = Path.GetDirectoryName(createNca.OutputFile) + "\\" + Path.GetFileName(createNca.OutputFile) + ".adf";
        new NintendoContentAdfWriter(str, createNca.ContentType, createNca.MetaFilePath, createNca.DescFilePath, createNca.KeyAreaEncryptionKeyIndex).Write(createNca.InputDirs, fdf);
      }
      if (createNca.IsOnlyAdf)
        return;
      if (ContentArchiveLibraryInterface.GetArchiveType(str) != ArchiveFormatType.NintendoContent)
        throw new FormatException("invalid formatType is indicated by .adf file.");
      using (FileStream fileStream = Program.OpenNewFileStream(createNca.OutputFile, FileOptions.RandomAccess))
        ContentArchiveLibraryInterface.CreateArchiveFromAdf((Stream) fileStream, str, config);
      if (createNca.IsSaveAdf)
        return;
      File.Delete(str);
      File.Delete(Path.GetDirectoryName(str) + "\\" + Path.GetFileNameWithoutExtension(str) + ".code.adf");
      File.Delete(Path.GetDirectoryName(str) + "\\" + Path.GetFileNameWithoutExtension(str) + ".rom.adf");
    }

    internal static void CreateNsp(Option option)
    {
      AuthoringConfiguration config = option.Config;
      CreateNspOption createNsp = option.CreateNsp;
      Directory.CreateDirectory(Path.GetDirectoryName(createNsp.OutputFile));
      if (createNsp.GeneratesApplicationControl)
        ApplicationControl.Generate(createNsp.NspContentInfos[0].MetaFilePath, createNsp.NspContentInfos[0].IconList, createNsp.NspContentInfos[0].NxIconList, createNsp.NspContentInfos[0].NxIconMaxSize, createNsp.GetApplicationControlGeneratePath(), true);
      string str = createNsp.InputAdfFile;
      if (str == null)
      {
        List<Pair<FilterType, Regex>> fdf = FilterDescription.ParseFdf(createNsp.InputFdfPath);
        str = Path.GetDirectoryName(createNsp.OutputFile) + "\\" + Path.GetFileName(createNsp.OutputFile) + ".adf";
        new NintendoSubmissionPackageAdfWriter(str).Write(createNsp.NspContentInfos, fdf);
      }
      if (createNsp.IsOnlyAdf)
        return;
      if (ContentArchiveLibraryInterface.GetArchiveType(str) != ArchiveFormatType.NintendoSubmissionPackage)
        throw new FormatException("invalid formatType is indicated by .adf file.");
      using (FileStream fileStream = Program.OpenNewFileStream(createNsp.OutputFile, FileOptions.RandomAccess))
        ContentArchiveLibraryInterface.CreateArchiveFromAdf((Stream) fileStream, str, config);
      if (!createNsp.IsSaveAdf)
      {
        File.Delete(str);
        foreach (string file in Directory.GetFiles(Path.GetDirectoryName(str), Path.GetFileNameWithoutExtension(str) + ".c?.*.nca.*adf"))
          File.Delete(file);
      }
      if (!createNsp.GeneratesApplicationControl)
        return;
      Directory.Delete(createNsp.GetApplicationControlGeneratePath(), true);
    }

    internal static void CraeteNspMeta(Option option)
    {
      CreateNspMetaOption createNspMeta = option.CreateNspMeta;
      if (createNspMeta.MetaType == "Application" || createNspMeta.MetaType == "Patch")
      {
        string outputDirectoryPath = createNspMeta.OutputDirectory + "/control0.ncd/data";
        ApplicationControl.Generate(createNspMeta.MetaFilePath, createNspMeta.IconFileList, createNspMeta.NxIconFileList, createNspMeta.NxIconMaxSize, outputDirectoryPath, true);
      }
      string path = createNspMeta.OutputDirectory + "/meta0.ncd/data";
      Directory.CreateDirectory(path);
      NintendoContentMetaBase nintendoContentMetaBase = new NintendoContentMetaBase(new List<Tuple<ISource, NintendoContentInfo>>(), createNspMeta.MetaType, createNspMeta.MetaFilePath);
      using (FileStream fileStream = Program.OpenNewFileStream(path + "/" + nintendoContentMetaBase.GetEntryName(), FileOptions.RandomAccess))
      {
        byte[] bytes = nintendoContentMetaBase.GetBytes();
        fileStream.Write(bytes, 0, bytes.Length);
      }
    }

    internal static void CraeteNspd(Option option)
    {
      CreateNspdOption createNspd = option.CreateNspd;
      Program.DeleteIncludingJunctionDirectory(createNspd.OutputDirectory);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory, (string) null);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/program0.ncd", (string) null);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/program0.ncd/code", createNspd.CodeDirectory);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/program0.ncd/data", createNspd.DataDirectory);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/program0.ncd/logo", createNspd.LogoDirectory);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/htmlDocument0.ncd", (string) null);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/htmlDocument0.ncd/htmlDocument", createNspd.HtmlDocumentDirectory);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/htmlDocument0.ncd/accessibleUrls", createNspd.AccessibleUrlsDirectory);
      Program.EnsureDirectoryWithJunction(createNspd.OutputDirectory + "/legalInformation0.ncd", createNspd.LegalInformationDirectory);
      string path1 = createNspd.OutputDirectory + "/control0.ncd";
      string str = path1 + "/data";
      Program.EnsureDirectoryWithJunction(path1, (string) null);
      Program.EnsureDirectoryWithJunction(str, createNspd.ControlDirectory);
      ApplicationControl.Generate(createNspd.MetaFilePath, createNspd.IconFileList, createNspd.NxIconFileList, createNspd.NxIconMaxSize, str, false);
      string path2 = createNspd.OutputDirectory + "/meta0.ncd/data";
      Directory.CreateDirectory(path2);
      NintendoContentMetaBase nintendoContentMetaBase = new NintendoContentMetaBase(new List<Tuple<ISource, NintendoContentInfo>>(), createNspd.MetaType, createNspd.MetaFilePath);
      using (FileStream fileStream = Program.OpenNewFileStream(path2 + "/" + nintendoContentMetaBase.GetEntryName(), FileOptions.RandomAccess))
      {
        byte[] bytes = nintendoContentMetaBase.GetBytes();
        fileStream.Write(bytes, 0, bytes.Length);
      }
      string path2_1 = Path.GetFileNameWithoutExtension(createNspd.OutputDirectory) + ".nspd_root";
      using (File.Create(Path.Combine(Path.GetDirectoryName(createNspd.OutputDirectory), path2_1)))
        ;
    }

    internal static void ExtractNsp(Option option)
    {
      using (FileStream fileStream = Program.OpenReadOnlyFileStream(option.ExtractNsp.InputNspFile, FileOptions.SequentialScan))
      {
        NintendoSubmissionPackageReader submissionPackageReader = new NintendoSubmissionPackageReader((Stream) fileStream);
        foreach (Tuple<string, long> tuple in submissionPackageReader.ListFileInfo())
        {
          string fileName = tuple.Item1;
          long fileSize = tuple.Item2;
          string extractedPath = option.ExtractNsp.OutputDirectory + "/" + fileName;
          Console.WriteLine("Extracting {0}.", (object) extractedPath);
          Program.FsUtil.WriteFile((IFileSystemArchiveReader) submissionPackageReader, extractedPath, fileName, fileSize);
        }
      }
    }

    private static void ExtractNca(NintendoContentArchiveReader reader, string outputDirectoryPath, string targetEntryPath)
    {
      bool flag1 = false;
      bool flag2 = !string.IsNullOrEmpty(targetEntryPath);
      Directory.CreateDirectory(outputDirectoryPath);
      foreach (Tuple<int, long> tuple1 in reader.ListFsInfo())
      {
        int index = tuple1.Item1;
        IFileSystemArchiveReader fsReader = reader.OpenFileSystemArchiveReader(index);
        foreach (Tuple<string, long> tuple2 in fsReader.ListFileInfo())
        {
          string str1 = tuple2.Item1;
          long fileSize = tuple2.Item2;
          string str2 = string.Format("fs{0}/{1}", (object) index, (object) str1);
          if (!Program.FsUtil.CheckShouldSkipComparePath(targetEntryPath, str2))
          {
            string str3 = Path.Combine(outputDirectoryPath, Path.GetFileName(str1));
            if (!flag2)
            {
              str3 = Path.Combine(outputDirectoryPath, str2);
              Directory.CreateDirectory(Path.GetDirectoryName(str3));
            }
            Console.WriteLine("  Extracting {0}\t({1} byte)", (object) str2, (object) fileSize);
            Program.FsUtil.WriteFile(fsReader, str3, str1, fileSize);
            flag1 = true;
          }
        }
      }
      if (!flag1)
        throw new ExtractEntryNotFoundException();
    }

    internal static void Extract(Option option)
    {
      byte[][] areaEncryptionKeys = option.Config.GetKeyConfiguration().GetKeyAreaEncryptionKeys();
      bool flag1 = false;
      bool flag2 = !string.IsNullOrEmpty(option.Extract.TargetEntryPath);
      string outputDirectory = option.Extract.OutputDirectory;
      string targetEntryPath1 = option.Extract.TargetEntryPath;
      string fileName = Path.GetFileName(option.Extract.InputFile);
      try
      {
        Directory.CreateDirectory(outputDirectory);
        using (FileStream fileStream = Program.OpenReadOnlyFileStream(option.Extract.InputFile, FileOptions.SequentialScan))
        {
          if (Path.GetExtension(fileName) == ".nsp")
          {
            NintendoSubmissionPackageReader submissionPackageReader = new NintendoSubmissionPackageReader((Stream) fileStream);
            foreach (Tuple<string, long> tuple in submissionPackageReader.ListFileInfo())
            {
              string str1 = tuple.Item1;
              long fileSize = tuple.Item2;
              if (!Program.FsUtil.CheckShouldSkipStartsWithPath(targetEntryPath1, str1))
              {
                string extractedPath = Path.Combine(outputDirectory, str1);
                if (Path.GetExtension(str1) == ".nca")
                {
                  Console.WriteLine("Target: {0}\t({1} byte)", (object) str1, (object) fileSize);
                  if (targetEntryPath1 == str1)
                  {
                    Program.FsUtil.WriteFile((IFileSystemArchiveReader) submissionPackageReader, extractedPath, str1, fileSize);
                    flag1 = true;
                    break;
                  }
                  NintendoContentArchiveReader reader = submissionPackageReader.OpenNintendoContentArchiveReader(str1, areaEncryptionKeys);
                  string str2 = flag2 ? outputDirectory : extractedPath;
                  string str3 = flag2 ? targetEntryPath1.Substring(str1.Length + 1) : targetEntryPath1;
                  string outputDirectoryPath = str2;
                  string targetEntryPath2 = str3;
                  Program.ExtractNca(reader, outputDirectoryPath, targetEntryPath2);
                  flag1 = true;
                }
                else
                {
                  Console.WriteLine("Extracting {0}\t({1} byte)", (object) str1, (object) fileSize);
                  Program.FsUtil.WriteFile((IFileSystemArchiveReader) submissionPackageReader, extractedPath, str1, fileSize);
                  flag1 = true;
                }
              }
            }
          }
          else
          {
            if (!(Path.GetExtension(fileName) == ".nca"))
              throw new ArgumentException("input archive file must be .nca or .nsp file.");
            Program.ExtractNca(new NintendoContentArchiveReader((Stream) fileStream, areaEncryptionKeys), outputDirectory, targetEntryPath1);
            flag1 = true;
          }
        }
      }
      catch (ExtractEntryNotFoundException ex)
      {
      }
      if (flag1)
        return;
      if (!string.IsNullOrEmpty(option.Extract.OutputDirectory))
        Console.Error.WriteLine("[Error] Target entry path '{0}' not found.", (object) option.Extract.TargetEntryPath);
      else
        Console.Error.WriteLine("[Error] Nothing to be extracted.");
    }

    private static void Replace(Option option)
    {
      AuthoringConfiguration config = option.Config;
      string extension = Path.GetExtension(option.Replace.InputFile);
      if (extension != ".nsp" && extension != ".nca")
        throw new ArgumentException("input file must be .nsp or .nca file.");
      Directory.CreateDirectory(option.Replace.OutputDirectory);
      string path = option.Replace.OutputDirectory + "/" + Path.GetFileNameWithoutExtension(option.Replace.InputFile) + "_replaced" + extension;
      using (FileStream fileStream1 = Program.OpenReadOnlyFileStream(option.Replace.InputFile, FileOptions.SequentialScan))
      {
        using (FileStream fileStream2 = Program.OpenReadOnlyFileStream(option.Replace.InputEntryFilePath, FileOptions.SequentialScan))
        {
          using (FileStream fileStream3 = Program.OpenNewFileStream(path, FileOptions.RandomAccess))
          {
            bool isNsp = extension == ".nsp";
            ContentArchiveLibraryInterface.ModifyArchive((Stream) fileStream3, (Stream) fileStream1, (Stream) fileStream2, option.Replace.TargetEntryPath, option.Replace.DescFilePath, isNsp, config);
          }
        }
      }
    }

    private static void ListNca(NintendoContentArchiveReader reader, string ncaName)
    {
      int val1 = 10;
      ncaName = string.IsNullOrEmpty(ncaName) ? "" : ncaName + "/";
      foreach (Tuple<int, long> tuple1 in reader.ListFsInfo())
      {
        int index = tuple1.Item1;
        foreach (Tuple<string, long> tuple2 in reader.OpenFileSystemArchiveReader(index).ListFileInfo())
        {
          string str1 = tuple2.Item1;
          long num = tuple2.Item2;
          string str2 = string.Format("{0}fs{1}/{2}", (object) ncaName, (object) index, (object) str1);
          val1 = Math.Max(val1, str2.Length);
          Console.WriteLine("{0}\t({1} byte)", (object) str2.PadRight(val1 + 1), (object) num);
        }
      }
    }

    internal static void List(Option option)
    {
      byte[][] areaEncryptionKeys = option.Config.GetKeyConfiguration().GetKeyAreaEncryptionKeys();
      using (FileStream fileStream = Program.OpenReadOnlyFileStream(option.List.InputFile, FileOptions.SequentialScan))
      {
        string fileName1 = Path.GetFileName(option.List.InputFile);
        if (Path.GetExtension(fileName1) == ".nsp")
        {
          NintendoSubmissionPackageReader submissionPackageReader = new NintendoSubmissionPackageReader((Stream) fileStream);
          foreach (Tuple<string, long> tuple in submissionPackageReader.ListFileInfo())
            Console.WriteLine("{0, -45}\t({1} byte)", (object) tuple.Item1, (object) tuple.Item2);
          Console.WriteLine("---------------------------------------------");
          foreach (Tuple<string, long> tuple in submissionPackageReader.ListFileInfo().FindAll((Predicate<Tuple<string, long>>) (x => Path.GetExtension(x.Item1) == ".nca")))
          {
            string str = tuple.Item1;
            long num = tuple.Item2;
            Program.ListNca(submissionPackageReader.OpenNintendoContentArchiveReader(str, areaEncryptionKeys), str);
          }
        }
        else if (Path.GetExtension(fileName1) == ".nca")
        {
          Program.ListNca(new NintendoContentArchiveReader((Stream) fileStream, areaEncryptionKeys), (string) null);
        }
        else
        {
          if (!(Path.GetExtension(fileName1) == ".xci") && !(Path.GetExtension(fileName1) == ".xcie"))
            throw new ArgumentException("input archive file must be .nca or .nsp file.");
          Console.WriteLine("[headerInfo]");
          long offset1 = (long) XciInfo.CardKeyAreaPageCount * (long) XciInfo.PageSize;
          SubStream subStream = new SubStream((Stream) fileStream, offset1, (long) XciInfo.CardHeaderPageCount * (long) XciInfo.PageSize);
          byte[] numArray = new byte[subStream.Length];
          subStream.Read(numArray, 0, (int) subStream.Length);
          XciUtils.DumpHeader(numArray);
          long offset2 = (long) XciInfo.NormalAreaStartPageAddress * (long) XciInfo.PageSize;
          XciReader xciReader = new XciReader((Stream) new SubStream((Stream) fileStream, offset2, fileStream.Length - offset2));
          foreach (Tuple<string, long> tuple1 in xciReader.ListFileInfo())
          {
            string fileName2 = tuple1.Item1;
            XciPartitionReader xciPartitionReader = xciReader.OpenXciPartitionReader(fileName2);
            Console.WriteLine("[{0}]", (object) fileName2);
            foreach (Tuple<string, long> tuple2 in xciPartitionReader.ListFileInfo())
              Console.WriteLine("{0, -45}\t({1} byte)", (object) tuple2.Item1, (object) tuple2.Item2);
          }
        }
      }
    }

    internal static void MergeNsp(Option option)
    {
      List<Stream> list = option.MergeNsp.InputFiles.Select<string, Stream>((Func<string, Stream>) (x => (Stream) Program.OpenReadOnlyFileStream(x, FileOptions.SequentialScan))).ToList<Stream>();
      try
      {
        using (FileStream fileStream = Program.OpenNewFileStream(option.MergeNsp.OutputFile, FileOptions.RandomAccess))
          ContentArchiveLibraryInterface.MergeNintendoSubmissionPackageArchive((Stream) fileStream, list);
      }
      finally
      {
        foreach (Stream stream in list)
          stream?.Dispose();
      }
    }

    private static string GetProdEncryptionOutputFileNameBase(ProdEncryptionOption option)
    {
      return option.OutputDirectory + "/" + Path.GetFileNameWithoutExtension(option.InputNspFile);
    }

    internal static void ProdEncryption(Option option)
    {
      AuthoringConfiguration config = option.Config;
      if (Path.GetExtension(option.ProdEncryption.InputNspFile) != ".nsp")
        throw new ArgumentException("input file must be .nsp file.");
      if (option.ProdEncryption.CreateXci)
      {
        string path1 = Program.GetProdEncryptionOutputFileNameBase(option.ProdEncryption) + "_prod.xci";
        string path2 = Program.GetProdEncryptionOutputFileNameBase(option.ProdEncryption) + "_prod.xci.result.xml";
        string path3 = Program.GetProdEncryptionOutputFileNameBase(option.ProdEncryption) + "_prod.xcie";
        string path4 = Program.GetProdEncryptionOutputFileNameBase(option.ProdEncryption) + "_prod.xcie.result.xml";
        using (FileStream fileStream1 = Program.OpenReadOnlyFileStream(option.ProdEncryption.InputNspFile, FileOptions.SequentialScan))
        {
          using (FileStream fileStream2 = option.ProdEncryption.InputUppNspFile != null ? Program.OpenReadOnlyFileStream(option.ProdEncryption.InputUppNspFile, FileOptions.SequentialScan) : (FileStream) null)
          {
            using (FileStream fileStream3 = Program.OpenNewFileStream(path1, FileOptions.RandomAccess))
            {
              using (FileStream fileStream4 = Program.OpenNewFileStream(path2, FileOptions.RandomAccess))
                ContentArchiveLibraryInterface.ProdEncryptNintendoSubmissionPackageArchiveForXci((Stream) fileStream3, (Stream) fileStream4, (Stream) fileStream1, (Stream) fileStream2, (Stream) null, option.ProdEncryption.LaunchFlags, config);
            }
          }
        }
        if (!option.ProdEncryption.CreateXcie)
          return;
        using (FileStream fileStream1 = Program.OpenReadOnlyFileStream(path1, FileOptions.SequentialScan))
        {
          using (FileStream fileStream2 = Program.OpenNewFileStream(path3, FileOptions.SequentialScan))
          {
            using (FileStream fileStream3 = Program.OpenNewFileStream(path4, FileOptions.RandomAccess))
              ContentArchiveLibraryInterface.EncryptXci((Stream) fileStream2, (Stream) fileStream3, (Stream) fileStream1, config);
          }
        }
      }
      else
      {
        string path1 = Program.GetProdEncryptionOutputFileNameBase(option.ProdEncryption) + "_prod.nsp";
        string path2 = Program.GetProdEncryptionOutputFileNameBase(option.ProdEncryption) + "_prod.nsp.result.xml";
        using (FileStream fileStream1 = Program.OpenReadOnlyFileStream(option.ProdEncryption.InputNspFile, FileOptions.SequentialScan))
        {
          using (FileStream fileStream2 = Program.OpenNewFileStream(path1, FileOptions.RandomAccess))
          {
            using (FileStream fileStream3 = Program.OpenNewFileStream(path2, FileOptions.RandomAccess))
              ContentArchiveLibraryInterface.ProdEncryptNintendoSubmissionPackageArchive((Stream) fileStream2, (Stream) fileStream3, (Stream) fileStream1, config);
          }
        }
      }
    }

    internal static void MakeJunctionPoint(string path, string junctionSrcPath)
    {
      Program.DeleteDirectoryIfExisted(path);
      using (Process process = new Process())
      {
        process.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
        process.StartInfo.Arguments = string.Format("/c mklink /j {0} {1}", (object) path.Replace('/', '\\'), (object) junctionSrcPath.Replace('/', '\\'));
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.Start();
        string end = process.StandardError.ReadToEnd();
        process.WaitForExit();
        if (process.ExitCode != 0)
          throw new ArgumentException("Failed to create junction point: " + end);
      }
    }

    internal static void DeleteDirectoryIfExisted(string path)
    {
      if (Directory.Exists(path))
        Directory.Delete(path, true);
      int num = 0;
      while (num < 3000 && Directory.Exists(path))
      {
        Thread.Sleep(100);
        num += 100;
      }
    }

    internal static void DeleteIncludingJunctionDirectory(string path)
    {
      if (!Directory.Exists(path))
        return;
      foreach (string enumerateDirectory in Directory.EnumerateDirectories(path))
      {
        FileAttributes attributes = File.GetAttributes(enumerateDirectory);
        if ((attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
          Program.DeleteDirectoryIfExisted(enumerateDirectory);
        else if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
          Program.DeleteIncludingJunctionDirectory(enumerateDirectory);
      }
      Program.DeleteDirectoryIfExisted(path);
    }

    internal static void EnsureDirectoryWithJunction(string path, string junctionSrcPath)
    {
      if (junctionSrcPath == null || junctionSrcPath.Length == 0)
      {
        if (Directory.Exists(path))
          return;
        Directory.CreateDirectory(path);
      }
      else
        Program.MakeJunctionPoint(path, junctionSrcPath);
    }

    internal static void Main(string[] args)
    {
      Option option = new Option();
      try
      {
        option.Parse(args);
        if (option.IsShowUsage)
        {
          option.ShowUsage();
          Environment.Exit(1);
        }
        if (option.IsVerbose)
          Nintendo.Authoring.AuthoringLibrary.Log.Enable();
        if (option.CreateFs != null)
          Program.CreateFs(option);
        else if (option.CreateNca != null)
          Program.CreateNca(option);
        else if (option.CreateNsp != null)
          Program.CreateNsp(option);
        else if (option.CreateNspMeta != null)
          Program.CraeteNspMeta(option);
        else if (option.CreateNspd != null)
          Program.CraeteNspd(option);
        else if (option.Extract != null)
          Program.Extract(option);
        else if (option.ExtractNsp != null)
          Program.ExtractNsp(option);
        else if (option.MergeNsp != null)
          Program.MergeNsp(option);
        else if (option.Replace != null)
          Program.Replace(option);
        else if (option.List != null)
        {
          Program.List(option);
        }
        else
        {
          if (option.ProdEncryption == null)
            return;
          Program.ProdEncryption(option);
        }
      }
      catch (InvalidOptionException ex)
      {
        Console.Error.WriteLine("[Error] {0}", (object) ex.Message);
        option.ShowUsage();
        Environment.Exit(1);
      }
      catch (Exception ex)
      {
        Console.Error.WriteLine("[Error] {0}", (object) ex.Message);
        Console.Error.WriteLine("\nStackTrace:\n{0}", (object) ex.StackTrace);
        Environment.Exit(1);
      }
    }

    private class FsUtil
    {
      internal static void WriteFile(IFileSystemArchiveReader fsReader, string extractedPath, string fileName, long fileSize)
      {
        using (FileStream fileStream = new FileStream(extractedPath, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.RandomAccess))
        {
          long offset = 0;
          while (offset < fileSize)
          {
            uint num = (uint) Math.Min(1048576L, fileSize - offset);
            byte[] buffer = fsReader.ReadFile(fileName, offset, (long) num);
            fileStream.Write(buffer, 0, buffer.Length);
            offset += (long) buffer.Length;
          }
        }
      }

      internal static bool CheckShouldSkipStartsWithPath(string targetPath, string startsWithSkipKeyPath)
      {
        if (targetPath == null || string.IsNullOrEmpty(startsWithSkipKeyPath))
          return false;
        return !targetPath.StartsWith(startsWithSkipKeyPath);
      }

      internal static bool CheckShouldSkipComparePath(string targetPath, string startsWithSkipKeyPath)
      {
        if (targetPath == null || string.IsNullOrEmpty(startsWithSkipKeyPath))
          return false;
        return targetPath != startsWithSkipKeyPath;
      }
    }
  }
}
