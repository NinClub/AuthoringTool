// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.RomFsFileSystemArchiveReader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using std;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class RomFsFileSystemArchiveReader : IFileSystemArchiveReader, IDisposable
  {
    private unsafe RomFsFileSystemArchiveReaderImpl* m_Impl;

    internal unsafe RomFsFileSystemArchiveReader(shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage)
    {
      // ISSUE: fault handler
      try
      {
        // ISSUE: explicit constructor call
        base.\u002Ector();
        RomFsFileSystemArchiveReaderImpl* archiveReaderImplPtr1 = (RomFsFileSystemArchiveReaderImpl*) \u003CModule\u003E.@new(20U);
        RomFsFileSystemArchiveReaderImpl* archiveReaderImplPtr2;
        // ISSUE: fault handler
        try
        {
          if ((IntPtr) archiveReaderImplPtr1 != IntPtr.Zero)
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
            archiveReaderImplPtr2 = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002E\u007Bctor\u007D(archiveReaderImplPtr1, &sharedPtrNnFsIstorage);
          }
          else
            archiveReaderImplPtr2 = (RomFsFileSystemArchiveReaderImpl*) 0;
        }
        __fault
        {
          \u003CModule\u003E.delete((void*) archiveReaderImplPtr1, 20U);
        }
        this.m_Impl = archiveReaderImplPtr2;
        GC.KeepAlive((object) this);
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

    public unsafe RomFsFileSystemArchiveReader(Stream stream)
    {
      ManagedStreamStorage* managedStreamStoragePtr = (ManagedStreamStorage*) \u003CModule\u003E.@new(8U);
      ManagedStreamStorage* _Px;
      // ISSUE: fault handler
      try
      {
        if ((IntPtr) managedStreamStoragePtr != IntPtr.Zero)
        {
          *(int*) managedStreamStoragePtr = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
          // ISSUE: fault handler
          try
          {
            *(int*) managedStreamStoragePtr = (int) &\u003CModule\u003E.\u003F\u003F_7ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
            *(int*) ((IntPtr) managedStreamStoragePtr + 4) = (int) (IntPtr) GCHandle.Alloc((object) stream).ToPointer();
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) managedStreamStoragePtr);
          }
          _Px = managedStreamStoragePtr;
        }
        else
          _Px = (ManagedStreamStorage*) 0;
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) managedStreamStoragePtr, 8U);
      }
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref sharedPtrNnFsIstorage1 = 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = 0;
      \u003CModule\u003E.std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Resetp\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E(&sharedPtrNnFsIstorage1, _Px);
      // ISSUE: fault handler
      try
      {
        RomFsFileSystemArchiveReaderImpl* archiveReaderImplPtr1 = (RomFsFileSystemArchiveReaderImpl*) \u003CModule\u003E.@new(20U);
        RomFsFileSystemArchiveReaderImpl* archiveReaderImplPtr2;
        // ISSUE: fault handler
        try
        {
          if ((IntPtr) archiveReaderImplPtr1 != IntPtr.Zero)
          {
            shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage2;
            shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = &sharedPtrNnFsIstorage2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ref sharedPtrNnFsIstorage2 = 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &sharedPtrNnFsIstorage2 + 4) = 0;
            \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u003E((_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) &sharedPtrNnFsIstorage2, (_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) &sharedPtrNnFsIstorage1);
            archiveReaderImplPtr2 = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002E\u007Bctor\u007D(archiveReaderImplPtr1, &sharedPtrNnFsIstorage2);
          }
          else
            archiveReaderImplPtr2 = (RomFsFileSystemArchiveReaderImpl*) 0;
        }
        __fault
        {
          \u003CModule\u003E.delete((void*) archiveReaderImplPtr1, 20U);
        }
        this.m_Impl = archiveReaderImplPtr2;
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
      if (^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) == 0)
        return;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4));
    }

    private void \u007ERomFsFileSystemArchiveReader()
    {
      this.\u0021RomFsFileSystemArchiveReader();
    }

    private unsafe void \u0021RomFsFileSystemArchiveReader()
    {
      RomFsFileSystemArchiveReaderImpl* impl = this.m_Impl;
      if ((IntPtr) impl == IntPtr.Zero)
        return;
      \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002E\u007Bdtor\u007D(impl);
      \u003CModule\u003E.delete((void*) impl, 20U);
    }

    public virtual unsafe List<Tuple<string, long>> ListFileInfo(string rootPath)
    {
      List<Tuple<string, long>> tupleList = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfo((FileSystemArchiveReaderImplBase*) this.m_Impl, rootPath);
      GC.KeepAlive((object) this);
      return tupleList;
    }

    public virtual unsafe List<Tuple<string, long>> ListFileInfo()
    {
      List<Tuple<string, long>> tupleList = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfo((FileSystemArchiveReaderImplBase*) this.m_Impl, string.Empty);
      GC.KeepAlive((object) this);
      return tupleList;
    }

    public virtual unsafe List<Tuple<long, long>> GetFileFragmentList(string fileName)
    {
      List<Tuple<long, long>> fileFragmentList = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002EGetFileFragmentList(this.m_Impl, fileName);
      GC.KeepAlive((object) this);
      return fileFragmentList;
    }

    public virtual unsafe long GetFileSize(string fileName)
    {
      long fileSize = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetFileSize((FileSystemArchiveReaderImplBase*) this.m_Impl, fileName);
      GC.KeepAlive((object) this);
      return fileSize;
    }

    public virtual unsafe byte[] ReadFile(string fileName, long offset, long size)
    {
      byte[] numArray = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EReadFile((FileSystemArchiveReaderImplBase*) this.m_Impl, fileName, offset, size);
      GC.KeepAlive((object) this);
      return numArray;
    }

    public virtual unsafe long GetBaseSize()
    {
      long baseSize = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetBaseSize((FileSystemArchiveReaderImplBase*) this.m_Impl);
      GC.KeepAlive((object) this);
      return baseSize;
    }

    public virtual unsafe byte[] ReadBase(long offset, long size)
    {
      byte[] numArray = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EReadBase((FileSystemArchiveReaderImplBase*) this.m_Impl, offset, size);
      GC.KeepAlive((object) this);
      return numArray;
    }

    [HandleProcessCorruptedStateExceptions]
    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u007ERomFsFileSystemArchiveReader();
      }
      else
      {
        try
        {
          this.\u0021RomFsFileSystemArchiveReader();
        }
        finally
        {
          // ISSUE: explicit finalizer call
          base.Finalize();
        }
      }
    }

    public virtual void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    ~RomFsFileSystemArchiveReader()
    {
      this.Dispose(false);
    }
  }
}
