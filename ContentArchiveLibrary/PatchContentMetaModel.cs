// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.PatchContentMetaModel
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("ContentMeta", IsNullable = false)]
  public class PatchContentMetaModel : ContentMetaModel
  {
    [XmlElement("RequiredSystemVersion")]
    public uint RequiredSystemVersion { get; set; }

    [XmlElement("ApplicationId")]
    public string ApplicationId { get; set; }

    public void SetUInt64ApplicationId(ulong id)
    {
      this.ApplicationId = "0x" + id.ToString("x16");
    }
  }
}
