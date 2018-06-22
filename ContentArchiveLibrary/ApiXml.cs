// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ApiXml
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ApiXml
  {
    private ApiModel m_model;

    public ApiList m_apiList { get; set; }

    public ApiXml()
    {
      this.m_apiList = new ApiList();
      this.m_apiList.Entries = new List<ApiModel>();
      this.m_model = new ApiModel();
    }
  }
}
