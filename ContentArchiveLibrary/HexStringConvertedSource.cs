// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.HexStringConvertedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Text;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class HexStringConvertedSource : ISource
  {
    private ISource m_source;

    public long Size { get; private set; }

    public HexStringConvertedSource(ISource source)
    {
      this.Size = source.Size * 2L;
      this.m_source = source;
    }

    public ByteData PullData(long offset, int size)
    {
      if (size % 2 != 0)
        throw new ArgumentException();
      ByteData byteData = this.m_source.PullData(offset, size / 2);
      byte[] numArray1 = new byte[byteData.Buffer.Count];
      byte[] array = byteData.Buffer.Array;
      ArraySegment<byte> buffer = byteData.Buffer;
      int offset1 = buffer.Offset;
      byte[] numArray2 = numArray1;
      int dstOffset = 0;
      buffer = byteData.Buffer;
      int count = buffer.Count;
      Buffer.BlockCopy((Array) array, offset1, (Array) numArray2, dstOffset, count);
      byte[] bytes = Encoding.ASCII.GetBytes(BitConverter.ToString(numArray1).Replace("-", string.Empty));
      return new ByteData(new ArraySegment<byte>(bytes, 0, bytes.Length));
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }
  }
}
