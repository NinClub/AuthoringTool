// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.HelpOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class HelpOption : IOption
  {
    internal List<Option.SubCommandType> SubCommandList { get; private set; }

    internal HelpOption()
    {
      this.SubCommandList = new List<Option.SubCommandType>();
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("help: Describe the usage of this program or its subcommands.");
      Console.WriteLine("Usage: {0} help [subcommand]", (object) baseName);
    }

    public OptionDescription[] GetOptionDescription()
    {
      return (OptionDescription[]) null;
    }

    public void ParsePositionalArgument(string[] args)
    {
      for (int index = 0; index < args.Length; ++index)
      {
        Option.SubCommandType subCommandType = Option.GetSubCommandType(args[index]);
        if (subCommandType != Option.SubCommandType.None)
          this.SubCommandList.Add(subCommandType);
      }
    }
  }
}
