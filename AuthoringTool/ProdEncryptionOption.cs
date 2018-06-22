// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.ProdEncryptionOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class ProdEncryptionOption : IOption
  {
    internal string InputNspFile { get; set; }

    internal string InputUppNspFile { get; set; }

    internal string InputPatchNspFile { get; set; }

    internal string OutputDirectory { get; set; }

    internal bool CreateXci { get; set; }

    internal bool CreateXcie { get; set; }

    internal byte LaunchFlags { get; set; }

    private bool NoCreateXcie { get; set; }

    internal ProdEncryptionOption()
    {
      this.InputNspFile = (string) null;
      this.InputUppNspFile = (string) null;
      this.InputPatchNspFile = (string) null;
      this.OutputDirectory = ".";
      this.CreateXci = false;
      this.CreateXcie = false;
      this.NoCreateXcie = false;
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("prodencryption: Create prod-encrypted .nsp, .xci or .xcie file.");
      Console.WriteLine("Usage: {0} prodencryption [-o outputDirecotry] <inputNspPath>", (object) baseName);
      Console.WriteLine("Usage: {0} prodencryption [-o outputDirecotry] --gamecard [--no-xcie] [--auto-boot] [--history-erase] [--upp <uppNspPath>] [--patch <patchNspPath>] <inputNspPath>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputDirectory>                 Directory path to output. If directory path is specified, output to current directory");
      Console.WriteLine("  --gamecard                           Create prod-encrypted xci and xcie file.");
      Console.WriteLine("  --no-xcie                            Omit to create xcie file. Must be used with --gamecard option.");
      Console.WriteLine("  --auto-boot                          Set auto boot flag for game card. Must be used with --gamecard option.");
      Console.WriteLine("  --history-erase                      Set history-erase flag for game card. Must be used with --gamecard option.");
      Console.WriteLine("  --upp                                Specifies nsp path for update partition. Must be used with --gamecard option.");
      Console.WriteLine("  --patch                              Specifies nsp path for in-card-patch. Must be used with --gamecard option.");
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[7]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputDirectory = OptionUtil.GetOutputFilePath(this.OutputDirectory, s.First<string>()))),
        new OptionDescription("--gamecard", (string) null, 0, (Action<List<string>>) (s =>
        {
          this.CreateXci = true;
          this.CreateXcie = true;
        })),
        new OptionDescription("--no-xcie", (string) null, 0, (Action<List<string>>) (s => this.NoCreateXcie = true)),
        new OptionDescription("--auto-boot", (string) null, 0, (Action<List<string>>) (s => this.LaunchFlags |= (byte) 1)),
        new OptionDescription("--history-erase", (string) null, 0, (Action<List<string>>) (s => this.LaunchFlags |= (byte) 2)),
        OptionUtil.CreateFilePathOptionDescription("--upp", (OptionUtil.PathSetter) (path => this.InputUppNspFile = path)),
        OptionUtil.CreateFilePathOptionDescription("--patch", (OptionUtil.PathSetter) (path => this.InputPatchNspFile = path))
      };
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (args.Length == 0)
        throw new InvalidOptionException("input nsp file must be specified for prodencryption subcommand.");
      this.InputNspFile = OptionUtil.CheckAndNormalizeFilePath(args[0], "arg[0]");
      if (args.Length >= 2)
        throw new InvalidOptionException("too many arguments for prodencryption subcommand.");
      if (!this.CreateXci && (this.NoCreateXcie || this.LaunchFlags != (byte) 0 || (this.InputUppNspFile != null || this.InputPatchNspFile != null)))
        throw new InvalidOptionException("--no-xcie, --auto-boot, --history-erase, --upp and --patch option requires to be used with --xci option.");
      if (!this.NoCreateXcie)
        return;
      this.CreateXcie = false;
    }
  }
}
