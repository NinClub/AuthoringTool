// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.ExtractOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class ExtractOption : IOption
  {
    internal string InputFile { get; set; }

    internal string OutputDirectory { get; set; }

    internal string TargetEntryPath { get; set; }

    internal ExtractOption()
    {
      this.InputFile = (string) null;
      this.OutputDirectory = ".";
      this.TargetEntryPath = (string) null;
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("extract: Extract files from a Nintendo Submission Package file or Nintendo Content Archive file.");
      Console.WriteLine("Usage: {0} extract [-o <outputDirectory>] [--target <targetPath>] <inputNspNcaPath>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputDirectory>                 Directory path to output. If directory path is specified, output to current directory");
      Console.WriteLine("  --target <targetEntryPath>           Path of the target entry to be extracted. If omitted, extract all entries");
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[2]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputDirectory = OptionUtil.GetOutputFilePath(this.OutputDirectory, s.First<string>()))),
        new OptionDescription((string) null, "--target", 1, (Action<List<string>>) (s => this.TargetEntryPath = s.First<string>()))
      };
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (args.Length == 0)
        throw new InvalidOptionException("input nca/nsp file must be specified for extract subcommand.");
      this.InputFile = args[0];
    }
  }
}
