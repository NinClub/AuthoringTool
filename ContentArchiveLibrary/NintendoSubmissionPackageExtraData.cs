// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoSubmissionPackageExtraData
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoSubmissionPackageExtraData : ISource
  {
    private ISource m_Source;

    public string EntryName { get; private set; }

    public long Size
    {
      get
      {
        return this.m_Source.Size;
      }
    }

    public NintendoSubmissionPackageExtraData(string name, ISource source)
    {
      this.EntryName = name;
      this.m_Source = source;
    }

    public ByteData PullData(long offset, int size)
    {
      return this.m_Source.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.m_Source.QueryStatus();
    }
  }
}
