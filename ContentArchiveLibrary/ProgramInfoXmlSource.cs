// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ProgramInfoXmlSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ProgramInfoXmlSource : ISource
  {
    private ISource m_source;

    public long Size { get; set; }

    public ProgramInfoXmlSource(ProgramInfoXml programInfoXml)
    {
      byte[] bytes = programInfoXml.GetBytes();
      this.m_source = (ISource) new MemorySource(bytes, 0, bytes.Length);
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
