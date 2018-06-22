// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SubSink
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SubSink : ISink
  {
    private ISink m_sink;
    private long m_offset;
    private SinkStatus m_status;

    public long Size { get; private set; }

    public SubSink(ISink sink, long offset, long size)
    {
      this.m_sink = sink;
      this.m_offset = offset;
      this.Size = size;
      this.m_status = new SinkStatus();
    }

    public int PushData(ByteData data, long offset)
    {
      int count = data.Buffer.Count;
      if (offset + (long) count > this.Size)
      {
        int num = (int) (this.Size - offset);
        count = num > 0 ? num : 0;
      }
      int num1 = this.m_sink.PushData(new ByteData(new ArraySegment<byte>(data.Buffer.Array, data.Buffer.Offset, count)), this.m_offset + offset);
      this.m_status.FilledRangeList.MergingAdd(new Range(offset, (long) num1));
      this.m_status.IsFilled = SinkUtil.CheckIsFilled(this.m_status.FilledRangeList, this.Size);
      return num1;
    }

    public SinkStatus QueryStatus()
    {
      return this.m_status;
    }

    public void SetSize(long size)
    {
      throw new NotSupportedException();
    }
  }
}
