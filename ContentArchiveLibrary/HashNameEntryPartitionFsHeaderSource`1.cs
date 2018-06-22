// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.HashNameEntryPartitionFsHeaderSource`1
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class HashNameEntryPartitionFsHeaderSource<T> : ISource where T : IPartitionFileSystemMeta, new()
  {
    private List<ContentHashSource> m_hashSources;
    private PartitionFileSystemInfo m_partFsInfo;
    private byte[] m_buffer;

    public long Size { get; private set; }

    public HashNameEntryPartitionFsHeaderSource(List<ContentHashSource> hashSources, PartitionFileSystemInfo partFsInfo, long size)
    {
      this.Size = size;
      if (hashSources.Count != partFsInfo.entries.Count)
        throw new ArgumentException();
      this.m_hashSources = hashSources;
      this.m_partFsInfo = partFsInfo;
    }

    public ByteData PullData(long offset, int size)
    {
      if (this.m_buffer == null)
      {
        for (int index = 0; index < this.m_hashSources.Count; ++index)
        {
          if (!(this.m_hashSources[index].Extension != ".nca") || !(this.m_hashSources[index].Extension != ".cnmt.nca") || (!(this.m_hashSources[index].Extension != ".cnmt.xml") || !(this.m_hashSources[index].Extension != ".jpg")) || (!(this.m_hashSources[index].Extension != ".cnmt") || !(this.m_hashSources[index].Extension != ".nacp.xml") || !(this.m_hashSources[index].Extension != ".programinfo.xml")))
          {
            if (this.m_hashSources[index].Source == null || this.m_hashSources[index].Source.Size != 32L)
              throw new InvalidOperationException();
            ByteData byteData = this.m_hashSources[index].Source.PullData(0L, 16);
            ArraySegment<byte> buffer = byteData.Buffer;
            if (buffer.Count != 16)
              throw new InvalidOperationException();
            buffer = byteData.Buffer;
            byte[] numArray1 = new byte[buffer.Count];
            buffer = byteData.Buffer;
            byte[] array = buffer.Array;
            buffer = byteData.Buffer;
            int offset1 = buffer.Offset;
            byte[] numArray2 = numArray1;
            int dstOffset = 0;
            buffer = byteData.Buffer;
            int count = buffer.Count;
            Buffer.BlockCopy((Array) array, offset1, (Array) numArray2, dstOffset, count);
            PartitionFileSystemInfo.EntryInfo entry = this.m_partFsInfo.entries[index];
            entry.name = Regex.Replace(entry.name, "^.{32}", BitConverter.ToString(numArray1).Replace("-", string.Empty).ToLower());
            this.m_partFsInfo.entries[index] = entry;
          }
        }
        this.m_buffer = Activator.CreateInstance<T>().Create(this.m_partFsInfo);
        if (this.Size != (long) this.m_buffer.Length)
          throw new InvalidOperationException();
      }
      return new MemorySource(this.m_buffer, 0, this.m_buffer.Length).PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      SourceStatus sourceStatus = new SourceStatus();
      foreach (ContentHashSource hashSource in this.m_hashSources)
      {
        if (hashSource.Source != null)
        {
          RangeList availableRangeList = hashSource.Source.QueryStatus().AvailableRangeList;
          if (availableRangeList.Count != 1 || availableRangeList.Count == 1 && availableRangeList[0].Size != hashSource.Source.Size)
            return sourceStatus;
        }
      }
      sourceStatus.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
      return sourceStatus;
    }

    public static long GetDummySize(List<string> entryNameList)
    {
      T instance = Activator.CreateInstance<T>();
      PartitionFileSystemInfo fileSystemInfo = new PartitionFileSystemInfo();
      foreach (string entryName in entryNameList)
        fileSystemInfo.entries.Add(new PartitionFileSystemInfo.EntryInfo()
        {
          name = entryName
        });
      return (long) instance.Create(fileSystemInfo).Length;
    }
  }
}
