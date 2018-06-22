// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.Option
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using Nintendo.Authoring.AuthoringLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class Option
  {
    internal static Option.SubCommandType GetSubCommandType(string str)
    {
      switch (str)
      {
        case "createfs":
          return Option.SubCommandType.CreateFs;
        case "createnca":
          return Option.SubCommandType.CreateNca;
        case "creatensp":
          return Option.SubCommandType.CreateNsp;
        case "createnspd":
          return Option.SubCommandType.CreateNspd;
        case "createnspmeta":
          return Option.SubCommandType.CreateNspMeta;
        case "extract":
          return Option.SubCommandType.Extract;
        case "extractnsp":
          return Option.SubCommandType.ExtractNsp;
        case "help":
          return Option.SubCommandType.Help;
        case "list":
          return Option.SubCommandType.List;
        case "mergensp":
          return Option.SubCommandType.MergeNsp;
        case "prodencryption":
          return Option.SubCommandType.ProdEncryption;
        case "replace":
          return Option.SubCommandType.Replace;
        default:
          return Option.SubCommandType.None;
      }
    }

    internal bool IsVerbose
    {
      get
      {
        return this.None.IsVerbose;
      }
    }

    internal bool IsShowUsage
    {
      get
      {
        return this.None.IsShowUsage;
      }
    }

    internal NoneOption None { get; private set; }

    internal CreateFsOption CreateFs { get; private set; }

    internal CreateNcaOption CreateNca { get; private set; }

    internal CreateNspOption CreateNsp { get; private set; }

    internal CreateNspMetaOption CreateNspMeta { get; private set; }

    internal CreateNspdOption CreateNspd { get; private set; }

    internal ExtractOption Extract { get; private set; }

    internal ExtractNspOption ExtractNsp { get; private set; }

    internal MergeNspOption MergeNsp { get; private set; }

    internal ReplaceOption Replace { get; private set; }

    internal ListOption List { get; private set; }

    internal ProdEncryptionOption ProdEncryption { get; private set; }

    internal HelpOption Help { get; private set; }

    internal AuthoringConfiguration Config
    {
      get
      {
        return this.None.Config;
      }
    }

    private Option.SubCommandType CurrentSubCommandType { get; set; }

    internal Option()
    {
      this.None = new NoneOption();
    }

    internal void Parse(string[] args)
    {
      string[] optionalArgument1 = this.ParseOptionalArgument((IOption) this.None, args);
      Option.SubCommandType type = Option.SubCommandType.None;
      if (optionalArgument1.Length != 0)
        type = Option.GetSubCommandType(optionalArgument1[0]);
      if (type == Option.SubCommandType.None)
        this.None.IsShowUsage = true;
      if (this.IsShowUsage)
      {
        this.GetSubCommand(Option.SubCommandType.Help).ParsePositionalArgument(optionalArgument1);
      }
      else
      {
        if (type == Option.SubCommandType.Help)
          this.None.IsShowUsage = true;
        IOption subCommand = this.GetSubCommand(type);
        string[] array = ((IEnumerable<string>) optionalArgument1).Skip<string>(1).Take<string>(optionalArgument1.Length - 1).ToArray<string>();
        string[] optionalArgument2 = this.ParseOptionalArgument(subCommand, array);
        subCommand.ParsePositionalArgument(optionalArgument2);
      }
    }

    internal void ShowUsage()
    {
      string fileName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
      if (this.CurrentSubCommandType != Option.SubCommandType.Help)
        this.GetSubCommand(this.CurrentSubCommandType).ShowSubCommandUsage(fileName);
      else if (this.Help.SubCommandList.Count == 0)
      {
        this.None.ShowSubCommandUsage(fileName);
      }
      else
      {
        foreach (Option.SubCommandType subCommand in this.Help.SubCommandList)
          this.GetSubCommand(subCommand).ShowSubCommandUsage(fileName);
      }
    }

    private IOption GetSubCommand(Option.SubCommandType type)
    {
      switch (type)
      {
        case Option.SubCommandType.None:
          throw new InvalidOptionException((Exception) new NotImplementedException());
        case Option.SubCommandType.CreateFs:
          this.CreateFs = new CreateFsOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.CreateFs;
        case Option.SubCommandType.CreateNca:
          this.CreateNca = new CreateNcaOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.CreateNca;
        case Option.SubCommandType.CreateNsp:
          this.CreateNsp = new CreateNspOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.CreateNsp;
        case Option.SubCommandType.CreateNspMeta:
          this.CreateNspMeta = new CreateNspMetaOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.CreateNspMeta;
        case Option.SubCommandType.CreateNspd:
          this.CreateNspd = new CreateNspdOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.CreateNspd;
        case Option.SubCommandType.ExtractNsp:
          this.ExtractNsp = new ExtractNspOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.ExtractNsp;
        case Option.SubCommandType.MergeNsp:
          this.MergeNsp = new MergeNspOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.MergeNsp;
        case Option.SubCommandType.Extract:
          this.Extract = new ExtractOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.Extract;
        case Option.SubCommandType.Replace:
          this.Replace = new ReplaceOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.Replace;
        case Option.SubCommandType.List:
          this.List = new ListOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.List;
        case Option.SubCommandType.ProdEncryption:
          this.ProdEncryption = new ProdEncryptionOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.ProdEncryption;
        case Option.SubCommandType.Help:
          this.Help = new HelpOption();
          this.CurrentSubCommandType = type;
          return (IOption) this.Help;
        default:
          throw new InvalidOptionException((Exception) new NotImplementedException());
      }
    }

    private string[] ParseOptionalArgument(IOption option, string[] args)
    {
      if (args.Length == 0)
      {
        this.None.IsShowUsage = true;
        return args;
      }
      OptionDescription[] optionDescription1 = option.GetOptionDescription();
      if (optionDescription1 == null)
        return args;
      System.Collections.Generic.List<string> stringList1 = new System.Collections.Generic.List<string>();
      for (int index1 = 0; index1 < args.Length; ++index1)
      {
        for (int index2 = 0; index2 < optionDescription1.Length; ++index2)
        {
          string str = args[index1];
          OptionDescription optionDescription2 = optionDescription1[index2];
          if (optionDescription2.LongName == str || optionDescription2.ShortName == str)
          {
            if (optionDescription2.HasArgument != 0)
            {
              System.Collections.Generic.List<string> stringList2 = new System.Collections.Generic.List<string>();
              for (int index3 = 0; index3 < optionDescription2.HasArgument; ++index3)
              {
                if (index1 < args.Length - 1 && !args[index1 + 1].StartsWith("-"))
                  stringList2.Add(args[++index1]);
              }
              if (stringList2.Count == 0)
                throw new InvalidOptionException(string.Format("no option argument for \"{0}\".", (object) str));
              optionDescription2.Action(stringList2);
              break;
            }
            optionDescription2.Action((System.Collections.Generic.List<string>) null);
            break;
          }
          if (index2 == optionDescription1.Length - 1)
            stringList1.Add(str);
        }
      }
      return stringList1.ToArray();
    }

    internal enum SubCommandType
    {
      None,
      CreateFs,
      CreateNca,
      CreateNsp,
      CreateNspMeta,
      CreateNspd,
      ExtractNsp,
      MergeNsp,
      Extract,
      Replace,
      List,
      ProdEncryption,
      Help,
    }
  }
}
