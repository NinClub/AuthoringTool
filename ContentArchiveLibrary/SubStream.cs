// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SubStream
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.IO;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SubStream : Stream
  {
    private Stream m_baseStream;
    private long m_baseOffset;
    private long m_baseEndPosition;
    private bool m_disposed;

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
        return true;
      }
    }

    public override long Length
    {
      get
      {
        return this.m_baseEndPosition - this.m_baseOffset;
      }
    }

    public override long Position
    {
      get
      {
        return this.m_baseStream.Position - this.m_baseOffset;
      }
      set
      {
        this.Seek(value, SeekOrigin.Begin);
      }
    }

    public SubStream(Stream stream, long offset, long length)
    {
      this.m_baseStream = stream;
      this.m_baseOffset = offset;
      if (length < 0L)
        throw new ArgumentOutOfRangeException();
      this.m_baseEndPosition = this.m_baseOffset + length;
      this.m_baseStream.Seek(this.m_baseOffset, SeekOrigin.Begin);
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      if (this.m_baseStream.Length != this.m_baseEndPosition && this.m_baseStream.Length - this.m_baseStream.Position < (long) count)
        throw new ArgumentOutOfRangeException();
      long num = this.m_baseEndPosition - this.m_baseStream.Position;
      if (num < (long) count)
        return this.m_baseStream.Read(buffer, offset, (int) num);
      return this.m_baseStream.Read(buffer, offset, count);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      long num = this.m_baseEndPosition - this.m_baseStream.Position;
      if (num < (long) count)
        throw new ArgumentOutOfRangeException();
      this.m_baseStream.Write(buffer, offset, count);
      if (num >= (long) count)
        return;
      this.m_baseStream.SetLength(this.m_baseStream.Position);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      long offset1 = offset;
      switch (origin)
      {
        case SeekOrigin.Begin:
          offset1 += this.m_baseOffset;
          break;
        case SeekOrigin.Current:
          offset1 += this.Position + this.m_baseOffset;
          break;
        case SeekOrigin.End:
          offset1 += this.m_baseEndPosition;
          break;
      }
      if (offset1 < this.m_baseOffset || this.m_baseEndPosition < offset1)
        throw new ArgumentOutOfRangeException();
      long num = this.m_baseStream.Seek(offset1, SeekOrigin.Begin);
      if (this.m_baseStream.Length >= offset1)
        return num;
      this.m_baseStream.SetLength(this.m_baseStream.Position);
      return num;
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
      if (!this.m_disposed)
      {
        if (disposing)
          this.m_baseStream.Dispose();
        this.m_disposed = true;
      }
      base.Dispose(disposing);
    }
  }
}
