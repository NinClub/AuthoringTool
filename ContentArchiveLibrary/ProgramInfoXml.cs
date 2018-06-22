// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ProgramInfoXml
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ProgramInfoXml
  {
    private ProgramInfoModel m_model;
    private MiddlewareXml m_middlewareXml;
    private DebugApiXml m_debugApiXml;
    private ApiXml m_apiXml;

    public ProgramInfoXml(SymbolExtract symbolExtract)
    {
      this.m_model = new ProgramInfoModel();
      this.m_middlewareXml = new MiddlewareXml(symbolExtract.GetMiddlewareInfos());
      this.m_model.MiddlewareListData = this.m_middlewareXml.m_middlewareList;
      this.m_debugApiXml = new DebugApiXml(symbolExtract.GetDebugApiInfos());
      this.m_model.DebugApiListData = this.m_debugApiXml.m_debugApiList;
      this.m_apiXml = new ApiXml();
      this.m_model.ApiListData = this.m_apiXml.m_apiList;
    }

    public ProgramInfoXml(List<ProgramInfoXml> xmlList)
    {
      this.m_model = new ProgramInfoModel();
      this.m_middlewareXml = new MiddlewareXml();
      this.m_debugApiXml = new DebugApiXml();
      this.m_apiXml = new ApiXml();
      foreach (ProgramInfoXml xml in xmlList)
      {
        this.m_middlewareXml.m_middlewareList.Entries.AddRange((IEnumerable<MiddlewareModel>) xml.m_middlewareXml.m_middlewareList.Entries);
        this.m_debugApiXml.m_debugApiList.Entries.AddRange((IEnumerable<DebugApiModel>) xml.m_debugApiXml.m_debugApiList.Entries);
        this.m_apiXml.m_apiList.Entries.AddRange((IEnumerable<ApiModel>) xml.m_apiXml.m_apiList.Entries);
      }
      this.m_model.MiddlewareListData = this.m_middlewareXml.m_middlewareList;
      this.m_model.DebugApiListData = this.m_debugApiXml.m_debugApiList;
      this.m_model.ApiListData = this.m_apiXml.m_apiList;
    }

    public byte[] GetBytes()
    {
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      MemoryStream memoryStream = new MemoryStream();
      new XmlSerializer(typeof (ProgramInfoModel)).Serialize((TextWriter) new StreamWriter((Stream) memoryStream, Encoding.UTF8), (object) this.m_model, namespaces);
      return memoryStream.ToArray();
    }
  }
}
