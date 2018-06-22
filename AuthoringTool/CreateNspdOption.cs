// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.CreateNspdOption
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class CreateNspdOption : IOption
  {
    internal List<Tuple<string, string>> IconFileList = new List<Tuple<string, string>>();
    internal List<Tuple<string, string>> NxIconFileList = new List<Tuple<string, string>>();
    internal const string DefaultCodeDirectory = "program0.ncd/code/";
    internal const string DefaultDataDirectory = "program0.ncd/data/";
    internal const string DefaultLogoDirectory = "program0.ncd/logo/";
    internal const string DefaultControlDirectory = "control0.ncd/";
    internal const string DefaultHtmlDocumentDirectory = "htmlDocument0.ncd/htmlDocument";
    internal const string DefaultAccessibleUrlsDirectory = "htmlDocument0.ncd/accessibleUrls";
    internal const string DefaultLegalInformationDirectory = "legalInformation0.ncd/";
    private const uint DefaultNxIconMaxSize = 102400;

    internal string MetaFilePath { get; set; }

    internal string MetaType { get; set; }

    internal string ContentMetaType { get; set; }

    internal string OutputDirectory { get; set; }

    internal string CodeDirectory { get; set; }

    internal string DataDirectory { get; set; }

    internal string LogoDirectory { get; set; }

    internal string ControlDirectory { get; set; }

    internal string HtmlDocumentDirectory { get; set; }

    internal string AccessibleUrlsDirectory { get; set; }

    internal string LegalInformationDirectory { get; set; }

    internal uint NxIconMaxSize { get; set; }

    internal CreateNspdOption()
    {
      this.NxIconMaxSize = 102400U;
      this.OutputDirectory = "./output.nspd";
    }

    public void ShowSubCommandUsage(string baseName)
    {
      Console.WriteLine("createnspd: Create new Nintendo Submission Package Directory.");
      Console.WriteLine("Usage: {0} createnspd [-o <outputDirectory>] --meta <metaFilePath> --type <contentMetaType>", (object) baseName);
      Console.WriteLine(string.Empty);
      Console.WriteLine("Options:");
      Console.WriteLine("  -o <outputDirectory>                               Directory path to output. The end of directory name should be \".nspd\"");
      Console.WriteLine("                                                     If omitted, output to ./output.nspd");
      Console.WriteLine("  --meta <metaFilePath>                              Location of .meta file to input.");
      Console.WriteLine("  --type <contentMetaType>                           Content Meta Type to create package.");
      Console.WriteLine("  --program <codePath> [<dataPath>] [<logoPath>]");
      Console.WriteLine("                                                     Location of directory path which includes files to be contained");
      Console.WriteLine("                                                     to in a executable content as code, data and/or logo region.");
      Console.WriteLine("                                                     If omitted, generate directories automatically.");
      Console.WriteLine("  --code <codePath>                                  Location of directory path which includes files to be contained to in a executable content as code.");
      Console.WriteLine("                                                     If omitted, generate directories automatically.");
      Console.WriteLine("  --data <dataPath>                                  Location of directory path which includes files to be contained to in a data content.");
      Console.WriteLine("                                                     If omitted, generate directories automatically.");
      Console.WriteLine("  --logo <logoPath>                                  Location of directory path which includes files to be contained to in a logo data content.");
      Console.WriteLine("                                                     If omitted, generate directories automatically.");
      Console.WriteLine("  --control <controlPath>                            Location of directory path which includes files to be contained");
      Console.WriteLine("                                                     to in a control data content.");
      Console.WriteLine("                                                     If omitted, generate directory automatically.");
      Console.WriteLine("  --html-document <htmlDocumentPath>                 Location of directory which includes gameplay instruction documents.");
      Console.WriteLine("                                                     If omitted, generate directory automatically.");
      Console.WriteLine("  --accessible-urls <accessibleUrlsPath>             Location of directory which includes files to accept documents to access websites.");
      Console.WriteLine("                                                     If omitted, generate directory automatically.");
      Console.WriteLine("  --legal-information-dir <legalInformationPath>     Location of directory which includes software legal information documents.");
      Console.WriteLine("                                                     If omitted, generate directory automatically.");
    }

    public OptionDescription[] GetOptionDescription()
    {
      return new OptionDescription[14]
      {
        new OptionDescription((string) null, "-o", 1, (Action<List<string>>) (s => this.OutputDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>()).TrimEnd('/'))),
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
        new OptionDescription("--program", (string) null, 3, (Action<List<string>>) (s =>
        {
          if (this.CodeDirectory != null)
            throw new InvalidOptionException("--program option cannot be used with --code, --data and --logo options.");
          this.CodeDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>());
          if (s.Count > 1)
          {
            if (this.DataDirectory != null)
              throw new InvalidOptionException("--program option cannot be used with --code, --data and --logo options.");
            this.DataDirectory = OptionUtil.GetOutputFilePath(".", s[1]);
          }
          if (s.Count <= 2)
            return;
          if (this.LogoDirectory != null)
            throw new InvalidOptionException("--program option cannot be used with --code, --data and --logo options.");
          this.LogoDirectory = OptionUtil.GetOutputFilePath(".", s[2]);
        })),
        new OptionDescription("--code", (string) null, 1, (Action<List<string>>) (s =>
        {
          if (this.CodeDirectory != null)
            throw new InvalidOptionException("--program option cannot be used with --code, --data and --logo options.");
          this.CodeDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>());
        })),
        new OptionDescription("--data", (string) null, 1, (Action<List<string>>) (s =>
        {
          if (this.DataDirectory != null)
            throw new InvalidOptionException("--program option cannot be used with --code, --data and --logo options.");
          this.DataDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>());
        })),
        new OptionDescription("--logo", (string) null, 1, (Action<List<string>>) (s =>
        {
          if (this.LogoDirectory != null)
            throw new InvalidOptionException("--program option cannot be used with --code, --data and --logo options.");
          this.LogoDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>());
        })),
        new OptionDescription("--control", (string) null, 1, (Action<List<string>>) (s => this.ControlDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>()))),
        new OptionDescription("--html-document", (string) null, 1, (Action<List<string>>) (s => this.HtmlDocumentDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>()))),
        new OptionDescription("--accessible-urls", (string) null, 1, (Action<List<string>>) (s => this.AccessibleUrlsDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>()))),
        new OptionDescription("--legal-information-dir", (string) null, 1, (Action<List<string>>) (s => this.LegalInformationDirectory = OptionUtil.GetOutputFilePath(".", s.First<string>()))),
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
      if (this.OutputDirectory.Substring(this.OutputDirectory.Length - 5) != ".nspd")
        throw new InvalidOptionException("-o option should be used with file name which ends with \".nspd\"");
      if (this.MetaType == null || this.MetaType.Length == 0 || (this.MetaFilePath == null || this.MetaFilePath.Length == 0))
        throw new InvalidOptionException("createnspd command needs --meta and --type options.");
      if (this.MetaType != "Application" && this.MetaType != "SystemProgram")
        throw new InvalidOptionException("createnspd command should be used with --type Application or --type SystemProgram");
      if (this.IconFileList.Count > 0 && this.MetaType != "Application")
        throw new InvalidOptionException("--icon option should be used with --type Application.");
      if (this.NxIconFileList.Count > 0 && this.MetaType != "Application")
        throw new InvalidOptionException("--nx-icon option should be used with --type Application.");
    }
  }
}
