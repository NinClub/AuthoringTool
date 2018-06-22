// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.ListOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class ListOption : IOption
  {
    internal string InputFile { get; set; }

    internal ListOption()
    {
      this.InputFile = (string) null;
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("list: List information about the files included in an archive file.");
      Console.WriteLine("Usage: {0} list <inputPath>", (object) baseName);
    }

    public OptionDescription[] GetOptionDescription()
    {
      return (OptionDescription[]) null;
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (args.Length != 1)
        throw new InvalidOptionException("input archive file must be specified for list subcommand.");
      this.InputFile = args[0];
    }
  }
}
