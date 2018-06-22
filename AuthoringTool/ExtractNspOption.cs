// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.ExtractNspOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class ExtractNspOption : IOption
  {
    internal string InputNspFile { get; set; }

    internal string OutputDirectory { get; set; }

    internal ExtractNspOption()
    {
      this.InputNspFile = (string) null;
      this.OutputDirectory = ".";
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("extractnsp: Extract files from a Nintendo Submission Package file.");
      Console.WriteLine("Usage: {0} extractnsp [-o <outputDirectory>] <inputNspPath>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputDirectory>                 Directory path to output. If directory path is specified, output to current directory");
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[1]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputDirectory = OptionUtil.GetOutputFilePath(this.OutputDirectory, s.First<string>())))
      };
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (args.Length == 0)
        throw new InvalidOptionException("input nsp file must be specified for extractnsp subcommand.");
      this.InputNspFile = args[0];
    }
  }
}
