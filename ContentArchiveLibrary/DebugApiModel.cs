// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.DebugApiModel
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("DebugApi")]
  public class DebugApiModel
  {
    [XmlElement("ApiName", IsNullable = false)]
    public string ApiName { get; set; }

    [XmlElement("VenderName", IsNullable = false)]
    public string VenderName { get; set; }

    [XmlElement("NsoName", IsNullable = false)]
    public string NsoName { get; set; }
  }
}
