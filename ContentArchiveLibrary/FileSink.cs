// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.FileSink
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.IO;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class FileSink : IReadableSink, ISink
  {
    private string m_filePath;
    private long m_offset;
    private SinkStatus m_status;

    public long Size { get; private set; }

    public FileSink(string filePath, long offset, long size)
    {
      this.m_filePath = filePath;
      this.m_offset = offset;
      this.Size = size;
      this.m_status = new SinkStatus();
    }

    public int PushData(ByteData data, long offset)
    {
      int writableSize = SinkUtil.GetWritableSize(this.Size, offset, data.Buffer.Count);
      if (writableSize == 0)
        return 0;
      using (Stream stream1 = (Stream) new SubStream((Stream) new FileStream(this.m_filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.RandomAccess), this.m_offset, this.Size))
      {
        stream1.Seek(offset, SeekOrigin.Begin);
        Stream stream2 = stream1;
        ArraySegment<byte> buffer = data.Buffer;
        byte[] array = buffer.Array;
        buffer = data.Buffer;
        int offset1 = buffer.Offset;
        int count = writableSize;
        stream2.Write(array, offset1, count);
      }
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
      FileInfo fileInfo = new FileInfo(this.m_filePath);
      return (ISource) new FileSource(this.m_filePath, this.m_offset, this.Size);
    }
  }
}
