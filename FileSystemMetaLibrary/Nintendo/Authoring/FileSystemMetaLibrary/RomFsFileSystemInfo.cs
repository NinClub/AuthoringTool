// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.RomFsFileSystemInfo
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class RomFsFileSystemInfo : FileSystemInfo
  {
    public int version;
    public List<RomFsFileSystemInfo.EntryInfo> entries;
    public int directoryEntryCount;
    public int fileEntryCount;

    public RomFsFileSystemInfo()
    {
      this.entries = new List<RomFsFileSystemInfo.EntryInfo>();
      GC.KeepAlive((object) this);
    }

    public struct EntryInfo
    {
      public string type;
      public string name;
      public ulong size;
      public ulong offset;
      public string path;
      public SourceInterface sourceInterface;
    }
  }
}
