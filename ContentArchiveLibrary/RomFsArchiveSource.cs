// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.RomFsArchiveSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class RomFsArchiveSource : ISource
  {
    private ISource m_source;

    public long Size { get; private set; }

    public RomFsArchiveSource(RomFsFileSystemInfo fileSystemInfo)
    {
      RomFsFileSystemMeta fsFileSystemMeta = new RomFsFileSystemMeta();
      List<ConcatenatedSource.Element> elements = new List<ConcatenatedSource.Element>();
      RomFsFileSystemInfo fileSystemInfo1 = fileSystemInfo;
      RomFsFileSystemMetaInfo fileSystemMetaInfo = fsFileSystemMeta.Create(fileSystemInfo1);
      ConcatenatedSource.Element element1 = new ConcatenatedSource.Element((ISource) new MemorySource(fileSystemMetaInfo.header, 0, fileSystemMetaInfo.header.Length), "meta_header", 0L);
      elements.Add(element1);
      long size = element1.Source.Size;
      foreach (RomFsFileSystemInfo.EntryInfo entry in fileSystemInfo.entries)
      {
        if (entry.type == "file")
        {
          ConcatenatedSource.Element element2 = new ConcatenatedSource.Element((ISource) new FileSource(entry.path, 0L, (long) entry.size), entry.name, (long) entry.offset + size);
          elements.Add(element2);
        }
        else if (entry.type == "source")
        {
          ConcatenatedSource.Element element2 = new ConcatenatedSource.Element((ISource) entry.sourceInterface, entry.name, (long) entry.offset + size);
          elements.Add(element2);
        }
      }
      RomFsFileSystemInfo.EntryInfo entry1 = fileSystemInfo.entries[fileSystemInfo.entries.Count - 1];
      long offset = size + (long) entry1.offset + (long) entry1.size;
      if (fileSystemMetaInfo.offsetData > offset)
        elements.Add(new ConcatenatedSource.Element((ISource) new PaddingSource(fileSystemMetaInfo.offsetData - offset), "romFsMetaBodyPadding", offset));
      ConcatenatedSource.Element element3 = new ConcatenatedSource.Element((ISource) new MemorySource(fileSystemMetaInfo.data, 0, fileSystemMetaInfo.data.Length), "meta_data", fileSystemMetaInfo.offsetData);
      elements.Add(element3);
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
