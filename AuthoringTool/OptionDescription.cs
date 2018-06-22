// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.OptionDescription
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class OptionDescription
  {
    public OptionDescription(string longName, string shortName, int hasArgument, System.Action<List<string>> action)
    {
      this.LongName = longName;
      this.ShortName = shortName;
      this.HasArgument = hasArgument;
      this.Action = action;
    }

    public string LongName { get; set; }

    public string ShortName { get; set; }

    public int HasArgument { get; set; }

    public System.Action<List<string>> Action { get; set; }
  }
}
