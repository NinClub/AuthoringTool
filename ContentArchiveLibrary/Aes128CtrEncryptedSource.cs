// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Aes128CtrEncryptedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Aes128CtrEncryptedSource : ISource
  {
    private ISource m_source;
    private ICtrModeEncryptor m_crypto;

    public long Size
    {
      get
      {
        return this.m_source.Size;
      }
    }

    public int BlockSize { get; private set; }

    public int Generation { get; private set; }

    public long BaseOffset { get; private set; }

    public Aes128CtrEncryptedSource(ISource source, ICtrModeEncryptor encryptor, int generation, long baseOffset)
    {
      this.m_crypto = encryptor;
      this.BlockSize = 16;
      this.Generation = generation;
      this.BaseOffset = baseOffset;
      this.m_source = (ISource) new AlignedSource(source, this.BlockSize);
    }

    public ByteData PullData(long offset, int size)
    {
      ByteData byteData = this.m_source.PullData(offset, size);
      if (byteData.Buffer.Count == 0)
        return new ByteData(new ArraySegment<byte>());
      ulong num = (ulong) (this.BaseOffset + offset) / (ulong) this.BlockSize;
      byte[] numArray1 = new byte[this.m_crypto.KeySize];
      for (int index = 0; index < 4; ++index)
        numArray1[7 - index] = (byte) (this.Generation >> index * 8 & (int) byte.MaxValue);
      for (int index = 0; index < 8; ++index)
        numArray1[15 - index] = (byte) (num >> index * 8 & (ulong) byte.MaxValue);
      byte[] numArray2 = new byte[byteData.Buffer.Count];
      ICtrModeEncryptor crypto = this.m_crypto;
      byte[] iv = numArray1;
      ArraySegment<byte> buffer = byteData.Buffer;
      byte[] array1 = buffer.Array;
      buffer = byteData.Buffer;
      int offset1 = buffer.Offset;
      buffer = byteData.Buffer;
      int count1 = buffer.Count;
      byte[] dst = numArray2;
      int dstOffset = 0;
      crypto.EncryptBlock(iv, array1, offset1, count1, dst, dstOffset);
      byte[] array2 = numArray2;
      int offset2 = 0;
      buffer = byteData.Buffer;
      int count2 = buffer.Count;
      return new ByteData(new ArraySegment<byte>(array2, offset2, count2));
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }
  }
}
