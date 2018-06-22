// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ContentMetaModel
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("ContentMeta", IsNullable = false)]
  public class ContentMetaModel
  {
    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("Id")]
    public string Id { get; set; }

    [XmlElement("Version")]
    public uint Version { get; set; }

    [XmlElement("ContentMetaAttribute")]
    public List<string> AttributeList { get; set; }

    [XmlElement("RequiredDownloadSystemVersion")]
    public uint RequiredDownloadSystemVersion { get; set; }

    [XmlElement("Content")]
    public List<ContentModel> ContentList { get; set; }

    [XmlElement("ContentMeta")]
    public List<ContentMetaModel> ContentMetaList { get; set; }

    [XmlElement("Digest")]
    public string Digest { get; set; }

    public ulong GetUInt64Id()
    {
      return Convert.ToUInt64(this.Id, 16);
    }

    public void SetUInt64Id(ulong id)
    {
      this.Id = "0x" + id.ToString("x16");
    }

    public void SetDigestBytes(byte[] bytes)
    {
      this.Digest = BitConverter.ToString(bytes, 0, NintendoContentMeta.GetDigestSize()).Replace("-", string.Empty).ToLower();
    }
  }
}
