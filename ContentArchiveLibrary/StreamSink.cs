// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.StreamSink
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.IO;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class StreamSink : IReadableSink, ISink
  {
    private Stream m_stream;
    private SinkStatus m_status;

    public long Size { get; private set; }

    public StreamSink(Stream stream)
    {
      this.m_stream = stream;
      this.Size = 0L;
      this.m_status = new SinkStatus();
    }

    public int PushData(ByteData data, long offset)
    {
      if (this.Size == 0L)
        throw new InvalidOperationException();
      long size = this.Size;
      long offset1 = offset;
      ArraySegment<byte> buffer = data.Buffer;
      int count1 = buffer.Count;
      int writableSize = SinkUtil.GetWritableSize(size, offset1, count1);
      if (writableSize == 0)
        return 0;
      this.m_stream.Seek(offset, SeekOrigin.Begin);
      Stream stream = this.m_stream;
      buffer = data.Buffer;
      byte[] array = buffer.Array;
      buffer = data.Buffer;
      int offset2 = buffer.Offset;
      int count2 = writableSize;
      stream.Write(array, offset2, count2);
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
      this.Size = size;
    }

    public ISource ToSource()
    {
      return (ISource) new StreamSource(this.m_stream, 0L, this.Size);
    }
  }
}
