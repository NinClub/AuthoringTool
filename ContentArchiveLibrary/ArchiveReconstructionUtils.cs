// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ArchiveReconstructionUtils
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class ArchiveReconstructionUtils
  {
    private static void GetFsInfo(IFileSystemArchiveReader fsReader, EntryReplaceRule replaceRule, ArchiveReconstructionUtils.AddEntryToFsInfo addEntryDelegate)
    {
      ArchiveReconstructionUtils.BasicFileInfo basicFileInfo1 = new ArchiveReconstructionUtils.BasicFileInfo(fsReader.ListFileInfo().Find((Predicate<Tuple<string, long>>) (x => x.Item1 == replaceRule.Path)), fsReader);
      long num = replaceRule.Source.Size - basicFileInfo1.Size;
      List<ArchiveReconstructionUtils.BasicFileInfo> basicFileInfoList = new List<ArchiveReconstructionUtils.BasicFileInfo>();
      foreach (Tuple<string, long> fileInfo in fsReader.ListFileInfo())
      {
        ArchiveReconstructionUtils.BasicFileInfo basicFileInfo2 = new ArchiveReconstructionUtils.BasicFileInfo(fileInfo, fsReader);
        if (basicFileInfo2.Offset > basicFileInfo1.Offset)
          basicFileInfo2.Offset += num;
        if (basicFileInfo2.Name == replaceRule.Path)
        {
          basicFileInfo2.Size = replaceRule.Source.Size;
          basicFileInfo2.Source = (SourceInterface) new CliCompatibleSource(replaceRule.Source);
        }
        else
          basicFileInfo2.Source = (SourceInterface) new CliCompatibleSource((ISource) new FileSystemArchvieFileSource(fsReader, basicFileInfo2.Name));
        basicFileInfoList.Add(basicFileInfo2);
      }
      addEntryDelegate((IEnumerable<ArchiveReconstructionUtils.BasicFileInfo>) basicFileInfoList);
    }

    private static PartitionFileSystemInfo GetPartitionFsInfo(IFileSystemArchiveReader fsReader, EntryReplaceRule replaceRule)
    {
      PartitionFileSystemInfo fsInfo = new PartitionFileSystemInfo();
      ArchiveReconstructionUtils.AddEntryToFsInfo addEntryDelegate = (ArchiveReconstructionUtils.AddEntryToFsInfo) (fileInfoList =>
      {
        foreach (ArchiveReconstructionUtils.BasicFileInfo fileInfo in fileInfoList)
          fsInfo.entries.Add(new PartitionFileSystemInfo.EntryInfo()
          {
            type = "source",
            name = fileInfo.Name,
            size = (ulong) fileInfo.Size,
            offset = (ulong) fileInfo.Offset,
            path = (string) null,
            sourceInterface = fileInfo.Source
          });
      });
      ArchiveReconstructionUtils.GetFsInfo(fsReader, replaceRule, addEntryDelegate);
      return fsInfo;
    }

    private static RomFsFileSystemInfo GetRomFsInfo(IFileSystemArchiveReader fsReader, EntryReplaceRule replaceRule)
    {
      RomFsFileSystemInfo fsInfo = new RomFsFileSystemInfo();
      DirectoryList directories = new DirectoryList();
      ArchiveReconstructionUtils.AddEntryToFsInfo addEntryDelegate = (ArchiveReconstructionUtils.AddEntryToFsInfo) (fileInfoList =>
      {
        foreach (ArchiveReconstructionUtils.BasicFileInfo fileInfo in fileInfoList)
        {
          RomFsFileSystemInfo.EntryInfo entryInfo = new RomFsFileSystemInfo.EntryInfo();
          entryInfo.type = "source";
          entryInfo.name = "/" + fileInfo.Name;
          entryInfo.size = (ulong) fileInfo.Size;
          entryInfo.offset = (ulong) fileInfo.Offset;
          entryInfo.path = (string) null;
          entryInfo.sourceInterface = fileInfo.Source;
          fsInfo.entries.Add(entryInfo);
          ++fsInfo.fileEntryCount;
          directories.AddAncestors(Path.GetDirectoryName(entryInfo.name));
        }
      });
      ArchiveReconstructionUtils.GetFsInfo(fsReader, replaceRule, addEntryDelegate);
      fsInfo.directoryEntryCount = directories.Count;
      return fsInfo;
    }

    private static NintendoContentFileSystemInfo.EntryInfo GetCommonFsEntry(NintendoContentArchiveFsHeaderInfo fsHeaderInfo, int fsIndex)
    {
      return new NintendoContentFileSystemInfo.EntryInfo()
      {
        type = "source",
        formatType = fsHeaderInfo.GetFormatType(),
        version = fsHeaderInfo.GetVersion(),
        hashType = fsHeaderInfo.GetHashType(),
        encryptionType = fsHeaderInfo.GetEncryptionType(),
        partitionIndex = fsIndex,
        sourceInterface = (SourceInterface) null
      };
    }

    private static NintendoContentFileSystemInfo.EntryInfo GetFsEntry(NintendoContentArchiveReader ncaReader, int fsIndex)
    {
      NintendoContentArchiveFsHeaderInfo fsInfo = (NintendoContentArchiveFsHeaderInfo) null;
      IFileSystemArchiveReader reader = ncaReader.OpenFileSystemArchiveReader(fsIndex, ref fsInfo);
      NintendoContentFileSystemInfo.EntryInfo commonFsEntry = ArchiveReconstructionUtils.GetCommonFsEntry(fsInfo, fsIndex);
      FileSystemArchvieBaseSource archvieBaseSource = new FileSystemArchvieBaseSource(reader);
      commonFsEntry.sourceInterface = (SourceInterface) new CliCompatibleSource((ISource) archvieBaseSource);
      return commonFsEntry;
    }

    private static NintendoContentFileSystemInfo.EntryInfo GetFsEntry(NintendoContentArchiveReader ncaReader, int fsIndex, EntryReplaceRule replaceRule)
    {
      NintendoContentArchiveFsHeaderInfo fsInfo = (NintendoContentArchiveFsHeaderInfo) null;
      IFileSystemArchiveReader systemArchiveReader = ncaReader.OpenFileSystemArchiveReader(fsIndex, ref fsInfo);
      NintendoContentFileSystemInfo.EntryInfo commonFsEntry = ArchiveReconstructionUtils.GetCommonFsEntry(fsInfo, fsIndex);
      Tuple<long, long> tuple = systemArchiveReader.GetFileFragmentList(replaceRule.Path).First<Tuple<long, long>>();
      long offset = tuple.Item1;
      if (tuple.Item2 == replaceRule.Source.Size)
      {
        AdaptedSource adaptedSource = new AdaptedSource((ISource) new FileSystemArchvieBaseSource(systemArchiveReader), replaceRule.Source, offset, replaceRule.Source.Size);
        commonFsEntry.sourceInterface = (SourceInterface) new CliCompatibleSource((ISource) adaptedSource);
      }
      else if (commonFsEntry.formatType == "RomFs")
      {
        RomFsArchiveSource romFsArchiveSource = new RomFsArchiveSource(ArchiveReconstructionUtils.GetRomFsInfo(systemArchiveReader, replaceRule));
        commonFsEntry.sourceInterface = (SourceInterface) new CliCompatibleSource((ISource) romFsArchiveSource);
      }
      else if (commonFsEntry.formatType == "PartitionFs")
      {
        PartitionFsArchiveSource partitionFsArchiveSource = new PartitionFsArchiveSource(ArchiveReconstructionUtils.GetPartitionFsInfo(systemArchiveReader, replaceRule));
        commonFsEntry.sourceInterface = (SourceInterface) new CliCompatibleSource((ISource) partitionFsArchiveSource);
      }
      return commonFsEntry;
    }

    private static NintendoContentFileSystemInfo GetCommonNcaInfo(NintendoContentArchiveReader ncaReader)
    {
      return new NintendoContentFileSystemInfo()
      {
        distributionType = ncaReader.GetDistributionType(),
        contentType = ncaReader.GetContentType(),
        keyGeneration = ncaReader.GetKeyGeneration(),
        programId = ncaReader.GetProgramId(),
        contentIndex = ncaReader.GetContentIndex(),
        numFsEntries = ncaReader.GetFsCount(),
        sdkAddonVersion = ncaReader.GetSdkAddonVersion(),
        keyAreaEncryptionKeyIndex = 0,
        isProdEncryption = false
      };
    }

    internal static NintendoContentFileSystemInfo GetProdNcaInfo(NintendoContentArchiveReader ncaReader)
    {
      NintendoContentFileSystemInfo commonNcaInfo = ArchiveReconstructionUtils.GetCommonNcaInfo(ncaReader);
      commonNcaInfo.keyAreaEncryptionKeyIndex = (byte) 0;
      commonNcaInfo.isProdEncryption = true;
      for (int fsIndex = 0; fsIndex < commonNcaInfo.numFsEntries; ++fsIndex)
        commonNcaInfo.fsEntries.Add(ArchiveReconstructionUtils.GetFsEntry(ncaReader, fsIndex));
      return commonNcaInfo;
    }

    internal static NintendoContentFileSystemInfo GetReplacedNcaInfo(NintendoContentArchiveReader ncaReader, string descFilePath, EntryReplaceRule replaceRule)
    {
      NintendoContentFileSystemInfo commonNcaInfo = ArchiveReconstructionUtils.GetCommonNcaInfo(ncaReader);
      commonNcaInfo.keyAreaEncryptionKeyIndex = ncaReader.GetKeyIndex();
      commonNcaInfo.isProdEncryption = false;
      if (descFilePath != null)
        NintendoContentAdfReader.RetrieveInfoFromDesc(ref commonNcaInfo, descFilePath);
      else if (replaceRule != null && commonNcaInfo.contentType == (byte) 0)
        throw new Exception("Replacing 'Program' content needs desc file.");
      for (int fsIndex = 0; fsIndex < commonNcaInfo.numFsEntries; ++fsIndex)
      {
        string str = string.Format("fs{0}", (object) fsIndex);
        if (replaceRule != null && replaceRule.Path.StartsWith(str))
        {
          EntryReplaceRule replaceRule1 = replaceRule;
          replaceRule1.Path = replaceRule1.Path.Substring(str.Length + 1);
          commonNcaInfo.fsEntries.Add(ArchiveReconstructionUtils.GetFsEntry(ncaReader, fsIndex, replaceRule1));
        }
        else
          commonNcaInfo.fsEntries.Add(ArchiveReconstructionUtils.GetFsEntry(ncaReader, fsIndex));
      }
      return commonNcaInfo;
    }

    private static ModelType ReadXml<ModelType>(NintendoSubmissionPackageReader nspReader, string fileName, long fileSize)
    {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (ModelType));
      using (MemoryStream memoryStream = new MemoryStream((int) fileSize))
      {
        byte[] buffer = nspReader.ReadFile(fileName, 0L, fileSize);
        memoryStream.Write(buffer, 0, buffer.Length);
        memoryStream.Seek(0L, SeekOrigin.Begin);
        return (ModelType) xmlSerializer.Deserialize((Stream) memoryStream);
      }
    }

    private static void GetCommonContentMetaInfo(ref NintendoSubmissionPackageFileSystemInfo.EntryInfo entry, string contentMetaFileName, ContentMetaModel model, NintendoSubmissionPackageReader nspReader, KeyConfiguration keyConfig)
    {
      IFileSystemArchiveReader systemArchiveReader = nspReader.OpenNintendoContentArchiveReader(contentMetaFileName, keyConfig.GetKeyAreaEncryptionKeys()).OpenFileSystemArchiveReader(0);
      Tuple<string, long> tuple = systemArchiveReader.ListFileInfo().Single<Tuple<string, long>>();
      entry.ContentMetaInfo = new NintendoSubmissionPackageFileSystemInfo.ContentMetaInfo(systemArchiveReader.ReadFile(tuple.Item1, 0L, tuple.Item2), model);
      NintendoContentMetaReader contentMetaReader = new NintendoContentMetaReader(entry.ContentMetaInfo.Data);
      entry.MetaType = contentMetaReader.GetType();
    }

    private static NintendoSubmissionPackageFileSystemInfo GetNspInfo(NintendoSubmissionPackageReader nspReader, KeyConfiguration keyConfig, ArchiveReconstructionUtils.GetContentInfoDelegate getContentInfoImpl, ArchiveReconstructionUtils.GetContentMetaInfoDelegate getContentMetaInfoImpl)
    {
      NintendoSubmissionPackageFileSystemInfo packageFileSystemInfo = new NintendoSubmissionPackageFileSystemInfo();
      packageFileSystemInfo.Version = (byte) 0;
      foreach (Tuple<string, long> tuple in nspReader.ListFileInfo())
      {
        string fileName = tuple.Item1;
        long fileSize = tuple.Item2;
        if (fileName.EndsWith(".cnmt.xml"))
        {
          ContentMetaModel model = ArchiveReconstructionUtils.ReadXml<ContentMetaModel>(nspReader, fileName, fileSize);
          string type = model.Type;
          if (!(type == "Application"))
          {
            if (!(type == "Patch"))
            {
              if (type == "AddOnContent")
                model = (ContentMetaModel) ArchiveReconstructionUtils.ReadXml<AddOnContentContentMetaModel>(nspReader, fileName, fileSize);
            }
            else
              model = (ContentMetaModel) ArchiveReconstructionUtils.ReadXml<PatchContentMetaModel>(nspReader, fileName, fileSize);
          }
          else
            model = (ContentMetaModel) ArchiveReconstructionUtils.ReadXml<ApplicationContentMetaModel>(nspReader, fileName, fileSize);
          NintendoSubmissionPackageFileSystemInfo.EntryInfo entry = new NintendoSubmissionPackageFileSystemInfo.EntryInfo();
          entry.Contents = new List<NintendoSubmissionPackageFileSystemInfo.ContentInfo>();
          foreach (ContentModel content in model.ContentList)
          {
            if (!(content.Type == "Meta"))
            {
              NintendoSubmissionPackageFileSystemInfo.ContentInfo contentInfo = getContentInfoImpl(content);
              entry.Contents.Add(contentInfo);
            }
          }
          string contentMetaFileName = Path.GetFileNameWithoutExtension(fileName) + ".nca";
          getContentMetaInfoImpl(ref entry, contentMetaFileName, model);
          List<NintendoSubmissionPackageExtraData> list = nspReader.ListFileInfo().FindAll((Predicate<Tuple<string, long>>) (x =>
          {
            if (x.Item1.StartsWith(fileName.Replace(".cnmt.xml", "")))
              return x.Item1.EndsWith(".jpg");
            return false;
          })).Select<Tuple<string, long>, NintendoSubmissionPackageExtraData>((Func<Tuple<string, long>, NintendoSubmissionPackageExtraData>) (x =>
          {
            byte[] buffer = nspReader.ReadFile(x.Item1, 0L, x.Item2);
            return new NintendoSubmissionPackageExtraData(x.Item1, (ISource) new MemorySource(buffer, 0, buffer.Length));
          })).ToList<NintendoSubmissionPackageExtraData>();
          entry.ExtraData = list;
          packageFileSystemInfo.Entries.Add(entry);
        }
        if (fileName == "cardspec.xml")
        {
          CardSpecModel cardSpecModel = ArchiveReconstructionUtils.ReadXml<CardSpecModel>(nspReader, fileName, fileSize);
          packageFileSystemInfo.CardSize = Convert.ToInt32(cardSpecModel.Size, 10);
          packageFileSystemInfo.CardClockRate = Convert.ToInt32(cardSpecModel.ClockRate, 10);
        }
      }
      return packageFileSystemInfo;
    }

    internal static NintendoSubmissionPackageFileSystemInfo GetProdNspInfo(NintendoSubmissionPackageReader nspReader, KeyConfiguration keyConfig)
    {
      ArchiveReconstructionUtils.GetContentInfoDelegate getContentInfoImpl = (ArchiveReconstructionUtils.GetContentInfoDelegate) (contentInfo => new NintendoSubmissionPackageFileSystemInfo.ContentInfo()
      {
        FsInfo = (Nintendo.Authoring.FileSystemMetaLibrary.FileSystemInfo) ArchiveReconstructionUtils.GetProdNcaInfo(nspReader.OpenNintendoContentArchiveReader(contentInfo.Id + ".nca", keyConfig.GetKeyAreaEncryptionKeys())),
        ContentType = contentInfo.Type
      });
      ArchiveReconstructionUtils.GetContentMetaInfoDelegate getContentMetaInfoImpl = (ArchiveReconstructionUtils.GetContentMetaInfoDelegate) ((ref NintendoSubmissionPackageFileSystemInfo.EntryInfo entry, string contentMetaFileName, ContentMetaModel model) => ArchiveReconstructionUtils.GetCommonContentMetaInfo(ref entry, contentMetaFileName, model, nspReader, keyConfig));
      NintendoSubmissionPackageFileSystemInfo nspInfo = ArchiveReconstructionUtils.GetNspInfo(nspReader, keyConfig, getContentInfoImpl, getContentMetaInfoImpl);
      nspInfo.IsProdEncryption = true;
      return nspInfo;
    }

    internal static NintendoSubmissionPackageFileSystemInfo GetReplacedNspInfo(NintendoSubmissionPackageReader nspReader, ISource inSource, string targetEntryPath, string descFilePath, KeyConfiguration keyConfig)
    {
      bool isReplaced = false;
      ArchiveReconstructionUtils.GetContentInfoDelegate getContentInfoImpl = (ArchiveReconstructionUtils.GetContentInfoDelegate) (contentInfo =>
      {
        NintendoSubmissionPackageFileSystemInfo.ContentInfo contentInfo1 = new NintendoSubmissionPackageFileSystemInfo.ContentInfo();
        string fileName = contentInfo.Id + ".nca";
        NintendoContentArchiveReader ncaReader = nspReader.OpenNintendoContentArchiveReader(fileName, keyConfig.GetKeyAreaEncryptionKeys());
        if (targetEntryPath.StartsWith(fileName))
        {
          contentInfo1.FsInfo = (Nintendo.Authoring.FileSystemMetaLibrary.FileSystemInfo) ArchiveReconstructionUtils.GetReplacedNcaInfo(ncaReader, descFilePath, new EntryReplaceRule()
          {
            Source = inSource,
            Path = targetEntryPath.Substring(fileName.Length + 1)
          });
          isReplaced = true;
        }
        else
          contentInfo1.Source = (ISource) new FileSystemArchvieFileSource((IFileSystemArchiveReader) nspReader, fileName);
        contentInfo1.ContentType = contentInfo.Type;
        return contentInfo1;
      });
      ArchiveReconstructionUtils.GetContentMetaInfoDelegate getContentMetaInfoImpl = (ArchiveReconstructionUtils.GetContentMetaInfoDelegate) ((ref NintendoSubmissionPackageFileSystemInfo.EntryInfo entry, string contentMetaFileName, ContentMetaModel model) =>
      {
        ArchiveReconstructionUtils.GetCommonContentMetaInfo(ref entry, contentMetaFileName, model, nspReader, keyConfig);
        if (!targetEntryPath.StartsWith(contentMetaFileName) || !targetEntryPath.EndsWith(".cnmt"))
          return;
        NintendoContentMetaReader contentMetaReader1 = new NintendoContentMetaReader(entry.ContentMetaInfo.Data);
        ulong id1 = contentMetaReader1.GetId();
        uint version1 = contentMetaReader1.GetVersion();
        if (inSource.Size != (long) entry.ContentMetaInfo.Data.Length)
          throw new Exception(".cnmt file specified to be replaced is invalid.");
        ByteData byteData = inSource.PullData(0L, (int) inSource.Size);
        ArraySegment<byte> buffer = byteData.Buffer;
        byte[] array = buffer.Array;
        buffer = byteData.Buffer;
        int offset = buffer.Offset;
        byte[] data = entry.ContentMetaInfo.Data;
        int dstOffset = 0;
        int count = byteData.Buffer.Count;
        Buffer.BlockCopy((Array) array, offset, (Array) data, dstOffset, count);
        NintendoContentMetaReader contentMetaReader2 = new NintendoContentMetaReader(entry.ContentMetaInfo.Data);
        ulong id2 = contentMetaReader2.GetId();
        if ((long) id1 != (long) id2)
          throw new ArgumentException(string.Format("Ids of content meta are different. (oldId = {0:x16}, newID = {0:x16})", (object) id1, (object) id2));
        uint version2 = contentMetaReader2.GetVersion();
        Log.Info(string.Format("content meta (ID = {0:x16}) will be replaced : version {1} -> {2}", (object) id1, (object) version1, (object) version2));
        isReplaced = true;
      });
      NintendoSubmissionPackageFileSystemInfo nspInfo = ArchiveReconstructionUtils.GetNspInfo(nspReader, keyConfig, getContentInfoImpl, getContentMetaInfoImpl);
      if (isReplaced)
        return nspInfo;
      throw new Exception("nothing was replaced.");
    }

    internal static PartitionFileSystemInfo GetMergedNspInfo(List<NintendoSubmissionPackageReader> nspReaderList)
    {
      long num1 = 0;
      PartitionFileSystemInfo partitionFileSystemInfo = new PartitionFileSystemInfo();
      partitionFileSystemInfo.version = 0;
      foreach (NintendoSubmissionPackageReader nspReader in nspReaderList)
      {
        foreach (Tuple<string, long> tuple in nspReader.ListFileInfo())
        {
          string fileName = tuple.Item1;
          long num2 = tuple.Item2;
          if (!partitionFileSystemInfo.entries.Where<PartitionFileSystemInfo.EntryInfo>((Func<PartitionFileSystemInfo.EntryInfo, bool>) (x => x.name == fileName)).Any<PartitionFileSystemInfo.EntryInfo>())
          {
            PartitionFileSystemInfo.EntryInfo entryInfo = PartitionFileSystemInfo.EntryInfo.Make(fileName, (ulong) num2, (ulong) num1);
            entryInfo.type = "source";
            entryInfo.sourceInterface = (SourceInterface) new CliCompatibleSource((ISource) new FileSystemArchvieFileSource((IFileSystemArchiveReader) nspReader, fileName));
            partitionFileSystemInfo.entries.Add(entryInfo);
            num1 += num2;
          }
        }
      }
      return partitionFileSystemInfo;
    }

    private class BasicFileInfo
    {
      public string Name { get; private set; }

      public long Size { get; set; }

      public long Offset { get; set; }

      public SourceInterface Source { get; set; }

      public BasicFileInfo(Tuple<string, long> fileInfo, IFileSystemArchiveReader fsReader)
      {
        this.Name = fileInfo.Item1;
        this.Size = fileInfo.Item2;
        this.Offset = fsReader.GetFileFragmentList(this.Name).First<Tuple<long, long>>().Item1;
        this.Source = (SourceInterface) null;
      }
    }

    private delegate void AddEntryToFsInfo(IEnumerable<ArchiveReconstructionUtils.BasicFileInfo> fileInfoList);

    private delegate NintendoSubmissionPackageFileSystemInfo.ContentInfo GetContentInfoDelegate(ContentModel contentInfo);

    private delegate void GetContentMetaInfoDelegate(ref NintendoSubmissionPackageFileSystemInfo.EntryInfo entry, string contentMetaFileName, ContentMetaModel model);
  }
}
