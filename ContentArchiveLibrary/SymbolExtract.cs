// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SymbolExtract
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SymbolExtract
  {
    private List<NsoFile> nsoFileList;
    private List<ModuleInfo> moduleInfoList;

    public SymbolExtract(byte[] data, string filePath)
    {
      this.moduleInfoList = new List<ModuleInfo>();
      this.nsoFileList = new List<NsoFile>();
      NsoFile nsoFile = new NsoFile();
      nsoFile.ParseNsoData(data, filePath);
      this.nsoFileList.Add(nsoFile);
      string[] apiInfoStrings = nsoFile.GetApiInfoStrings();
      if (apiInfoStrings == null)
        return;
      foreach (string infoString in apiInfoStrings)
        this.moduleInfoList.Add(this.GetModuleInfo(nsoFile.fileName, infoString));
    }

    public ModuleInfo[] GetDebugApiInfos()
    {
      return this.moduleInfoList.Where<ModuleInfo>((Func<ModuleInfo, bool>) (p => p.type == ModuleInfoType.DebugApiInfo)).ToArray<ModuleInfo>();
    }

    public ModuleInfo[] GetMiddlewareInfos()
    {
      return this.moduleInfoList.Where<ModuleInfo>((Func<ModuleInfo, bool>) (p => p.type == ModuleInfoType.MiddlewareInfo)).ToArray<ModuleInfo>();
    }

    private ModuleInfo GetModuleInfo(string path, string infoString)
    {
      ModuleInfo moduleInfo = new ModuleInfo();
      moduleInfo.fileName = path;
      Regex regex1 = new Regex("\\[SDK MW\\+([^\\[\\]+:]*):([^\\[\\]+:]*)\\]");
      Regex regex2 = new Regex("\\[SDK Debug\\+([^\\[\\]+:]*):([^\\[\\]+:]*)\\]");
      if (regex1.IsMatch(infoString))
      {
        moduleInfo.type = ModuleInfoType.MiddlewareInfo;
        moduleInfo.VenderName = regex1.Match(infoString).Groups[1].Value;
        moduleInfo.moduleName = regex1.Match(infoString).Groups[2].Value;
      }
      else
      {
        if (!regex2.IsMatch(infoString))
          throw new Exception("不正なモジュール情報です。\n" + infoString);
        moduleInfo.type = ModuleInfoType.DebugApiInfo;
        moduleInfo.VenderName = regex2.Match(infoString).Groups[1].Value;
        moduleInfo.moduleName = regex2.Match(infoString).Groups[2].Value;
      }
      return moduleInfo;
    }
  }
}
