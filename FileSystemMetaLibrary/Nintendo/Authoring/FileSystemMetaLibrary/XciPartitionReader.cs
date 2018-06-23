// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.XciPartitionReader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using std;
using System;
using System.IO;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class XciPartitionReader : Sha256PartitionFileSystemArchiveReader
  {
    internal unsafe XciPartitionReader(shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage)
    {
      // ISSUE: fault handler
      try
      {
        shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage;
        shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = &sharedPtrNnFsIstorage;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) = 0;
        \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u003E((_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) &sharedPtrNnFsIstorage, (_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) storage);
        // ISSUE: explicit constructor call
        base.\u002Ector(&sharedPtrNnFsIstorage);
        // ISSUE: fault handler
        try
        {
          GC.KeepAlive((object) this);
        }
        __fault
        {
          this.Dispose(true);
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) storage);
      }
      uint num = (uint) *(int*) ((IntPtr) storage + 4);
      if (num == 0U)
        return;
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }

    public XciPartitionReader(Stream stream)
      : base(stream)
    {
      // ISSUE: fault handler
      try
      {
        GC.KeepAlive((object) this);
      }
      __fault
      {
        this.Dispose(true);
      }
    }

    public unsafe NintendoContentArchiveReader OpenNintendoContentArchiveReader(string fileName, byte[][] key)
    {
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref sharedPtrNnFsIstorage1 = 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = 0;
      NintendoContentArchiveReader contentArchiveReader;
      // ISSUE: fault handler
      try
      {
        this.OpenFileStorage(&sharedPtrNnFsIstorage1, fileName);
        shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage2;
        shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = &sharedPtrNnFsIstorage2;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage2 = ^(int&) ref sharedPtrNnFsIstorage1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage2 + 4) = ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage1 = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = 0;
        contentArchiveReader = new NintendoContentArchiveReader(&sharedPtrNnFsIstorage2, key);
        GC.KeepAlive((object) this);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) &sharedPtrNnFsIstorage1);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4));
      }
      return contentArchiveReader;
    }
  }
}
