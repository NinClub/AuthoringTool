// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.CliCompatibleSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class CliCompatibleSource : ISource, SourceInterface
  {
    private ISource m_source;

    public long Size { get; private set; }

    public CliCompatibleSource(ISource source)
    {
      this.m_source = source;
      this.Size = source.Size;
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
