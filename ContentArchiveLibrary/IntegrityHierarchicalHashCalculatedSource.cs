// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.IntegrityHierarchicalHashCalculatedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class IntegrityHierarchicalHashCalculatedSource : IHierarchicalHashCalculatedSource, ISource
  {
    private const int IntegrityHashLayerBlockSize = 4096;
    private ISource m_source;
    private IntegrityHierarchicalStorageSink m_sink;

    public long Size { get; private set; }

    public IntegrityHierarchicalHashCalculatedSource(ISource source)
    {
      this.Size = source.Size;
      this.m_source = (ISource) new AlignedSource(source, HierarchicalIntegrityVerificationStorage.GetHashBlockSize());
      this.m_sink = new IntegrityHierarchicalStorageSink(this.Size);
    }

    private void CalculateHash(ByteData sourceData, long offset, int size)
    {
      if (this.m_sink.QueryStatus().IsFilled)
        throw new InvalidOperationException();
      this.m_sink.PushData(sourceData, offset);
    }

    public ByteData PullData(long offset, int size)
    {
      ByteData sourceData = this.m_source.PullData(offset, size);
      this.CalculateHash(sourceData, offset, sourceData.Buffer.Count);
      return sourceData;
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }

    public ISource GetMasterHashSource()
    {
      return (ISource) new SinkLinkedSource((ISink) this.m_sink, (ISource) new IntegrityHierarchicalMasterHashSource(this.m_sink));
    }

    public ISource GetLayerHashSource()
    {
      return (ISource) new SinkLinkedSource((ISink) this.m_sink, (ISource) new IntegrityHierarchicalLayerHashSource(this.m_sink));
    }

    public ISource GetFsHeaderSource(NintendoContentFileSystemInfo.EntryInfo entryInfo)
    {
      NintendoContentFileSystemMeta contentFileSystemMeta = new NintendoContentFileSystemMeta();
      byte[] ncaFsHeader = contentFileSystemMeta.CreateNcaFsHeader((ValueType) entryInfo, this.m_sink.GetMetaInfo());
      int masterHashOffset = contentFileSystemMeta.GetIntegrityMasterHashOffset();
      ISource masterHashSource = this.GetMasterHashSource();
      return (ISource) new AdaptedSource((ISource) new MemorySource(ncaFsHeader, 0, ncaFsHeader.Length), masterHashSource, (long) masterHashOffset, masterHashSource.Size);
    }
  }
}
