// Decompiled with JetBrains decompiler
// Type: nn.fssystem.save.IntegrityVerificationStorage
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nn.fssystem.save
{
  [UnsafeValueType]
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 152)]
  internal struct IntegrityVerificationStorage
  {
    [UnsafeValueType]
    [CLSCompliant(false)]
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct SignatureSalt
    {
    }

    [UnsafeValueType]
    [NativeCppClass]
    [CLSCompliant(false)]
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct BlockSignature
    {
    }

    [CLSCompliant(false)]
    [NativeCppClass]
    public enum StorageType
    {
    }
  }
}
