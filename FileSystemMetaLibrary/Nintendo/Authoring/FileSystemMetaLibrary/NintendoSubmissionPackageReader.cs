// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoSubmissionPackageReader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using std;
using System;
using System.IO;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoSubmissionPackageReader : PartitionFileSystemArchiveReader
  {
    public NintendoSubmissionPackageReader(Stream stream)
      : base(stream)
    {
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
