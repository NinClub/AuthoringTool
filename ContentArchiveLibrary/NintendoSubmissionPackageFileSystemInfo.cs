// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoSubmissionPackageFileSystemInfo
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoSubmissionPackageFileSystemInfo
  {
    public byte Version { get; set; }

    public List<NintendoSubmissionPackageFileSystemInfo.EntryInfo> Entries { get; set; }

    public int CardSize { get; set; }

    public int CardClockRate { get; set; }

    public bool IsProdEncryption { get; set; }

    public bool EnableContentMetaBinaryExport { get; set; }

    public NintendoSubmissionPackageFileSystemInfo()
    {
      this.Entries = new List<NintendoSubmissionPackageFileSystemInfo.EntryInfo>();
      this.IsProdEncryption = false;
      this.EnableContentMetaBinaryExport = false;
    }

    public class ContentInfo
    {
      public string ContentType { get; set; }

      public FileSystemInfo FsInfo { get; set; }

      public ISource Source { get; set; }
    }

    public class ContentMetaInfo
    {
      public byte[] Data { get; set; }

      public ContentMetaModel Model { get; set; }

      public ContentMetaInfo(byte[] data, ContentMetaModel model)
      {
        this.Data = data;
        this.Model = model;
      }
    }

    public class EntryInfo
    {
      public NintendoSubmissionPackageFileSystemInfo.ContentMetaInfo ContentMetaInfo;

      public List<NintendoSubmissionPackageFileSystemInfo.ContentInfo> Contents { get; set; }

      public string MetaType { get; set; }

      public string MetaFilePath { get; set; }

      public string DescFilePath { get; set; }

      public int KeyIndex { get; set; }

      public List<NintendoSubmissionPackageExtraData> ExtraData { get; set; }

      public EntryInfo()
      {
        this.ExtraData = new List<NintendoSubmissionPackageExtraData>();
      }
    }
  }
}
