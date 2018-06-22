// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.DebugApiXml
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class DebugApiXml
  {
    private DebugApiModel m_model;

    public DebugApiList m_debugApiList { get; set; }

    public DebugApiXml()
    {
      this.m_debugApiList = new DebugApiList();
      this.m_debugApiList.Entries = new List<DebugApiModel>();
    }

    public DebugApiXml(ModuleInfo[] moduleInfos)
    {
      this.m_debugApiList = new DebugApiList();
      this.m_debugApiList.Entries = new List<DebugApiModel>();
      foreach (ModuleInfo moduleInfo in moduleInfos)
      {
        this.m_model = new DebugApiModel();
        this.m_model.ApiName = moduleInfo.moduleName;
        this.m_model.VenderName = moduleInfo.VenderName;
        this.m_model.NsoName = moduleInfo.fileName;
        this.m_debugApiList.Entries.Add(this.m_model);
      }
    }
  }
}
