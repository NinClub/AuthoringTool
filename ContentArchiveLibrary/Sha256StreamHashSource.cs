// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Sha256StreamHashSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.IO;
using System.Security.Cryptography;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Sha256StreamHashSource : ISource
  {
    private ISource m_source;
    private SHA256CryptoServiceProvider m_hashCalculator;
    private SourceStatus m_status;
    private byte[] m_hash;

    public long Size { get; private set; }

    public Sha256StreamHashSource(ISource source)
    {
      this.Size = 32L;
      this.m_source = source;
      this.m_hashCalculator = new SHA256CryptoServiceProvider();
      this.m_status = new SourceStatus();
      this.m_status.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
    }

    public ByteData PullData(long offset, int size)
    {
      if (this.m_hash == null)
      {
        using (Stream inputStream = (Stream) new SourceBasedStream(this.m_source))
        {
          inputStream.Seek(0L, SeekOrigin.Begin);
          this.m_hash = this.m_hashCalculator.ComputeHash(inputStream);
        }
      }
      return new MemorySource(this.m_hash, 0, this.m_hash.Length).PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.m_status;
    }
  }
}
