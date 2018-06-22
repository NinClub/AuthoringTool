// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SinkLinkedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SinkLinkedSource : ISource
  {
    private ISink m_sink;
    private ISource m_source;

    public long Size { get; private set; }

    public SinkLinkedSource(ISink sink, ISource source)
    {
      this.m_sink = sink;
      this.m_source = source;
      this.Size = source.Size;
    }

    public ByteData PullData(long offset, int size)
    {
      if (!this.m_sink.QueryStatus().IsFilled)
        return new ByteData(new ArraySegment<byte>());
      return this.m_source.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      SourceStatus sourceStatus = new SourceStatus();
      if (this.m_sink.QueryStatus().IsFilled)
        sourceStatus.AvailableRangeList.MergingAdd(new Range(0L, this.m_source.Size));
      return sourceStatus;
    }
  }
}
