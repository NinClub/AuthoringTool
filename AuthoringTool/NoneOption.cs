// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.NoneOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using Nintendo.Authoring.AuthoringLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class NoneOption : IOption
  {
    internal AuthoringConfiguration Config = new AuthoringConfiguration();

    internal bool IsVerbose { get; private set; }

    internal bool IsShowUsage { get; set; }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("{0}: Authoring Tool for Nintendo SDK", (object) baseName);
      Console.WriteLine("Usage: {0} <subcommand> [options] [args]", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Available subcommands:");
      Console.WriteLine("  createfs       Create new file system archive.");
      Console.WriteLine("  createnca      Create new Nintendo Content Archive.");
      Console.WriteLine("  creatensp      Create new Nintendo Submission Package.");
      Console.WriteLine("  createnspmeta  Create only meta files for Nintendo Submission Package.");
      Console.WriteLine("  createnspd     Create new Nintendo Submission Package Directory.");
      Console.WriteLine("  extract        Extract files from a Nintendo Submission Package or Nintendo Content Archive.");
      Console.WriteLine("  replace        Replace a file in a Nintendo Submission Package or Nintendo Content Archive.");
      Console.WriteLine("  list           List information about the files included in an archive file.");
      Console.WriteLine("  help           Describe the usage of this program or its subcommands.");
      Console.WriteLine("Options:");
      Console.WriteLine("  -v, --verbose                Show detail log.");
      Console.WriteLine("  --keyconfig <path>           Path of key configuration file.");
      Console.WriteLine("  --includes-cnmt              Includes content meta binary to nsp file for debug use.");
      Console.WriteLine(string.Empty);
      Console.WriteLine("Type '{0} help <subcommand>' for help on a specific subcommand.", (object) baseName);
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[4]
      {
        new OptionDescription("--help", "-h", 0, (Action<List<string>>) (s => this.IsShowUsage = true)),
        new OptionDescription("--verbose", "-v", 0, (Action<List<string>>) (s => this.IsVerbose = true)),
        new OptionDescription("--keyconfig", (string) null, 1, (Action<List<string>>) (s => this.Config.KeyConfigFilePath = OptionUtil.GetOutputFilePath(string.Empty, s.First<string>()))),
        new OptionDescription("--includes-cnmt", (string) null, 0, (Action<List<string>>) (s => this.Config.DebugConfig.EnableContentMetaBinaryExport = true))
      };
    }

    public void ParsePositionalArgument(string[] args)
    {
    }
  }
}
