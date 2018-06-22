// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.ReplaceOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class ReplaceOption : IOption
  {
    internal string InputFile { get; set; }

    internal string DescFilePath { get; set; }

    internal string OutputDirectory { get; set; }

    internal string TargetEntryPath { get; set; }

    internal string InputEntryFilePath { get; set; }

    internal ReplaceOption()
    {
      this.InputFile = (string) null;
      this.DescFilePath = (string) null;
      this.OutputDirectory = ".";
      this.TargetEntryPath = (string) null;
      this.InputEntryFilePath = (string) null;
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("replace: Replace files from a Nintendo Submission Package or Nintendo Content Archive file.");
      Console.WriteLine("Usage: {0} replace [-o <outputDirectory>] <inputNspOrNcaPath> <targetEntryPath> <inputEntryFilePath>", (object) baseName);
      Console.WriteLine("Usage: {0} replace [-o <outputDirectory>] --desc <descFilePath> <inputNspOrNcaPath> <targetEntryPath> <inputEntryFilePath>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputDirectory>                 Directory path to output. If directory path is specified, output to current directory");
      Console.WriteLine("  --desc <descFilePath>                Location of .desc file to input. This cannot be omitted when replacing a program content.");
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[2]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputDirectory = OptionUtil.GetOutputFilePath(this.OutputDirectory, s.First<string>()))),
        new OptionDescription((string) null, "--desc", 1, (Action<List<string>>) (s => this.DescFilePath = s.First<string>()))
      };
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (args.Length < 3)
        throw new InvalidOptionException("too few arguments for replace subcommand.");
      this.InputFile = args[0];
      this.TargetEntryPath = args[1];
      this.InputEntryFilePath = args[2];
    }
  }
}
