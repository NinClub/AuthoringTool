// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.MemorySource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class MemorySource : ISource
  {
    private int m_offset;
    private byte[] m_buffer;
    private SourceStatus m_status;

    public long Size { get; private set; }

    public MemorySource(byte[] buffer, int offset, int size)
    {
      this.m_buffer = new byte[buffer.Length];
      Buffer.BlockCopy((Array) buffer, 0, (Array) this.m_buffer, 0, this.m_buffer.Length);
      this.m_offset = offset;
      this.Size = (long) size;
      this.m_status = new SourceStatus();
      this.m_status.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
    }

    public ByteData PullData(long offset, int size)
    {
      int readableSize = SourceUtil.GetReadableSize(this.Size, offset, size);
      if (readableSize == 0)
        return new ByteData(new ArraySegment<byte>());
      return new ByteData(new ArraySegment<byte>(this.m_buffer, this.m_offset + (int) offset, readableSize));
    }

    public SourceStatus QueryStatus()
    {
      return this.m_status;
    }
  }
}
