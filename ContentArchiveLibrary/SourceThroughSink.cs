// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SourceThroughSink
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SourceThroughSink : IReadableSink, ISink
  {
    private ISource m_source;

    public long Size { get; private set; }

    public SourceThroughSink(ISource source)
    {
      this.m_source = source;
      this.Size = source.Size;
    }

    public int PushData(ByteData data, long offset)
    {
      return data.Buffer.Count;
    }

    public SinkStatus QueryStatus()
    {
      SinkStatus sinkStatus = new SinkStatus();
      foreach (Range availableRange in (List<Range>) this.m_source.QueryStatus().AvailableRangeList)
        sinkStatus.FilledRangeList.MergingAdd(availableRange);
      sinkStatus.IsFilled = SinkUtil.CheckIsFilled(sinkStatus.FilledRangeList, this.Size);
      return sinkStatus;
    }

    public void SetSize(long size)
    {
      if (size != this.m_source.Size)
        throw new ArgumentException();
    }

    public ISource ToSource()
    {
      return this.m_source;
    }
  }
}
