// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentArchiveReader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn.fssystem;
using std;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoContentArchiveReader : IDisposable
  {
    private unsafe NintendoContentArchiveReaderImpl* m_Impl;

    internal unsafe NintendoContentArchiveReader(shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage, byte[][] key)
    {
      // ISSUE: fault handler
      try
      {
        // ISSUE: explicit constructor call
        base.\u002Ector();
        NintendoContentArchiveReaderImpl* archiveReaderImplPtr1 = (NintendoContentArchiveReaderImpl*) \u003CModule\u003E.@new(380U);
        NintendoContentArchiveReaderImpl* archiveReaderImplPtr2;
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
            archiveReaderImplPtr2 = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002E\u007Bctor\u007D(archiveReaderImplPtr1, &sharedPtrNnFsIstorage, key);
          }
          else
            archiveReaderImplPtr2 = (NintendoContentArchiveReaderImpl*) 0;
        }
        __fault
        {
          \u003CModule\u003E.delete((void*) archiveReaderImplPtr1, 380U);
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

    public unsafe NintendoContentArchiveReader(Stream stream, byte[][] key)
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
        NintendoContentArchiveReaderImpl* archiveReaderImplPtr1 = (NintendoContentArchiveReaderImpl*) \u003CModule\u003E.@new(380U);
        NintendoContentArchiveReaderImpl* archiveReaderImplPtr2;
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
            archiveReaderImplPtr2 = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002E\u007Bctor\u007D(archiveReaderImplPtr1, &sharedPtrNnFsIstorage2, key);
          }
          else
            archiveReaderImplPtr2 = (NintendoContentArchiveReaderImpl*) 0;
        }
        __fault
        {
          \u003CModule\u003E.delete((void*) archiveReaderImplPtr1, 380U);
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

    private void \u007ENintendoContentArchiveReader()
    {
      this.\u0021NintendoContentArchiveReader();
    }

    private unsafe void \u0021NintendoContentArchiveReader()
    {
      NintendoContentArchiveReaderImpl* impl = this.m_Impl;
      if ((IntPtr) impl == IntPtr.Zero)
        return;
      uint num = (uint) *(int*) ((IntPtr) impl + 4);
      if (num != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
      \u003CModule\u003E.delete((void*) impl, 380U);
    }

    public unsafe List<Tuple<int, long>> ListFsInfo()
    {
      List<Tuple<int, long>> tupleList = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EListFsInfo(this.m_Impl);
      GC.KeepAlive((object) this);
      return tupleList;
    }

    public unsafe byte GetDistributionType()
    {
      byte distributionType = (byte) \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetDistributionType((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return distributionType;
    }

    public unsafe byte GetContentType()
    {
      byte contentType = (byte) \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetContentType((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return contentType;
    }

    public unsafe byte GetKeyGeneration()
    {
      byte keyGeneration = \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetKeyGeneration((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return keyGeneration;
    }

    public unsafe byte GetKeyIndex()
    {
      byte keyIndex = \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetKeyIndex((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return keyIndex;
    }

    public unsafe ulong GetProgramId()
    {
      long programId = (long) \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetProgramId((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return (ulong) programId;
    }

    public unsafe uint GetContentIndex()
    {
      int contentIndex = (int) \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetContentIndex((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return (uint) contentIndex;
    }

    public unsafe uint GetSdkAddonVersion()
    {
      int sdkAddonVersion = (int) \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetSdkAddonVersion((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return (uint) sdkAddonVersion;
    }

    public unsafe int GetFsCount()
    {
      int fsCount = \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetFsCount((NcaReader*) *(int*) this.m_Impl);
      GC.KeepAlive((object) this);
      return fsCount;
    }

    public unsafe IFileSystemArchiveReader OpenFileSystemArchiveReader(int index, ref NintendoContentArchiveFsHeaderInfo fsInfo)
    {
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref sharedPtrNnFsIstorage1 = 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = 0;
      PartitionFileSystemArchiveReader systemArchiveReader1;
      // ISSUE: fault handler
      try
      {
        NcaFsHeaderReader ncaFsHeaderReader;
        \u003CModule\u003E.nn\u002Efssystem\u002ENcaFsHeaderReader\u002E\u007Bctor\u007D(&ncaFsHeaderReader);
        \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EOpenStorage(this.m_Impl, &sharedPtrNnFsIstorage1, &ncaFsHeaderReader, index);
        fsInfo = new NintendoContentArchiveFsHeaderInfo(&ncaFsHeaderReader);
        switch (\u003CModule\u003E.nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetFsType(&ncaFsHeaderReader))
        {
          case (NcaFsHeader.FsType) 0:
            goto label_8;
          case (NcaFsHeader.FsType) 1:
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
            systemArchiveReader1 = new PartitionFileSystemArchiveReader(&sharedPtrNnFsIstorage2);
            GC.KeepAlive((object) this);
            break;
          default:
            ArgumentException argumentException = new ArgumentException(string.Format("Invalid FsType."));
            GC.KeepAlive((object) this);
            throw argumentException;
        }
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
      return (IFileSystemArchiveReader) systemArchiveReader1;
label_8:
      RomFsFileSystemArchiveReader systemArchiveReader2;
      // ISSUE: fault handler
      try
      {
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
        systemArchiveReader2 = new RomFsFileSystemArchiveReader(&sharedPtrNnFsIstorage2);
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
      return (IFileSystemArchiveReader) systemArchiveReader2;
    }

    public IFileSystemArchiveReader OpenFileSystemArchiveReader(int index)
    {
      NintendoContentArchiveFsHeaderInfo fsInfo = (NintendoContentArchiveFsHeaderInfo) null;
      IFileSystemArchiveReader systemArchiveReader = this.OpenFileSystemArchiveReader(index, ref fsInfo);
      GC.KeepAlive((object) this);
      return systemArchiveReader;
    }

    [HandleProcessCorruptedStateExceptions]
    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u0021NintendoContentArchiveReader();
      }
      else
      {
        try
        {
          this.\u0021NintendoContentArchiveReader();
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

    ~NintendoContentArchiveReader()
    {
      this.Dispose(false);
    }
  }
}
