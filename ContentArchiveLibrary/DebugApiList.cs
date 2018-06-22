// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.DebugApiList
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("DebugApiList", IsNullable = false)]
  public class DebugApiList
  {
    [XmlElement("DebugApi")]
    public List<DebugApiModel> Entries { get; set; }
  }
}
