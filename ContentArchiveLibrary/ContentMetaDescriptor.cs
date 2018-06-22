// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ContentMetaDescriptor
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class ContentMetaDescriptor
  {
    public ContentMetaDescriptor(string type, ulong id, uint version, byte attributes, ulong applicationId, uint requiredDownloadSystemVersion, List<NintendoContentInfo> contentInfoList, List<NintendoContentMetaInfo> contentMetaInfoList, NintendoExtendedHeader extendedHeader, byte[] digest)
    {
      this.Type = type;
      this.Id = id;
      this.Version = version;
      this.Attributes = attributes;
      this.ContentInfoList = contentInfoList;
      this.ContentMetaInfoList = contentMetaInfoList;
      this.ExtendedHeader = extendedHeader;
      this.RequiredDownloadSystemVersion = requiredDownloadSystemVersion;
      this.Digest = digest;
    }

    public string Type { get; set; }

    public ulong Id { get; set; }

    public uint Version { get; set; }

    public byte Attributes { get; set; }

    public ulong ApplicationId { get; set; }

    public uint RequiredDownloadSystemVersion { get; set; }

    public List<NintendoContentInfo> ContentInfoList { get; set; }

    public List<NintendoContentMetaInfo> ContentMetaInfoList { get; set; }

    public NintendoExtendedHeader ExtendedHeader { get; set; }

    public byte[] Digest { get; set; }
  }
}
