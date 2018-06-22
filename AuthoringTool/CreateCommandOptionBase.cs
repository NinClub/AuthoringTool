// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.CreateCommandOptionBase
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class CreateCommandOptionBase
  {
    internal string InputAdfFile { get; set; }

    internal string InputFdfPath { get; set; }

    internal string OutputFile { get; set; }

    internal bool IsSaveAdf { get; set; }

    internal bool IsOnlyAdf { get; set; }

    internal CreateCommandOptionBase()
    {
      this.InputAdfFile = (string) null;
      this.InputFdfPath = (string) null;
      this.OutputFile = "./output";
      this.IsSaveAdf = false;
      this.IsOnlyAdf = false;
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[4]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputFile = OptionUtil.GetOutputFilePath(this.OutputFile, s.First<string>()))),
        new OptionDescription("--filter", (string) null, 1, (Action<List<string>>) (s => this.InputFdfPath = s.First<string>())),
        new OptionDescription("--save-adf", (string) null, 0, (Action<List<string>>) (s => this.IsSaveAdf = true)),
        new OptionDescription("--only-adf", (string) null, 0, (Action<List<string>>) (s => this.IsOnlyAdf = true))
      };
    }
  }
}
