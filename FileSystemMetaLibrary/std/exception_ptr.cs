// Decompiled with JetBrains decompiler
// Type: std.exception_ptr
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace std
{
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 8)]
  internal struct exception_ptr
  {
    [SpecialName]
    public static unsafe void \u003CMarshalCopy\u003E(exception_ptr* A_0, exception_ptr* A_1)
    {
      \u003CModule\u003E.__ExceptionPtrCopy((void*) A_0, (void*) A_1);
    }

    [SpecialName]
    public static unsafe void \u003CMarshalDestroy\u003E(exception_ptr* A_0)
    {
      \u003CModule\u003E.__ExceptionPtrDestroy((void*) A_0);
    }
  }
}
