// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Rsa2048PssSha256SignedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Rsa2048PssSha256SignedSource : ISource
  {
    private ISigner[] m_signer = new ISigner[2];
    private MemorySink[] m_rsaValueSink = new MemorySink[2];
    private ISource m_source;

    public long Size
    {
      get
      {
        return this.m_source.Size;
      }
    }

    public Rsa2048PssSha256SignedSource(ISource source, ISigner signer)
      : this(source, signer, (ISigner) null)
    {
    }

    public Rsa2048PssSha256SignedSource(ISource source, ISigner signer1, ISigner signer2)
    {
      this.m_signer[0] = signer1;
      this.m_signer[1] = signer2;
      this.m_source = source;
      this.m_rsaValueSink[0] = new MemorySink(Rsa2048PssSha256SignCryptoDriver.KeySize);
      this.m_rsaValueSink[1] = new MemorySink(Rsa2048PssSha256SignCryptoDriver.KeySize);
    }

    public ByteData PullData(long offset, int size)
    {
      if (offset != 0L || (long) size < this.Size)
        throw new ArgumentException();
      ByteData byteData = this.m_source.PullData(offset, size);
      if ((long) byteData.Buffer.Count != this.Size)
        throw new InvalidOperationException();
      for (int index = 0; index < 2; ++index)
      {
        byte[] array1;
        if (this.m_signer[index] != null)
        {
          ISigner signer = this.m_signer[index];
          ArraySegment<byte> buffer = byteData.Buffer;
          byte[] array2 = buffer.Array;
          buffer = byteData.Buffer;
          int offset1 = buffer.Offset;
          buffer = byteData.Buffer;
          int count = buffer.Count;
          array1 = signer.SignBlock(array2, offset1, count);
        }
        else
          array1 = new byte[this.m_rsaValueSink[index].Size];
        this.m_rsaValueSink[index].PushData(new ByteData(new ArraySegment<byte>(array1, 0, array1.Length)), 0L);
      }
      return byteData;
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }

    public ISource GetSignatureValueSource()
    {
      return this.GetSignatureValueSource(0);
    }

    public ISource GetSignatureValueSource(int index)
    {
      if (this.m_signer[index] != null)
        return (ISource) new SinkLinkedSource((ISink) this.m_rsaValueSink[index], this.m_rsaValueSink[index].ToSource());
      return (ISource) new PaddingSource((long) Rsa2048PssSha256SignCryptoDriver.KeySize);
    }
  }
}
