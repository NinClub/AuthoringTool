// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.CreateNcaOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using Nintendo.Authoring.AuthoringLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class CreateNcaOption : CreateCommandOptionBase, IOption
  {
    private List<string> TmpDirs;

    internal List<Pair<string, string>> InputDirs { get; set; }

    internal string MetaFilePath { get; set; }

    internal string DescFilePath { get; set; }

    internal int KeyAreaEncryptionKeyIndex { get; set; }

    internal byte EncryptionType { get; set; }

    internal string ContentType { get; set; }

    internal byte KeyGeneration { get; set; }

    internal ulong ProgramId { get; set; }

    internal uint ContentIndex { get; set; }

    internal CreateNcaOption()
    {
      this.InputDirs = new List<Pair<string, string>>();
      this.ContentType = (string) null;
      this.OutputFile = "./output.nca";
      this.MetaFilePath = (string) null;
      this.DescFilePath = (string) null;
      this.KeyAreaEncryptionKeyIndex = 0;
      this.TmpDirs = new List<string>();
    }

    ~CreateNcaOption()
    {
      foreach (string tmpDir in this.TmpDirs)
        Directory.Delete(tmpDir, true);
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("createnca: Create new nintendo content archive from .adf or specified directory and .meta and .desc file.");
      Console.WriteLine("Usage: {0} createnca [-o <outputPath>] <inputAdfPath>", (object) baseName);
      Console.WriteLine("Usage: {0} createnca [-o <outputPath>] [--save-adf] [--only-adf] [--filter <fdfPath>] --meta <metaFilePath> --desc <descFilePath> --program <codePath> [<dataPath>] [<logoPath>]", (object) baseName);
      Console.WriteLine("Usage: {0} createnca [-o <outputPath>] [--save-adf] [--only-adf] [--filter <fdfPath>] --meta <metaFilePath> --control <controlPath>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputPath>                      File path to output. If directory path is specified, output to <outputPath>/output.nca.");
      Console.WriteLine("                                       If omitted, output to ./output.nca");
      Console.WriteLine("  --save-adf                           Leave .adf which is generated intermediately.");
      Console.WriteLine("  --only-adf                           Create .adf only.");
      Console.WriteLine("  --filter <fdfPath>                   Filter files to be included into .adf. <fdfPath> expects a path for a filter description file (.fdf).");
      Console.WriteLine("  --meta <metaFilePath>                Location of .meta file to input.");
      Console.WriteLine("  --desc <descFilePath>                Location of .desc file to input. This cannot be omitted when create program content.");
      Console.WriteLine("  --program <codePath> [<dataPath>] [<logoPath>]");
      Console.WriteLine("                                       Location of directory path which includes files to be contained");
      Console.WriteLine("                                       to in a program content as code, data and/or logo region.");
      Console.WriteLine("                                       dataPath and/or logoPath can be omitted.");
      Console.WriteLine("  --control <controlPath>              Location of directory path which includes files to be contained");
      Console.WriteLine("                                       to in a control data content.");
      Console.WriteLine("  --keyindex <index>                   Key index for encryption of content key.");
    }

    internal string ExtractZipFile(string fileName)
    {
      if (Path.GetExtension(fileName).ToLower() != ".zip")
        throw new InvalidOptionException();
      string destinationDirectoryName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()).Replace("\\", "/").TrimEnd('/');
      ZipFile.ExtractToDirectory(fileName, destinationDirectoryName);
      this.TmpDirs.Add(destinationDirectoryName);
      return destinationDirectoryName;
    }

    internal OptionDescription CreateContentOptionDescription(string longName, string type, int countArgs = 1)
    {
      return new OptionDescription(longName, (string) null, countArgs, (Action<List<string>>) (s =>
      {
        if (this.ContentType != null)
          throw new InvalidOptionException();
        this.ContentType = type;
        for (int index = 0; index < s.Count; ++index)
        {
          string str = s[index].Replace("\\", "/").TrimEnd('/');
          if (longName == "--legal-information")
            str = this.ExtractZipFile(str);
          this.InputDirs.Add(new Pair<string, string>(str, (string) null));
        }
      }));
    }

    internal OptionDescription CreateContentOptionDescriptionForHtmlDocument(string longName, string outputDir)
    {
      return new OptionDescription(longName, (string) null, 1, (Action<List<string>>) (s =>
      {
        if (this.ContentType == null)
          this.ContentType = "HtmlDocument";
        for (int index = 0; index < s.Count; ++index)
          this.InputDirs.Add(new Pair<string, string>(s[index].Replace("\\", "/").TrimEnd('/'), outputDir));
      }));
    }

    public new OptionDescription[] GetOptionDescription()
    {
      return ((IEnumerable<OptionDescription>) new OptionDescription[10]
      {
        OptionUtil.CreateFilePathOptionDescription("--meta", (OptionUtil.PathSetter) (path => this.MetaFilePath = path)),
        OptionUtil.CreateFilePathOptionDescription("--desc", (OptionUtil.PathSetter) (path => this.DescFilePath = path)),
        this.CreateContentOptionDescription("--program", "Program", 3),
        this.CreateContentOptionDescription("--control", "Control", 1),
        this.CreateContentOptionDescriptionForHtmlDocument("--html-document", "html-document"),
        this.CreateContentOptionDescriptionForHtmlDocument("--accessible-urls", "accessible-urls"),
        this.CreateContentOptionDescription("--legal-information", "LegalInformation", 1),
        this.CreateContentOptionDescription("--legal-information-dir", "LegalInformation", 1),
        this.CreateContentOptionDescription("--data", "Data", 1),
        new OptionDescription("--keyindex", (string) null, 1, (Action<List<string>>) (s => this.KeyAreaEncryptionKeyIndex = int.Parse(s.First<string>())))
      }).Concat<OptionDescription>((IEnumerable<OptionDescription>) base.GetOptionDescription()).ToArray<OptionDescription>();
    }

    public void ParsePositionalArgument(string[] args)
    {
      if (this.ContentType != null)
        return;
      if (args.Length < 1)
        throw new InvalidOptionException("too few arguments for createnca subcommand.");
      if (args.Length > 1)
        throw new InvalidOptionException("too many arguments for createnca subcommand.");
      this.InputAdfFile = args[0].Replace("\\", "/");
      this.IsSaveAdf = true;
    }
  }
}
