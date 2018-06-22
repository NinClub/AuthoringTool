// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.MemorySink
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class MemorySink : IReadableSink, ISink
  {
    private byte[] m_buffer;
    private SinkStatus m_status;

    public long Size { get; private set; }

    public MemorySink(int size)
    {
      this.m_buffer = new byte[size];
      this.Size = (long) size;
      this.m_status = new SinkStatus();
    }

    public int PushData(ByteData data, long offset)
    {
      int writableSize = SinkUtil.GetWritableSize(this.Size, offset, data.Buffer.Count);
      if (writableSize == 0)
        return 0;
      Buffer.BlockCopy((Array) data.Buffer.Array, data.Buffer.Offset, (Array) this.m_buffer, (int) offset, writableSize);
      this.m_status.FilledRangeList.MergingAdd(new Range(offset, (long) writableSize));
      this.m_status.IsFilled = SinkUtil.CheckIsFilled(this.m_status.FilledRangeList, this.Size);
      return writableSize;
    }

    public SinkStatus QueryStatus()
    {
      return this.m_status;
    }

    public void SetSize(long size)
    {
      throw new NotSupportedException();
    }

    public ISource ToSource()
    {
      return (ISource) new UpdatableMemorySource(this.m_buffer, 0, (int) this.Size);
    }
  }
}
