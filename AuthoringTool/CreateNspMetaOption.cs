// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.CreateNspMetaOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class CreateNspMetaOption : IOption
  {
    internal List<Tuple<string, string>> IconFileList = new List<Tuple<string, string>>();
    internal List<Tuple<string, string>> NxIconFileList = new List<Tuple<string, string>>();
    private const uint DefaultNxIconMaxSize = 102400;

    internal string MetaFilePath { get; set; }

    internal string MetaType { get; set; }

    internal string OutputDirectory { get; set; }

    internal string ContentMetaType { get; set; }

    internal uint NxIconMaxSize { get; set; }

    internal CreateNspMetaOption()
    {
      this.OutputDirectory = "./output.nspd";
      this.NxIconMaxSize = 102400U;
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("createnspmeta: Create only meta files for Nintendo Submission Package.");
      Console.WriteLine("Usage: {0} createnspmeta [-o <outputDirectory>] --meta <metaFilePath> --type <contentMetaType>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputDirectory>                 Directory path to output. If directory path is specified, output to ./output.nspd");
      Console.WriteLine("  --meta <metaFilePath>                Location of .meta file to input.");
      Console.WriteLine("  --type <contentMetaType>             Content Meta Type to create package.");
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[6]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>()))),
        new OptionDescription("--type", (string) null, 1, (Action<List<string>>) (s =>
        {
          try
          {
            Enum.Parse(typeof (Nintendo.Authoring.AuthoringTool.ContentMetaType), s.First<string>());
          }
          catch (Exception ex)
          {
            throw new InvalidOptionException(string.Format("invalid option --type {0}.", (object) s.First<string>()));
          }
          this.MetaType = s.First<string>();
        })),
        OptionUtil.CreateFilePathOptionDescription("--meta", (OptionUtil.PathSetter) (path => this.MetaFilePath = path)),
        new OptionDescription("--icon", (string) null, 32, (Action<List<string>>) (s =>
        {
          if (s.Count % 2 != 0)
            throw new InvalidOptionException("--icon <language> <iconPath>...");
          this.IconFileList = OptionUtil.CreateIconFileList(s);
        })),
        new OptionDescription("--nx-icon", (string) null, 32, (Action<List<string>>) (s =>
        {
          if (s.Count % 2 != 0)
            throw new InvalidOptionException("--nx-icon <language> <iconPath>...");
          this.NxIconFileList = OptionUtil.CreateIconFileList(s);
        })),
        new OptionDescription("--nx-icon-max-size", (string) null, 32, (Action<List<string>>) (s => this.NxIconMaxSize = Convert.ToUInt32(s.First<string>())))
      };
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (this.IconFileList.Count > 0 && this.MetaType != "Application" && this.MetaType != "Patch")
        throw new InvalidOptionException("--icon option should be used with --type Application.");
    }
  }
}
