// Decompiled with JetBrains decompiler
// Type: std.basic_string<char,std::char_traits<char>,std::allocator<char> >
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace std
{
  [UnsafeValueType]
  [NativeCppClass]
  [StructLayout(LayoutKind.Sequential, Size = 24)]
  internal struct basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E
  {
    [SpecialName]
    public static unsafe void \u003CMarshalCopy\u003E(basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* A_0, basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* A_1)
    {
      // ISSUE: fault handler
      try
      {
        *(int*) ((IntPtr) A_0 + 16) = 0;
        *(int*) ((IntPtr) A_0 + 20) = 0;
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) A_0);
      }
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(A_0, false, 0U);
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eassign(A_0, A_1, 0U, uint.MaxValue);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) A_0);
      }
    }

    [SpecialName]
    public static unsafe void \u003CMarshalDestroy\u003E(basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* A_0)
    {
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(A_0, true, 0U);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) A_0);
      }
    }
  }
}
