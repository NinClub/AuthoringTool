// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Sha256HierarchicalHashCalculatedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Sha256HierarchicalHashCalculatedSource : IHierarchicalHashCalculatedSource, ISource
  {
    private int HashSize = 32;
    private int m_blockSize;
    private int m_hashLayerCount;
    private ISource m_source;
    private List<MemorySink> m_hierarchicalHashValueSinkList;
    private SHA256CryptoServiceProvider m_hashCalculator;

    public long Size { get; private set; }

    public Sha256HierarchicalHashCalculatedSource(ISource source, int blockSize, int hashLayerCount)
    {
      this.Size = source.Size;
      this.m_blockSize = blockSize;
      if (hashLayerCount < 1 || hashLayerCount > 2)
        throw new ArgumentException();
      this.m_hashLayerCount = hashLayerCount;
      this.m_source = (ISource) new AlignedSource(source, blockSize);
      this.m_hierarchicalHashValueSinkList = new List<MemorySink>();
      this.m_hierarchicalHashValueSinkList.Add(new MemorySink(this.HashSize));
      if (hashLayerCount == 2)
        this.m_hierarchicalHashValueSinkList.Add(new MemorySink(Math.Min(this.HashSize * (int) ((source.Size + (long) (blockSize - 1)) / (long) blockSize), blockSize)));
      this.m_hashCalculator = new SHA256CryptoServiceProvider();
    }

    private void CalculateAndStoreHash(ByteData srcData, long dstOffset, int hashLayerCount)
    {
      if (this.m_hierarchicalHashValueSinkList[hashLayerCount].QueryStatus().IsFilled)
        throw new InvalidOperationException();
      int num1 = 0;
      int num2 = 0;
      while (true)
      {
        int num3 = num2;
        ArraySegment<byte> buffer = srcData.Buffer;
        int count1 = buffer.Count;
        if (num3 < count1)
        {
          buffer = srcData.Buffer;
          int num4 = Math.Min(buffer.Count - num2, this.m_blockSize);
          SHA256CryptoServiceProvider hashCalculator = this.m_hashCalculator;
          buffer = srcData.Buffer;
          byte[] array = buffer.Array;
          buffer = srcData.Buffer;
          int offset = buffer.Offset + num2;
          int count2 = num4;
          byte[] hash = hashCalculator.ComputeHash(array, offset, count2);
          num1 += this.m_hierarchicalHashValueSinkList[hashLayerCount].PushData(new ByteData(new ArraySegment<byte>(hash, 0, hash.Length)), dstOffset + (long) num1);
          num2 += this.m_blockSize;
        }
        else
          break;
      }
      if (!this.m_hierarchicalHashValueSinkList[hashLayerCount].QueryStatus().IsFilled || hashLayerCount == 0)
        return;
      ISource source = this.m_hierarchicalHashValueSinkList[hashLayerCount].ToSource();
      this.CalculateAndStoreHash(source.PullData(0L, (int) source.Size), 0L, hashLayerCount - 1);
    }

    public ByteData PullData(long offset, int size)
    {
      ByteData srcData = this.m_source.PullData(offset, size);
      long dstOffset = (long) this.HashSize * offset / (long) this.m_blockSize;
      this.CalculateAndStoreHash(srcData, dstOffset, this.m_hashLayerCount - 1);
      return srcData;
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }

    public ISource GetMasterHashSource()
    {
      return (ISource) new SinkLinkedSource((ISink) this.m_hierarchicalHashValueSinkList[0], this.m_hierarchicalHashValueSinkList[0].ToSource());
    }

    public ISource GetLayerHashSource()
    {
      if (this.m_hashLayerCount == 1)
        return this.GetMasterHashSource();
      List<ConcatenatedSource.Element> elements = new List<ConcatenatedSource.Element>();
      long offset = 0;
      for (int index = 1; index < this.m_hashLayerCount; ++index)
      {
        ConcatenatedSource.Element element = new ConcatenatedSource.Element((ISource) new SinkLinkedSource((ISink) this.m_hierarchicalHashValueSinkList[index], this.m_hierarchicalHashValueSinkList[index].ToSource()), "Hash:L" + (object) index, offset);
        offset += this.m_hierarchicalHashValueSinkList[index].Size;
        elements.Add(element);
      }
      return (ISource) new ConcatenatedSource(elements);
    }

    public ISource GetFsHeaderSource(NintendoContentFileSystemInfo.EntryInfo entryInfo)
    {
      NintendoContentFileSystemMeta contentFileSystemMeta = new NintendoContentFileSystemMeta();
      byte[] ncaFsHeader = contentFileSystemMeta.CreateNcaFsHeader((ValueType) entryInfo, new byte[0]);
      int masterHashOffset = contentFileSystemMeta.GetHierarchicalSha256MasterHashOffset();
      ISource masterHashSource = this.GetMasterHashSource();
      return (ISource) new AdaptedSource((ISource) new MemorySource(ncaFsHeader, 0, ncaFsHeader.Length), masterHashSource, (long) masterHashOffset, masterHashSource.Size);
    }
  }
}
