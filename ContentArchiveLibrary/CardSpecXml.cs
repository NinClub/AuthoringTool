// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.CardSpecXml
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class CardSpecXml
  {
    private CardSpecModel m_model;

    public CardSpecXml(int size, int clockRate)
    {
      this.m_model = new CardSpecModel();
      if (size != XciInfo.InvalidRomSize && clockRate != XciInfo.InvalidClockRate)
        XciUtils.CheckRomSizeAndClockRate(size, clockRate);
      this.m_model.Size = size.ToString();
      this.m_model.ClockRate = clockRate.ToString();
    }

    public byte[] GetBytes()
    {
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      MemoryStream memoryStream = new MemoryStream();
      new XmlSerializer(typeof (CardSpecModel)).Serialize((TextWriter) new StreamWriter((Stream) memoryStream, Encoding.UTF8), (object) this.m_model, namespaces);
      return memoryStream.ToArray();
    }
  }
}
