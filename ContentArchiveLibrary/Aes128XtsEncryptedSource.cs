// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Aes128XtsEncryptedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Aes128XtsEncryptedSource : ISource
  {
    private ISource m_source;
    private IXtsModeEncryptor m_crypto;

    public long Size
    {
      get
      {
        return this.m_source.Size;
      }
    }

    public int BlockSize { get; private set; }

    public Aes128XtsEncryptedSource(ISource source, IXtsModeEncryptor encryptor)
    {
      this.m_crypto = encryptor;
      this.BlockSize = 512;
      this.m_source = (ISource) new AlignedSource(source, this.BlockSize);
    }

    public ByteData PullData(long offset, int size)
    {
      ByteData byteData = this.m_source.PullData(offset, size);
      if (byteData.Buffer.Count % this.BlockSize != 0)
        throw new InvalidOperationException();
      if (offset % (long) this.BlockSize != 0L)
        throw new InvalidOperationException();
      if (byteData.Buffer.Count == 0)
        return new ByteData(new ArraySegment<byte>());
      byte[] numArray = new byte[byteData.Buffer.Count];
      int num1 = 0;
      ArraySegment<byte> buffer;
      while (true)
      {
        int num2 = num1;
        buffer = byteData.Buffer;
        int count = buffer.Count;
        if (num2 < count)
        {
          IXtsModeEncryptor crypto = this.m_crypto;
          byte[] initialTweak = this.GetInitialTweak(offset + (long) num1);
          buffer = byteData.Buffer;
          byte[] array = buffer.Array;
          buffer = byteData.Buffer;
          int srcOffset = buffer.Offset + num1;
          int blockSize = this.BlockSize;
          byte[] dst = numArray;
          int dstOffset = num1;
          crypto.EncryptBlock(initialTweak, array, srcOffset, blockSize, dst, dstOffset);
          num1 += this.BlockSize;
        }
        else
          break;
      }
      byte[] array1 = numArray;
      int offset1 = 0;
      buffer = byteData.Buffer;
      int count1 = buffer.Count;
      return new ByteData(new ArraySegment<byte>(array1, offset1, count1));
    }

    private byte[] GetInitialTweak(long offset)
    {
      ulong num = (ulong) offset / (ulong) this.BlockSize;
      byte[] numArray = new byte[this.m_crypto.KeySize];
      for (int index = 0; index < 8; ++index)
        numArray[numArray.Length - 1 - index] = (byte) (num >> index * 8 & (ulong) byte.MaxValue);
      return numArray;
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }

    public static byte[] GetDefaultKey(int index)
    {
      return Aes128XtsCryptoDriver.GetDefaultKey(index);
    }
  }
}
