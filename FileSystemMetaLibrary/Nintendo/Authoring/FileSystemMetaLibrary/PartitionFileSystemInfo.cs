// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.PartitionFileSystemInfo
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class PartitionFileSystemInfo : FileSystemInfo
  {
    public int version;
    public List<PartitionFileSystemInfo.EntryInfo> entries;

    public PartitionFileSystemInfo()
    {
      this.entries = new List<PartitionFileSystemInfo.EntryInfo>();
      GC.KeepAlive((object) this);
    }

    public struct EntryInfo
    {
      public string type;
      public string name;
      public ulong size;
      public ulong offset;
      public string path;
      public ulong hashTargetOffset;
      public uint hashTargetSize;
      public SourceInterface sourceInterface;

      public static PartitionFileSystemInfo.EntryInfo Make(string name, ulong size, ulong offset, ulong hashTargetOffset, uint hashTargetSize)
      {
        return new PartitionFileSystemInfo.EntryInfo()
        {
          name = name,
          size = size,
          offset = offset,
          hashTargetOffset = hashTargetOffset,
          hashTargetSize = hashTargetSize
        };
      }

      public static PartitionFileSystemInfo.EntryInfo Make(string name, ulong size, ulong offset)
      {
        return new PartitionFileSystemInfo.EntryInfo()
        {
          name = name,
          size = size,
          offset = offset
        };
      }
    }
  }
}
