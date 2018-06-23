// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.IFileSystemArchiveReader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public interface IFileSystemArchiveReader
  {
    List<Tuple<string, long>> ListFileInfo(string rootPath);

    List<Tuple<string, long>> ListFileInfo();

    List<Tuple<long, long>> GetFileFragmentList(string fileName);

    long GetFileSize(string fileName);

    byte[] ReadFile(string fileName, long offset, long size);

    long GetBaseSize();

    byte[] ReadBase(long offset, long size);
  }
}
