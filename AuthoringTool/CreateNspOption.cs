// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.CreateNspOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using Nintendo.Authoring.AuthoringLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class CreateNspOption : CreateCommandOptionBase, IOption
  {
    private int contentInfoIndex;
    private bool isMetaSpecified;
    private bool isTypeSpecified;
    private bool isUseAdf;
    private List<string> TmpDirs;

    internal bool GeneratesApplicationControl { get; set; }

    internal List<NintendoSubmissionPackageContentInfo> NspContentInfos { get; set; }

    internal CreateNspOption()
    {
      this.OutputFile = "./output.nsp";
      this.GeneratesApplicationControl = false;
      this.NspContentInfos = new List<NintendoSubmissionPackageContentInfo>();
      this.NspContentInfos.Add(new NintendoSubmissionPackageContentInfo());
      this.contentInfoIndex = 0;
      this.isMetaSpecified = false;
      this.isTypeSpecified = false;
      this.isUseAdf = true;
      this.TmpDirs = new List<string>();
    }

    ~CreateNspOption()
    {
      foreach (string tmpDir in this.TmpDirs)
        Directory.Delete(tmpDir, true);
    }

    internal string GetApplicationControlGeneratePath()
    {
      foreach (NintendoSubmissionPackageContentResource resource in this.NspContentInfos[0].ResourceList)
      {
        if (resource.ContentType.Equals("Control"))
          return resource.PathList[0].first;
      }
      throw new ArgumentException();
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("creatensp: Create new Nintendo Submission Package from .adf or specified directory and .meta and .desc file.");
      Console.WriteLine("Usage: {0} creatensp [-o <outputPath>] <inputAdfPath>", (object) baseName);
      Console.WriteLine("Usage: {0} creatensp [-o <outputPath>] [--save-adf] [--only-adf] [--filter <fdfPath>] --meta <metaFilePath> --type <contentMetaType> [--desc <descFilePath> --program <codePath> [<dataPath>] [<logoPath>]] [--control <controlPath>]", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputPath>                                File path to output. If directory path is specified, output to <outputPath>/output.nsp.");
      Console.WriteLine("                                                 If omitted, output to ./output.nsp");
      Console.WriteLine("  --save-adf                                     Leave .adf which is generated intermediately.");
      Console.WriteLine("  --only-adf                                     Create .adf only.");
      Console.WriteLine("  --filter <fdfPath>                             Filter files to be included into .adf. <fdfPath> expects a path for a filter description file (.fdf).");
      Console.WriteLine("  --meta <metaFilePath>                          Location of .meta file to input.");
      Console.WriteLine("  --desc <descFilePath>                          Location of .desc file to input. This cannot be omitted when containing program content.");
      Console.WriteLine("  --type <contentMetaType>                       Content Meta Type to create package.");
      Console.WriteLine("                                                 Available as <contentMetaType>: Application, SystemProgram");
      Console.WriteLine("  --program <codePath> [<dataPath>] [<logoPath>]");
      Console.WriteLine("                                                 Location of directory path which includes files to be contained");
      Console.WriteLine("                                                 to in a executable content as code, data and/or logo region.");
      Console.WriteLine("                                                 dataPath and/or logoPath can be omitted.");
      Console.WriteLine("                                                 If codePath indicates a file, it is used as a content just as it is.");
      Console.WriteLine("                                                 In this case, dataPath and logoPath are ignored.");
      Console.WriteLine("  --control <controlPath>                        Location of directory path which includes files to be contained");
      Console.WriteLine("                                                 to in a control data content.");
      Console.WriteLine("                                                 If manualPath indicates a file, it is used as a content just as it is.");
      Console.WriteLine("  --html-document <htmlDocumentPath>             Location of directory which includes gameplay instruction documents.");
      Console.WriteLine("  --accessible-urls <accessibleUrlsPath>         Location of directory which includes files to accept documents to access websites.");
      Console.WriteLine("  --legal-information <legalInformationPath>     Location of zip file which includes software legal information documents.");
    }

    private void UpdateElement()
    {
      this.NspContentInfos.Add(new NintendoSubmissionPackageContentInfo());
      ++this.contentInfoIndex;
      this.isMetaSpecified = false;
      this.isTypeSpecified = false;
    }

    internal string ExtractZipFile(string fileName)
    {
      if (Path.GetExtension(fileName).ToLower() != ".zip")
        throw new InvalidOptionException();
      string destinationDirectoryName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()).Replace("\\", "/").TrimEnd('/');
      ZipFile.ExtractToDirectory(fileName, destinationDirectoryName);
      this.TmpDirs.Add(destinationDirectoryName);
      return destinationDirectoryName;
    }

    internal OptionDescription CreateContentOptionDescription(string longName, string type, int countArgs = 1)
    {
      return new OptionDescription(longName, (string) null, countArgs, (Action<List<string>>) (s =>
      {
        this.isUseAdf = false;
        NintendoSubmissionPackageContentResource packageContentResource = new NintendoSubmissionPackageContentResource();
        packageContentResource.ContentType = type;
        for (int index = 0; index < s.Count; ++index)
        {
          string str = s[index].Replace("\\", "/").TrimEnd('/');
          if (longName == "--legal-information")
            str = this.ExtractZipFile(str);
          packageContentResource.PathList.Add(new Pair<string, string>(str, (string) null));
        }
        this.NspContentInfos[this.contentInfoIndex].ResourceList.Add(packageContentResource);
      }));
    }

    internal OptionDescription CreateContentOptionDescriptionForHtmlDocument(string longName, string outputDir)
    {
      return new OptionDescription(longName, (string) null, 1, (Action<List<string>>) (s =>
      {
        this.isUseAdf = false;
        IEnumerable<NintendoSubmissionPackageContentResource> source = this.NspContentInfos[this.contentInfoIndex].ResourceList.Where<NintendoSubmissionPackageContentResource>((Func<NintendoSubmissionPackageContentResource, bool>) (x => x.ContentType.Equals("HtmlDocument")));
        if (source.Count<NintendoSubmissionPackageContentResource>() > 1)
          throw new ArgumentException();
        NintendoSubmissionPackageContentResource packageContentResource;
        if (source.Count<NintendoSubmissionPackageContentResource>() == 0)
        {
          packageContentResource = new NintendoSubmissionPackageContentResource();
          packageContentResource.ContentType = "HtmlDocument";
          this.NspContentInfos[this.contentInfoIndex].ResourceList.Add(packageContentResource);
        }
        else
          packageContentResource = source.ElementAt<NintendoSubmissionPackageContentResource>(0);
        for (int index = 0; index < s.Count; ++index)
        {
          string a = s[index].Replace("\\", "/").TrimEnd('/');
          packageContentResource.PathList.Add(new Pair<string, string>(a, outputDir));
        }
      }));
    }

    public new OptionDescription[] GetOptionDescription()
    {
      return ((IEnumerable<OptionDescription>) new OptionDescription[14]
      {
        new OptionDescription("--type", (string) null, 1, (Action<List<string>>) (s =>
        {
          this.isUseAdf = false;
          this.isTypeSpecified = true;
          try
          {
            Enum.Parse(typeof (ContentMetaType), s.First<string>());
          }
          catch (Exception ex)
          {
            throw new InvalidOptionException(string.Format("invalid option --type {0}.", (object) s.First<string>()));
          }
          this.NspContentInfos[this.contentInfoIndex].MetaType = s.First<string>();
        })),
        OptionUtil.CreateFilePathOptionDescription("--meta", (OptionUtil.PathSetter) (path =>
        {
          this.isUseAdf = false;
          this.isMetaSpecified = true;
          this.NspContentInfos[this.contentInfoIndex].MetaFilePath = path;
        })),
        OptionUtil.CreateFilePathOptionDescription("--desc", (OptionUtil.PathSetter) (path =>
        {
          this.isUseAdf = false;
          this.NspContentInfos[this.contentInfoIndex].DescFilePath = path;
        })),
        new OptionDescription("--keyindex", (string) null, 1, (Action<List<string>>) (s => this.NspContentInfos[this.contentInfoIndex].KeyAreaEncryptionKeyIndex = int.Parse(s.First<string>()))),
        this.CreateContentOptionDescription("--program", "Program", 3),
        this.CreateContentOptionDescription("--control", "Control", 1),
        this.CreateContentOptionDescriptionForHtmlDocument("--html-document", "html-document"),
        this.CreateContentOptionDescriptionForHtmlDocument("--accessible-urls", "accessible-urls"),
        this.CreateContentOptionDescription("--legal-information", "LegalInformation", 1),
        this.CreateContentOptionDescription("--legal-information-dir", "LegalInformation", 1),
        this.CreateContentOptionDescription("--data", "Data", 1),
        new OptionDescription("--icon", (string) null, 32, (Action<List<string>>) (s =>
        {
          if (s.Count % 2 != 0)
            throw new InvalidOptionException("--icon <language> <iconPath>...");
          this.NspContentInfos[this.contentInfoIndex].IconList = OptionUtil.CreateIconFileList(s);
        })),
        new OptionDescription("--nx-icon", (string) null, 32, (Action<List<string>>) (s =>
        {
          if (s.Count % 2 != 0)
            throw new InvalidOptionException("--nx-icon <language> <iconPath>...");
          this.NspContentInfos[this.contentInfoIndex].NxIconList = OptionUtil.CreateIconFileList(s);
        })),
        new OptionDescription("--nx-icon-max-size", (string) null, 32, (Action<List<string>>) (s => this.NspContentInfos[this.contentInfoIndex].NxIconMaxSize = Convert.ToUInt32(s.First<string>())))
      }).Concat<OptionDescription>((IEnumerable<OptionDescription>) base.GetOptionDescription()).ToArray<OptionDescription>();
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (!this.isUseAdf && (!this.isMetaSpecified || !this.isTypeSpecified))
        throw new InvalidOptionException("too few options for creatensp subcommand.");
      if (args.Length < 1 && this.isUseAdf)
        throw new InvalidOptionException("too few arguments for creatensp subcommand.");
      if (args.Length > 1 && this.isUseAdf)
        throw new InvalidOptionException("too many arguments for creatensp subcommand.");
      if (args.Length != 0 && !this.isUseAdf)
        throw new InvalidOptionException("too many arguments for creatensp subcommand.");
      if (this.isUseAdf)
      {
        this.InputAdfFile = args[0].Replace("\\", "/");
        this.IsSaveAdf = true;
      }
      if (this.NspContentInfos[0].IconList.Count != 0)
      {
        if (this.NspContentInfos[0].MetaType != "Application" && this.NspContentInfos[0].MetaType != "Patch")
          throw new InvalidOptionException("--icon option should be used with --type Application.");
        if (this.NspContentInfos[0].HasResource("Control"))
          throw new InvalidOptionException("--icon option cannot be used with --control option.");
      }
      if (!this.isTypeSpecified || !(this.NspContentInfos[0].MetaType == "Application") && !(this.NspContentInfos[0].MetaType == "Patch") || this.NspContentInfos[0].HasResource("Control"))
        return;
      this.GeneratesApplicationControl = true;
      this.NspContentInfos[0].ResourceList.Add(new NintendoSubmissionPackageContentResource()
      {
        ContentType = "Control",
        PathList = {
          new Pair<string, string>(Path.GetDirectoryName(this.OutputFile).Replace("\\", "/") + "/" + Path.GetFileName(this.OutputFile) + ".control", (string) null)
        }
      });
    }
  }
}
