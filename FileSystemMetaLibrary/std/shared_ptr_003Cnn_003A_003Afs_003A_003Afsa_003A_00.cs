// Decompiled with JetBrains decompiler
// Type: std.shared_ptr<nn::fs::fsa::IFileSystem>
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace std
{
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 8)]
  internal struct shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E
  {
    [SpecialName]
    public static unsafe void \u003CMarshalCopy\u003E(shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* A_0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* A_1)
    {
      *(int*) A_0 = 0;
      *(int*) ((IntPtr) A_0 + 4) = 0;
      \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E((_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E*) A_0, (_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E*) A_1);
    }

    [SpecialName]
    public static unsafe void \u003CMarshalDestroy\u003E(shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* A_0)
    {
      uint num = (uint) *(int*) ((IntPtr) A_0 + 4);
      if (num == 0U)
        return;
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }
  }
}
