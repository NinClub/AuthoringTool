// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoSubmissionPackageArchiveUtils
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.ApplicationControlProperty;
using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoSubmissionPackageArchiveUtils
  {
    public static bool HasControlContent(List<NintendoSubmissionPackageFileSystemInfo.ContentInfo> contentInfos)
    {
      return (uint) contentInfos.Where<NintendoSubmissionPackageFileSystemInfo.ContentInfo>((Func<NintendoSubmissionPackageFileSystemInfo.ContentInfo, bool>) (x => x.ContentType == "Control")).ToList<NintendoSubmissionPackageFileSystemInfo.ContentInfo>().Count > 0U;
    }

    public static bool HasProgramContent(List<NintendoSubmissionPackageFileSystemInfo.ContentInfo> contentInfos)
    {
      return (uint) contentInfos.Where<NintendoSubmissionPackageFileSystemInfo.ContentInfo>((Func<NintendoSubmissionPackageFileSystemInfo.ContentInfo, bool>) (x => x.ContentType == "Program")).ToList<NintendoSubmissionPackageFileSystemInfo.ContentInfo>().Count > 0U;
    }

    private static IFileSystemArchiveReader OpenFsReader(NintendoContentFileSystemInfo.EntryInfo entry, Stream stream)
    {
      string formatType = entry.formatType;
      if (formatType == "PartitionFs")
        return (IFileSystemArchiveReader) new PartitionFileSystemArchiveReader(stream);
      if (formatType == "RomFs")
        return (IFileSystemArchiveReader) new RomFsFileSystemArchiveReader(stream);
      throw new NotImplementedException();
    }

    public static ProgramInfoXml GetProgramInfoXml(List<NintendoSubmissionPackageFileSystemInfo.ContentInfo> contentInfos, KeyConfiguration config)
    {
      NintendoSubmissionPackageFileSystemInfo.ContentInfo contentInfo = contentInfos.Where<NintendoSubmissionPackageFileSystemInfo.ContentInfo>((Func<NintendoSubmissionPackageFileSystemInfo.ContentInfo, bool>) (x => x.ContentType == "Program")).ToList<NintendoSubmissionPackageFileSystemInfo.ContentInfo>().Single<NintendoSubmissionPackageFileSystemInfo.ContentInfo>();
      string fileName = "main";
      string filePath = "";
      byte[] data = (byte[]) null;
      bool flag = false;
      if (contentInfo.FsInfo != null)
      {
        NintendoContentFileSystemInfo.EntryInfo entryInfo = (contentInfo.FsInfo as NintendoContentFileSystemInfo).fsEntries.Where<NintendoContentFileSystemInfo.EntryInfo>((Func<NintendoContentFileSystemInfo.EntryInfo, bool>) (x => x.partitionIndex == 0)).Single<NintendoContentFileSystemInfo.EntryInfo>();
        PartitionFileSystemInfo fileSystemInfo = (PartitionFileSystemInfo) entryInfo.fileSystemInfo;
        if (fileSystemInfo != null && fileSystemInfo.entries.Where<PartitionFileSystemInfo.EntryInfo>((Func<PartitionFileSystemInfo.EntryInfo, bool>) (x => x.name == fileName)).Count<PartitionFileSystemInfo.EntryInfo>() == 1)
        {
          flag = true;
          filePath = fileSystemInfo.entries.Where<PartitionFileSystemInfo.EntryInfo>((Func<PartitionFileSystemInfo.EntryInfo, bool>) (x => x.name == fileName)).Single<PartitionFileSystemInfo.EntryInfo>().path;
          using (SourceBasedStream sourceBasedStream = new SourceBasedStream(NintendoContentArchiveSource.GetDataSource(entryInfo)))
          {
            IFileSystemArchiveReader systemArchiveReader = NintendoSubmissionPackageArchiveUtils.OpenFsReader(entryInfo, (Stream) sourceBasedStream);
            data = systemArchiveReader.ReadFile(fileName, 0L, systemArchiveReader.GetFileSize(fileName));
          }
        }
      }
      else
      {
        if (contentInfo.Source == null)
          throw new NotImplementedException();
        byte[][] areaEncryptionKeys = config.GetKeyAreaEncryptionKeys();
        using (SourceBasedStream sourceBasedStream = new SourceBasedStream(contentInfo.Source))
        {
          IFileSystemArchiveReader systemArchiveReader = new NintendoContentArchiveReader((Stream) sourceBasedStream, areaEncryptionKeys).OpenFileSystemArchiveReader(0);
          if (systemArchiveReader.ListFileInfo().Where<Tuple<string, long>>((Func<Tuple<string, long>, bool>) (x => x.Item1 == fileName)).Count<Tuple<string, long>>() == 1)
          {
            flag = true;
            filePath = systemArchiveReader.ListFileInfo().Where<Tuple<string, long>>((Func<Tuple<string, long>, bool>) (x => x.Item1 == fileName)).Single<Tuple<string, long>>().Item1;
            data = systemArchiveReader.ReadFile(fileName, 0L, systemArchiveReader.GetFileSize(fileName));
          }
        }
      }
      if (!flag)
      {
        Log.Warning("\"main\" was not found in code region.");
        data = new byte[0];
      }
      return new ProgramInfoXml(new SymbolExtract(data, filePath));
    }

    public static ApplicationControlPropertyModel GetApplicationControlProperty(List<NintendoSubmissionPackageFileSystemInfo.ContentInfo> contentInfos, KeyConfiguration config)
    {
      List<NintendoSubmissionPackageFileSystemInfo.ContentInfo> list = contentInfos.Where<NintendoSubmissionPackageFileSystemInfo.ContentInfo>((Func<NintendoSubmissionPackageFileSystemInfo.ContentInfo, bool>) (x => x.ContentType == "Control")).ToList<NintendoSubmissionPackageFileSystemInfo.ContentInfo>();
      if (list.Count > 1)
        throw new NotImplementedException("Multiple control contents in an Application are not supported.");
      NintendoSubmissionPackageFileSystemInfo.ContentInfo contentInfo = list.Single<NintendoSubmissionPackageFileSystemInfo.ContentInfo>();
      string fileName = "control.nacp";
      byte[] bytes;
      if (contentInfo.FsInfo != null)
      {
        NintendoContentFileSystemInfo.EntryInfo entryInfo = (contentInfo.FsInfo as NintendoContentFileSystemInfo).fsEntries.Single<NintendoContentFileSystemInfo.EntryInfo>();
        using (SourceBasedStream sourceBasedStream = new SourceBasedStream(NintendoContentArchiveSource.GetDataSource(entryInfo)))
        {
          IFileSystemArchiveReader systemArchiveReader = NintendoSubmissionPackageArchiveUtils.OpenFsReader(entryInfo, (Stream) sourceBasedStream);
          bytes = systemArchiveReader.ReadFile(fileName, 0L, systemArchiveReader.GetFileSize(fileName));
        }
      }
      else
      {
        if (contentInfo.Source == null)
          throw new NotImplementedException();
        byte[][] areaEncryptionKeys = config.GetKeyAreaEncryptionKeys();
        using (SourceBasedStream sourceBasedStream = new SourceBasedStream(contentInfo.Source))
        {
          IFileSystemArchiveReader systemArchiveReader = new NintendoContentArchiveReader((Stream) sourceBasedStream, areaEncryptionKeys).OpenFileSystemArchiveReader(0);
          bytes = systemArchiveReader.ReadFile(fileName, 0L, systemArchiveReader.GetFileSize(fileName));
        }
      }
      return ApplicationControlPropertyModel.PropertyBytesToModel(bytes);
    }
  }
}
