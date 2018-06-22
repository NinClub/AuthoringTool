// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentMetaArchiveSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoContentMetaArchiveSource : ISource
  {
    private ISource m_source;

    public long Size { get; private set; }

    internal NintendoContentMetaArchiveSource(NintendoContentMetaBase contentMeta, int keyEncryptionKeyIndex, KeyConfiguration config, bool isProdEncryption, bool isGameCard)
    {
      NintendoContentMetaReader contentMetaReader = new NintendoContentMetaReader(contentMeta.GetBytes());
      ISource source1 = contentMeta.GetSource();
      PartitionFileSystemInfo partitionFileSystemInfo = new PartitionFileSystemInfo();
      partitionFileSystemInfo.version = 0;
      partitionFileSystemInfo.entries.Add(new PartitionFileSystemInfo.EntryInfo()
      {
        type = "source",
        name = contentMeta.GetEntryName(),
        offset = 0UL,
        size = (ulong) source1.Size
      });
      PartitionFileSystemMeta partitionFileSystemMeta = new PartitionFileSystemMeta();
      List<ConcatenatedSource.Element> elements = new List<ConcatenatedSource.Element>();
      PartitionFileSystemInfo fileSystemInfo = partitionFileSystemInfo;
      byte[] buffer = partitionFileSystemMeta.Create(fileSystemInfo);
      ConcatenatedSource.Element element1 = new ConcatenatedSource.Element((ISource) new MemorySource(buffer, 0, buffer.Length), "meta", 0L);
      ConcatenatedSource.Element element2 = new ConcatenatedSource.Element(source1, "body", element1.Source.Size);
      elements.Add(element1);
      elements.Add(element2);
      ISource source2 = (ISource) new ConcatenatedSource(elements);
      this.m_source = (ISource) new NintendoContentArchiveSource(new NintendoContentFileSystemInfo()
      {
        distributionType = isGameCard ? (byte) 1 : (byte) 0,
        contentType = (byte) 1,
        keyGeneration = (byte) 0,
        programId = contentMetaReader.GetId(),
        contentIndex = 0U,
        keyAreaEncryptionKeyIndex = (byte) keyEncryptionKeyIndex,
        isProdEncryption = isProdEncryption,
        fsEntries = {
          new NintendoContentFileSystemInfo.EntryInfo()
          {
            type = "source",
            formatType = "PartitionFs",
            sourceInterface = (SourceInterface) new CliCompatibleSource(source2),
            version = (ushort) 2,
            hashType = (byte) 0,
            encryptionType = (byte) 0
          }
        },
        numFsEntries = 1
      }, config, false);
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
