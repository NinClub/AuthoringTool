// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.PartitionFsArchiveSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class PartitionFsArchiveSource : ISource
  {
    private ISource m_source;

    public long Size { get; private set; }

    public PartitionFsArchiveSource(PartitionFileSystemInfo fileSystemInfo)
    {
      PartitionFileSystemMeta partitionFileSystemMeta = new PartitionFileSystemMeta();
      List<ConcatenatedSource.Element> elements = new List<ConcatenatedSource.Element>();
      PartitionFileSystemInfo fileSystemInfo1 = fileSystemInfo;
      byte[] buffer = partitionFileSystemMeta.Create(fileSystemInfo1);
      ConcatenatedSource.Element element1 = new ConcatenatedSource.Element((ISource) new MemorySource(buffer, 0, buffer.Length), "meta", 0L);
      elements.Add(element1);
      long size = element1.Source.Size;
      foreach (PartitionFileSystemInfo.EntryInfo entry in fileSystemInfo.entries)
      {
        ConcatenatedSource.Element element2 = new ConcatenatedSource.Element(entry.sourceInterface != null ? (ISource) entry.sourceInterface : (ISource) new FileSource(entry.path, 0L, (long) entry.size), entry.name, (long) entry.offset + size);
        elements.Add(element2);
      }
      this.m_source = (ISource) new ConcatenatedSource(elements);
      this.Size = this.m_source.Size;
    }

    public ByteData PullData(long offset, int size)
    {
      return this.m_source.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }
  }
}
