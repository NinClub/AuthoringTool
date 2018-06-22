// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SourceBasedStream
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.IO;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SourceBasedStream : Stream
  {
    private ISource m_source;
    private long m_offset;

    public override bool CanRead
    {
      get
      {
        return true;
      }
    }

    public override bool CanSeek
    {
      get
      {
        return true;
      }
    }

    public override bool CanWrite
    {
      get
      {
        return false;
      }
    }

    public override long Length
    {
      get
      {
        return this.m_source.Size;
      }
    }

    public override long Position
    {
      get
      {
        return this.m_offset;
      }
      set
      {
        this.Seek(value, SeekOrigin.Begin);
      }
    }

    public SourceBasedStream(ISource source)
    {
      this.m_source = source;
      this.m_offset = 0L;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      ByteData byteData = this.m_source.PullData(this.m_offset, count);
      if (byteData.Buffer.Count == 0)
        return 0;
      Buffer.BlockCopy((Array) byteData.Buffer.Array, byteData.Buffer.Offset, (Array) buffer, offset, byteData.Buffer.Count);
      long offset1 = this.m_offset;
      ArraySegment<byte> buffer1 = byteData.Buffer;
      long count1 = (long) buffer1.Count;
      this.m_offset = offset1 + count1;
      buffer1 = byteData.Buffer;
      return buffer1.Count;
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      throw new NotSupportedException();
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      long num = offset;
      switch (origin)
      {
        case SeekOrigin.Begin:
          num = num;
          break;
        case SeekOrigin.Current:
          num += this.Position;
          break;
        case SeekOrigin.End:
          num += this.Length;
          break;
      }
      if (num < 0L || this.Length < num)
        throw new ArgumentOutOfRangeException();
      this.m_offset = num;
      return this.m_offset;
    }

    public override void SetLength(long value)
    {
      throw new NotSupportedException();
    }

    public override void Flush()
    {
      throw new NotSupportedException();
    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }
  }
}
