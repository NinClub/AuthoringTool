// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.MiddlewareXml
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class MiddlewareXml
  {
    private MiddlewareModel m_model;

    public MiddlewareList m_middlewareList { get; set; }

    public MiddlewareXml()
    {
      this.m_middlewareList = new MiddlewareList();
      this.m_middlewareList.Entries = new List<MiddlewareModel>();
    }

    public MiddlewareXml(ModuleInfo[] moduleInfos)
    {
      this.m_middlewareList = new MiddlewareList();
      this.m_middlewareList.Entries = new List<MiddlewareModel>();
      foreach (ModuleInfo moduleInfo in moduleInfos)
      {
        this.m_model = new MiddlewareModel();
        this.m_model.ModuleName = moduleInfo.moduleName;
        this.m_model.VenderName = moduleInfo.VenderName;
        this.m_model.NsoName = moduleInfo.fileName;
        this.m_middlewareList.Entries.Add(this.m_model);
      }
    }
  }
}
