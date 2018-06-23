// Decompiled with JetBrains decompiler
// Type: nn.fssystem.NcaFsHeader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nn.fssystem
{
  [UnsafeValueType]
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 512)]
  internal struct NcaFsHeader
  {
    [NativeCppClass]
    [CLSCompliant(false)]
    public enum FsType : byte
    {
    }

    [NativeCppClass]
    [CLSCompliant(false)]
    public enum EncryptionType : byte
    {
    }

    [NativeCppClass]
    [CLSCompliant(false)]
    public enum HashType : byte
    {
    }

    [UnsafeValueType]
    [CLSCompliant(false)]
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct Region
    {
    }

    [UnsafeValueType]
    [CLSCompliant(false)]
    [NativeCppClass]
    [StructLayout(LayoutKind.Explicit, Size = 504)]
    public struct HashData
    {
      [UnsafeValueType]
      [NativeCppClass]
      [CLSCompliant(false)]
      [StructLayout(LayoutKind.Sequential, Size = 120)]
      public struct HierarchicalSha256Data
      {
      }

      [NativeCppClass]
      [CLSCompliant(false)]
      [UnsafeValueType]
      [StructLayout(LayoutKind.Sequential, Size = 224)]
      public struct IntegrityMetaInfo
      {
        [UnsafeValueType]
        [NativeCppClass]
        [CLSCompliant(false)]
        [StructLayout(LayoutKind.Sequential, Size = 180)]
        public struct InfoLevelHash
        {
          [CLSCompliant(false)]
          [NativeCppClass]
          [UnsafeValueType]
          [StructLayout(LayoutKind.Sequential, Size = 24)]
          public struct HierarchicalIntegrityVerificationLevelInformation
          {
          }

          [CLSCompliant(false)]
          [UnsafeValueType]
          [NativeCppClass]
          [StructLayout(LayoutKind.Sequential, Size = 32)]
          public struct SignatureSalt
          {
          }
        }
      }
    }
  }
}
