// Decompiled with JetBrains decompiler
// Type: nn.fssystem.NcaHeader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nn.fssystem
{
  [NativeCppClass]
  [UnsafeValueType]
  [StructLayout(LayoutKind.Sequential, Size = 1024)]
  internal struct NcaHeader
  {
    [NativeCppClass]
    [CLSCompliant(false)]
    public enum ContentType : byte
    {
    }

    [NativeCppClass]
    [CLSCompliant(false)]
    public enum DistributionType : byte
    {
    }

    [NativeCppClass]
    [CLSCompliant(false)]
    public enum DecryptionKey
    {
    }

    [CLSCompliant(false)]
    [NativeCppClass]
    [UnsafeValueType]
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct FsInfo
    {
    }
  }
}
