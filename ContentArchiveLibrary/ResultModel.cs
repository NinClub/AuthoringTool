// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ResultModel
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.ApplicationControlProperty;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("Result", IsNullable = false)]
  public class ResultModel
  {
    [XmlElement("Code")]
    public string Code { get; set; }

    [XmlElement("ErrorMessage")]
    public string ErrorMessage { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("Command")]
    public string Command { get; set; }

    [XmlElement("ToolVersion")]
    public string ToolVersion { get; set; }

    [XmlElement("ContentMeta")]
    public List<ContentMetaModel> ContentMetaList { get; set; }

    [XmlElement("ApplicationControlProperty")]
    public List<ApplicationControlPropertyModel> ApplicationControlPropertyList { get; set; }

    [XmlElement("Hash")]
    public string Hash { get; set; }

    [XmlElement("Size")]
    public long Size { get; set; }

    [XmlElement("CardParam")]
    public CardParamModel CardParam { get; set; }

    public void SetHashBytes(byte[] bytes)
    {
      this.Hash = BitConverter.ToString(bytes, 0, 32).Replace("-", string.Empty).ToLower();
    }

    public ResultModel()
    {
      this.Code = string.Empty;
      this.ErrorMessage = string.Empty;
      this.Date = string.Empty;
      this.Command = string.Empty;
      this.ToolVersion = string.Empty;
      this.ContentMetaList = new List<ContentMetaModel>();
      this.ApplicationControlPropertyList = new List<ApplicationControlPropertyModel>();
      this.Hash = string.Empty;
      this.Size = 0L;
    }
  }
}
