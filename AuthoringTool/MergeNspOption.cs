// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.MergeNspOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class MergeNspOption : IOption
  {
    internal List<string> InputFiles { get; set; }

    internal string OutputFile { get; set; }

    internal MergeNspOption()
    {
      this.InputFiles = new List<string>();
      this.OutputFile = "./output.nsp";
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("mergensp: Merge the contents included in multiple Nintendo Submission Packages into one nsp file.");
      Console.WriteLine("Usage: {0} mergensp [-o <outputPath>] <inputNspOrNcaPath>...", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputPath>              File path to output. If directory path is specified, output to <outputPath>/output.nsp.");
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[1]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputFile = OptionUtil.GetOutputFilePath(this.OutputFile, s.First<string>())))
      };
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (args.Length < 2)
        throw new InvalidOptionException("too few arguments for mergensp subcommand.");
      for (int index = 0; index < args.Length; ++index)
        this.InputFiles.Add(OptionUtil.CheckAndNormalizeFilePath(args[index], string.Format("arg[{0}]", (object) index)));
    }
  }
}
