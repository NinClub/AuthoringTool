// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.CreateFsOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using Nintendo.Authoring.AuthoringLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class CreateFsOption : CreateCommandOptionBase, IOption
  {
    internal string InputDir { get; set; }

    internal ArchiveFormatType Format { get; set; }

    internal CreateFsOption()
    {
      this.InputDir = (string) null;
      this.InputAdfFile = (string) null;
      this.Format = ArchiveFormatType.Invalid;
      this.OutputFile = "./output.fs";
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("createfs: Create new file system archive from .adf or specified directory");
      Console.WriteLine("Usage: {0} createfs [-o <outputPath>] <inputAdfPath>", (object) baseName);
      Console.WriteLine("Usage: {0} createfs [-o <outputPath>] [--save-adf] [--only-adf] [--filter <fdfPath>] --format <format> <inputDirPath>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputPath>              File path to output. If directory path is specified, output to <outputPath>/output.fs.");
      Console.WriteLine("                               If omitted, output to ./output.fs");
      Console.WriteLine("  --save-adf                   Leave .adf which is generated intermediately.");
      Console.WriteLine("  --only-adf                   Create .adf only.");
      Console.WriteLine("  --filter <fdfPath>           Filter files to be included into .adf. <fdfPath> expects a path for a filter description file (.fdf).");
      Console.WriteLine("  --format <format>            Format Type to create archive.");
      Console.WriteLine("                               Available as <format>: partitionfs, romfs");
    }

    public new OptionDescription[] GetOptionDescription()
    {
      return ((IEnumerable<OptionDescription>) new OptionDescription[1]
      {
        new OptionDescription("--format", (string) null, 1, (Action<List<string>>) (s =>
        {
          if (s.First<string>() == "partitionfs")
          {
            this.Format = ArchiveFormatType.PartitionFs;
          }
          else
          {
            if (!(s.First<string>() == "romfs"))
              throw new InvalidOptionException(string.Format("invalid option --format.", Array.Empty<object>()));
            this.Format = ArchiveFormatType.RomFs;
          }
        }))
      }).Concat<OptionDescription>((IEnumerable<OptionDescription>) base.GetOptionDescription()).ToArray<OptionDescription>();
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (args.Length < 1)
        throw new InvalidOptionException("too few arguments for createfs subcommand.");
      if (args.Length > 1)
        throw new InvalidOptionException("too many arguments for createfs subcommand.");
      if (this.Format == ArchiveFormatType.Invalid)
      {
        this.InputAdfFile = args[0].Replace("\\", "/");
        this.IsSaveAdf = true;
      }
      else
        this.InputDir = args[0].Replace("\\", "/").TrimEnd('/');
    }
  }
}
