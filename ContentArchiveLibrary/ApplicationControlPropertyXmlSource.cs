// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ApplicationControlPropertyXmlSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.ApplicationControlProperty;
using System.IO;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ApplicationControlPropertyXmlSource : ISource
  {
    private ISource m_source;

    public long Size { get; set; }

    public ApplicationControlPropertyXmlSource(ApplicationControlPropertyModel model)
    {
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      MemoryStream memoryStream = new MemoryStream();
      new XmlSerializer(typeof (ApplicationControlPropertyModel)).Serialize((Stream) memoryStream, (object) model, namespaces);
      byte[] array = memoryStream.ToArray();
      this.m_source = (ISource) new MemorySource(array, 0, array.Length);
      this.Size = this.m_source.Size;
    }

    public ByteData PullData(long offset, int size)
    {
      return this.m_source.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }
  }
}
