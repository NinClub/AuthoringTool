// Decompiled with JetBrains decompiler
// Type: nn.fssystem.FileSystemBufferManager
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nn.fssystem
{
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 144)]
  internal struct FileSystemBufferManager
  {
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 64)]
    internal struct CacheHandleTable
    {
      [NativeCppClass]
      [StructLayout(LayoutKind.Sequential, Size = 24)]
      internal struct Entry
      {
      }

      [NativeCppClass]
      [StructLayout(LayoutKind.Sequential, Size = 20)]
      internal struct AttrInfo
      {
      }
    }
  }
}
