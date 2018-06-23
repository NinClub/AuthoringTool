// Decompiled with JetBrains decompiler
// Type: nn.fs.SubStorage
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using std;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nn.fs
{
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 32)]
  internal struct SubStorage
  {
    [SpecialName]
    public static unsafe void \u003CMarshalCopy\u003E(SubStorage* A_0, SubStorage* A_1)
    {
      \u003CModule\u003E.nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D(A_0, A_1);
    }

    [SpecialName]
    public static unsafe void \u003CMarshalDestroy\u003E(SubStorage* A_0)
    {
      // ISSUE: fault handler
      try
      {
        uint num = (uint) *(int*) ((IntPtr) A_0 + 24 + 4);
        if (num != 0U)
          \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) A_0);
      }
      *(int*) A_0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    }
  }
}
