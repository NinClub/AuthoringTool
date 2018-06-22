// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.IOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

namespace Nintendo.Authoring.AuthoringTool
{
  internal interface IOption
  {
    void ShowSubCommandUsage(string baseName);

    OptionDescription[] GetOptionDescription();

    void ParsePositionalArgument(string[] args);
  }
}
