// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.DotMetaReader
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class DotMetaReader
  {
    private string[] ProgramIdAliases = new string[3]
    {
      nameof (ApplicationId),
      nameof (ProgramId),
      nameof (SystemProgramId)
    };
    private string[] ProgramDirectives = new string[2]
    {
      "Application",
      "SystemProgram"
    };
    private string[] DataTypeDirectives = new string[2]
    {
      "SystemData",
      "AddOnContent"
    };
    private string[] ContentTypeDirectives = new string[6]
    {
      "Application",
      "AddOnContent",
      "SystemData",
      "SystemProgram",
      "SystemUpdate",
      "Patch"
    };
    private const string ApplicationDirective = "Application";
    private const string AddOnContentDirective = "AddOnContent";
    private const string SystemProgramDirective = "SystemProgram";
    private const string SystemDataDirective = "SystemData";
    private const string SystemUpdateDirective = "SystemUpdate";
    private const string PatchDirective = "Patch";
    private const string CoreDirective = "Core";
    private const string ApplicationId = "ApplicationId";
    private const string PatchId = "PatchId";
    private const string ProgramId = "ProgramId";
    private const string SystemProgramId = "SystemProgramId";
    private const string IdNotFoundMessage = "メタファイルに ID が記述されていません";
    private XDocument m_Document;

    private bool IsPatch()
    {
      return this.m_Document.Descendants((XName) "Patch").Any<XElement>();
    }

    private bool IsAddOnContent()
    {
      return this.m_Document.Descendants((XName) "AddOnContent").Any<XElement>();
    }

    public DotMetaReader(string xmlPath)
    {
      this.m_Document = XDocument.Load(xmlPath);
    }

    private ulong GetAnyId()
    {
      foreach (string contentTypeDirective in this.ContentTypeDirectives)
      {
        if (this.m_Document.Descendants((XName) contentTypeDirective).Any<XElement>())
        {
          IEnumerable<string> source = this.m_Document.Descendants((XName) contentTypeDirective).Descendants<XElement>((XName) "Id").Select<XElement, string>((Func<XElement, string>) (meta => (string) meta));
          if (source.Any<string>())
            return Convert.ToUInt64(source.First<string>(), 16);
        }
      }
      return this.GetCoreId();
    }

    public ulong GetCoreId()
    {
      foreach (string programDirective in this.ProgramDirectives)
      {
        if (this.m_Document.Descendants((XName) programDirective).Any<XElement>())
        {
          IEnumerable<string> source = this.m_Document.Descendants((XName) programDirective).Descendants<XElement>((XName) "Id").Select<XElement, string>((Func<XElement, string>) (meta => (string) meta));
          if (source.Any<string>())
            return Convert.ToUInt64(source.First<string>(), 16);
        }
      }
      if (this.m_Document.Descendants((XName) "Core").Any<XElement>())
      {
        foreach (string programIdAliase in this.ProgramIdAliases)
        {
          IEnumerable<string> source = this.m_Document.Descendants((XName) "Core").Descendants<XElement>((XName) programIdAliase).Select<XElement, string>((Func<XElement, string>) (meta => (string) meta));
          if (source.Any<string>())
            return Convert.ToUInt64(source.First<string>(), 16);
        }
      }
      throw new ArgumentException("メタファイルに ID が記述されていません");
    }

    public ulong GetApplicationId()
    {
      if (this.IsAddOnContent())
      {
        IEnumerable<string> source = this.m_Document.Descendants((XName) "AddOnContent").Descendants<XElement>((XName) "ApplicationId").Select<XElement, string>((Func<XElement, string>) (pid => (string) pid));
        if (source.Any<string>())
          return Convert.ToUInt64(source.First<string>(), 16);
      }
      else
      {
        IEnumerable<string> source = this.m_Document.Descendants((XName) "Application").Descendants<XElement>((XName) "Id").Concat<XElement>(this.m_Document.Descendants((XName) "Core").Descendants<XElement>((XName) "ApplicationId").Concat<XElement>(this.m_Document.Descendants((XName) "Core").Descendants<XElement>((XName) "ProgramId"))).Select<XElement, string>((Func<XElement, string>) (pid => (string) pid));
        if (source.Any<string>())
          return Convert.ToUInt64(source.First<string>(), 16);
      }
      throw new ArgumentException("メタファイルに ID が記述されていません");
    }

    public ulong GetDataId()
    {
      return Convert.ToUInt64(this.m_Document.Descendants((XName) "DataId").Concat<XElement>(this.m_Document.Descendants((XName) "SystemDataId")).Select<XElement, string>((Func<XElement, string>) (pid => (string) pid)).First<string>(), 16);
    }

    public ulong GetNcaId()
    {
      if (this.IsPatch())
        return this.GetCoreId();
      return this.GetContentMetaId();
    }

    public ulong GetContentMetaId()
    {
      IEnumerable<string> source1 = this.m_Document.Descendants((XName) "Patch").Descendants<XElement>((XName) "Id").Select<XElement, string>((Func<XElement, string>) (pid => (string) pid));
      if (source1.Any<string>())
        return Convert.ToUInt64(source1.First<string>(), 16);
      IEnumerable<string> source2 = this.m_Document.Descendants((XName) "Core").Descendants<XElement>((XName) "PatchId").Select<XElement, string>((Func<XElement, string>) (pid => (string) pid));
      if (source2.Any<string>())
        return Convert.ToUInt64(source2.First<string>(), 16);
      if (this.IsPatch())
        return IdConverter.ConvertToPatchId(this.GetApplicationId());
      if (this.m_Document.Descendants((XName) "AddOnContent").Any<XElement>())
      {
        IEnumerable<string> source3 = this.m_Document.Descendants((XName) "AddOnContent").Descendants<XElement>((XName) "Id").Select<XElement, string>((Func<XElement, string>) (addOnContentId => (string) addOnContentId));
        IEnumerable<string> source4 = this.m_Document.Descendants((XName) "AddOnContent").Descendants<XElement>((XName) "Index").Select<XElement, string>((Func<XElement, string>) (index => (string) index));
        IEnumerable<string> source5 = this.m_Document.Descendants((XName) "AddOnContent").Descendants<XElement>((XName) "ApplicationId").Select<XElement, string>((Func<XElement, string>) (appId => (string) appId));
        if (source3.Any<string>())
          return Convert.ToUInt64(source3.First<string>(), 16);
        return IdConverter.ConvertToAocBaseId(Convert.ToUInt64(source5.First<string>(), 16)) + Convert.ToUInt64(source4.First<string>());
      }
      if (this.m_Document.Descendants((XName) "SystemUpdate").Any<XElement>())
        return Convert.ToUInt64(this.m_Document.Descendants((XName) "SystemUpdate").Descendants<XElement>((XName) "ContentMeta").Descendants<XElement>((XName) "Id").Select<XElement, string>((Func<XElement, string>) (id => (string) id)).First<string>(), 16);
      return this.GetAnyId();
    }

    public uint GetVersion()
    {
      foreach (string contentTypeDirective in this.ContentTypeDirectives)
      {
        if (this.m_Document.Descendants((XName) contentTypeDirective).Any<XElement>())
        {
          IEnumerable<string> source = this.m_Document.Descendants((XName) contentTypeDirective).Select<XElement, string>((Func<XElement, string>) (meta => (string) meta.Element((XName) "Version")));
          if (!source.Any<string>())
            return 0;
          return Convert.ToUInt32(source.First<string>(), 10);
        }
      }
      return 0;
    }

    public byte GetContentMetaAttributes()
    {
      foreach (string contentTypeDirective in this.ContentTypeDirectives)
      {
        if (this.m_Document.Descendants((XName) contentTypeDirective).Any<XElement>())
          return (byte) ContentMetaAttributeExtension.FromStringList(this.m_Document.Descendants((XName) contentTypeDirective).Elements<XElement>((XName) "ContentMetaAttribute").Select<XElement, string>((Func<XElement, string>) (attribute => attribute.Value)));
      }
      return 0;
    }

    public uint GetRequiredApplicationVersion()
    {
      IEnumerable<string> source = this.m_Document.Descendants((XName) "AddOnContent").Descendants<XElement>((XName) "RequiredApplicationVersion").Select<XElement, string>((Func<XElement, string>) (requiredApplicationVersion => (string) requiredApplicationVersion));
      if (!source.Any<string>())
        return 0;
      return Convert.ToUInt32(source.First<string>(), 10);
    }

    public uint? GetRequiredSystemVersion()
    {
      IEnumerable<string> source = this.m_Document.Descendants((XName) "Application").Select<XElement, string>((Func<XElement, string>) (meta => (string) meta.Element((XName) "RequiredSystemVersion")));
      if (!source.Any<string>())
        return new uint?();
      return new uint?(Convert.ToUInt32(source.First<string>(), 10));
    }

    public uint? GetRequiredDownloadSystemVersion()
    {
      IEnumerable<string> source = this.m_Document.Descendants((XName) "RequiredDownloadSystemVersion").Select<XElement, string>((Func<XElement, string>) (meta => (string) meta));
      if (!source.Any<string>())
        return new uint?();
      return new uint?(Convert.ToUInt32(source.First<string>(), 10));
    }

    public string GetAddOnContentTag()
    {
      IEnumerable<string> source = this.m_Document.Descendants((XName) "AddOnContent").Select<XElement, string>((Func<XElement, string>) (meta => (string) meta.Element((XName) "Tag")));
      if (!source.Any<string>())
        return (string) null;
      return source.First<string>();
    }

    public Tuple<int, int> GetCardSpec()
    {
      IEnumerable<string> source1 = this.m_Document.Descendants((XName) "CardSpec").Select<XElement, string>((Func<XElement, string>) (meta => (string) meta.Element((XName) "Size")));
      IEnumerable<string> source2 = this.m_Document.Descendants((XName) "CardSpec").Select<XElement, string>((Func<XElement, string>) (meta => (string) meta.Element((XName) "ClockRate")));
      if (!source1.Any<string>() || !source2.Any<string>())
        return (Tuple<int, int>) null;
      return Tuple.Create<int, int>(Convert.ToInt32(source1.First<string>(), 10), Convert.ToInt32(source2.First<string>(), 10));
    }
  }
}
