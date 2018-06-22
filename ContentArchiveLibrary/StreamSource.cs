// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.StreamSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.IO;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class StreamSource : ISource
  {
    private Stream m_stream;
    private long m_offset;
    private SourceStatus m_status;

    public long Size { get; private set; }

    public StreamSource(Stream stream, long offset, long size)
    {
      this.m_stream = stream;
      this.m_offset = offset;
      this.Size = size;
      this.m_status = new SourceStatus();
      this.m_status.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
    }

    public ByteData PullData(long offset, int size)
    {
      int readableSize = SourceUtil.GetReadableSize(this.Size, offset, size);
      if (readableSize == 0)
        return new ByteData(new ArraySegment<byte>());
      this.m_stream.Seek(offset, SeekOrigin.Begin);
      byte[] numArray = new byte[readableSize];
      this.m_stream.Read(numArray, 0, readableSize);
      return new ByteData(new ArraySegment<byte>(numArray, 0, readableSize));
    }

    public SourceStatus QueryStatus()
    {
      return this.m_status;
    }
  }
}
