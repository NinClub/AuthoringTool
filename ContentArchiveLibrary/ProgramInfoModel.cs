// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ProgramInfoModel
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("ProgramInfo", IsNullable = false)]
  public class ProgramInfoModel
  {
    [XmlElement("MiddlewareList")]
    public MiddlewareList MiddlewareListData { get; set; }

    [XmlElement("DebugApiList")]
    public DebugApiList DebugApiListData { get; set; }

    [XmlElement("ApiList")]
    public ApiList ApiListData { get; set; }
  }
}
