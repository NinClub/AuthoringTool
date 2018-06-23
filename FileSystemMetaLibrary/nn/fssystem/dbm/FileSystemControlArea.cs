// Decompiled with JetBrains decompiler
// Type: nn.fssystem.dbm.FileSystemControlArea
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nn.fssystem.dbm
{
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 32)]
  internal struct FileSystemControlArea
  {
    [UnsafeValueType]
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    internal struct StorageInfo
    {
    }

    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    internal struct AllocationInfo
    {
    }

    [CLSCompliant(false)]
    [UnsafeValueType]
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 48)]
    public struct ControlArea
    {
    }
  }
}
