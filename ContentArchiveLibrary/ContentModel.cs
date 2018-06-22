// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ContentModel
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("Content", IsNullable = false)]
  public class ContentModel
  {
    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("Id")]
    public string Id { get; set; }

    [XmlElement("Size")]
    public long Size { get; set; }

    [XmlElement("Hash")]
    public string Hash { get; set; }

    public void SetIdBytes(byte[] bytes)
    {
      this.Id = BitConverter.ToString(bytes, 0, NintendoContentMeta.GetContentInfoIdDataSize()).Replace("-", string.Empty).ToLower();
    }

    public void SetHashBytes(byte[] bytes)
    {
      this.Hash = BitConverter.ToString(bytes, 0, NintendoContentMeta.GetContentInfoHashSize()).Replace("-", string.Empty).ToLower();
    }
  }
}
