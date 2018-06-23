// Decompiled with JetBrains decompiler
// Type: nn.fs.HierarchicalRomFileTable
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nn.fs
{
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 176)]
  internal struct HierarchicalRomFileTable
  {
    [CLSCompliant(false)]
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct FindPosition
    {
    }

    [UnsafeValueType]
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    internal struct DirectoryRomEntry
    {
    }

    [UnsafeValueType]
    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 20)]
    internal struct FileRomEntry
    {
    }

    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    internal struct RomEntryKey
    {
    }

    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    internal struct EntryKey
    {
    }

    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 88)]
    internal struct EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AHierarchicalRomFileTable\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afs\u003A\u003AHierarchicalRomFileTable\u003A\u003AEntryKey\u002Cnn\u003A\u003Afs\u003A\u003AHierarchicalRomFileTable\u003A\u003ADirectoryRomEntry\u003E
    {
    }

    [NativeCppClass]
    [StructLayout(LayoutKind.Sequential, Size = 88)]
    internal struct EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AHierarchicalRomFileTable\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afs\u003A\u003AHierarchicalRomFileTable\u003A\u003AEntryKey\u002Cnn\u003A\u003Afs\u003A\u003AHierarchicalRomFileTable\u003A\u003AFileRomEntry\u003E
    {
    }
  }
}
