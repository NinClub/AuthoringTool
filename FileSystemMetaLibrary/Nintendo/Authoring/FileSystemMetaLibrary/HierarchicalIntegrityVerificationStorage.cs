// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.HierarchicalIntegrityVerificationStorage
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn;
using nn.fs;
using nn.fssystem;
using nn.fssystem.save;
using std;
using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class HierarchicalIntegrityVerificationStorage : IDisposable
  {
    public unsafe HierarchicalIntegrityVerificationMetaInformation* m_pMetaInfo = (HierarchicalIntegrityVerificationMetaInformation*) 0;
    public unsafe HierarchicalIntegrityVerificationInformation* m_pInfoLevelHash = (HierarchicalIntegrityVerificationInformation*) 0;
    public unsafe IntegrityRomFsStorage* m_pIntegrityRomFsStorage = (IntegrityRomFsStorage*) 0;
    public unsafe FileSystemBufferManager* m_pBufferManager = (FileSystemBufferManager*) 0;
    public unsafe SubStorage* m_pHashStorage = (SubStorage*) 0;
    public unsafe SubStorage* m_pDummyStorage = (SubStorage*) 0;
    public unsafe RomFsStorage* m_pHashStorageBuffer = (RomFsStorage*) 0;
    public unsafe DummyStorage* m_pDummyStorageBuffer = (DummyStorage*) 0;

    static unsafe HierarchicalIntegrityVerificationStorage()
    {
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorage\u002ESetGenerateRandomFunction((__FnPtr<void (void*, uint)>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003FGenerateRandomForAuthoringTool\u0040\u003FA0x9604d1c5\u0040\u0040\u0024\u0024FYAXPAXI\u0040Z);
      \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EEnsureBufferPool();
    }

    private void \u007EHierarchicalIntegrityVerificationStorage()
    {
      this.\u0021HierarchicalIntegrityVerificationStorage();
    }

    private unsafe void \u0021HierarchicalIntegrityVerificationStorage()
    {
      \u003CModule\u003E.delete((void*) this.m_pMetaInfo, 192U);
      \u003CModule\u003E.delete((void*) this.m_pInfoLevelHash, 180U);
      IntegrityRomFsStorage* integrityRomFsStorage = this.m_pIntegrityRomFsStorage;
      if ((IntPtr) integrityRomFsStorage != IntPtr.Zero)
      {
        IntegrityRomFsStorage* integrityRomFsStoragePtr = integrityRomFsStorage;
        int num = 1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) integrityRomFsStorage)((uint) integrityRomFsStoragePtr, (IntPtr) num);
      }
      FileSystemBufferManager* pBufferManager = this.m_pBufferManager;
      if ((IntPtr) pBufferManager != IntPtr.Zero)
      {
        FileSystemBufferManager* systemBufferManagerPtr = pBufferManager;
        int num = 1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) pBufferManager)((uint) systemBufferManagerPtr, (IntPtr) num);
      }
      SubStorage* pHashStorage = this.m_pHashStorage;
      if ((IntPtr) pHashStorage != IntPtr.Zero)
      {
        SubStorage* subStoragePtr = pHashStorage;
        int num = 1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) pHashStorage)((uint) subStoragePtr, (IntPtr) num);
      }
      SubStorage* pDummyStorage = this.m_pDummyStorage;
      if ((IntPtr) pDummyStorage != IntPtr.Zero)
      {
        SubStorage* subStoragePtr = pDummyStorage;
        int num = 1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) pDummyStorage)((uint) subStoragePtr, (IntPtr) num);
      }
      RomFsStorage* hashStorageBuffer = this.m_pHashStorageBuffer;
      if ((IntPtr) hashStorageBuffer != IntPtr.Zero)
      {
        RomFsStorage* romFsStoragePtr = hashStorageBuffer;
        int num = 1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) hashStorageBuffer)((uint) romFsStoragePtr, (IntPtr) num);
      }
      DummyStorage* dummyStorageBuffer = this.m_pDummyStorageBuffer;
      if ((IntPtr) dummyStorageBuffer == IntPtr.Zero)
        return;
      DummyStorage* dummyStoragePtr = dummyStorageBuffer;
      int num1 = 1;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      void* voidPtr1 = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) dummyStorageBuffer)((uint) dummyStoragePtr, (IntPtr) num1);
    }

    public unsafe void Initialize(long sizeStorage)
    {
      IntegrityRomFsStorage* integrityRomFsStoragePtr = (IntegrityRomFsStorage*) \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EAllocate(1440U);
      this.m_pIntegrityRomFsStorage = (IntPtr) integrityRomFsStoragePtr == IntPtr.Zero ? (IntegrityRomFsStorage*) 0 : \u003CModule\u003E.nn\u002Efssystem\u002EIntegrityRomFsStorage\u002E\u007Bctor\u007D(integrityRomFsStoragePtr);
      int num1 = 0;
      HierarchicalIntegrityVerificationStorageControlArea.InputParam inputParam;
      do
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) (num1 * 4 + (IntPtr) &inputParam) = 16384;
        ++num1;
      }
      while (num1 < 6);
      HierarchicalIntegrityVerificationStorageControlArea storageControlArea;
      \u003CModule\u003E.nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D((SubStorage*) &storageControlArea);
      // ISSUE: fault handler
      try
      {
        Result result1;
        HierarchicalIntegrityVerificationSizeSet verificationSizeSet;
        \u003CModule\u003E.nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002EQuerySize(&result1, &verificationSizeSet, &inputParam, 7, sizeStorage);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        long bufferSize = ^(long&) ((IntPtr) &verificationSizeSet + 8) + ^(long&) ref verificationSizeSet;
        int num2 = 0;
        do
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          bufferSize += ^(long&) (num2 * 8 + ((IntPtr) &verificationSizeSet + 16));
          ++num2;
        }
        while (num2 < 5);
        RomFsStorage* romFsStoragePtr = (RomFsStorage*) \u003CModule\u003E.@new(24U);
        this.m_pHashStorageBuffer = (IntPtr) romFsStoragePtr == IntPtr.Zero ? (RomFsStorage*) 0 : \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002E\u007Bctor\u007D(romFsStoragePtr, bufferSize);
        SubStorage* subStoragePtr1 = (SubStorage*) \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EAllocate(32U);
        SubStorage* subStoragePtr2;
        if ((IntPtr) subStoragePtr1 != IntPtr.Zero)
        {
          IStorage* hashStorageBuffer = (IStorage*) this.m_pHashStorageBuffer;
          *(int*) subStoragePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
          // ISSUE: fault handler
          try
          {
            *(int*) subStoragePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7SubStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
            *(int*) ((IntPtr) subStoragePtr1 + 4) = (int) hashStorageBuffer;
            *(long*) ((IntPtr) subStoragePtr1 + 8) = 0L;
            *(long*) ((IntPtr) subStoragePtr1 + 16) = bufferSize;
            shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) subStoragePtr1 + 24);
            *(int*) sharedPtrNnFsIstoragePtr = 0;
            *(int*) ((IntPtr) sharedPtrNnFsIstoragePtr + 4) = 0;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) subStoragePtr1);
          }
          subStoragePtr2 = subStoragePtr1;
        }
        else
          subStoragePtr2 = (SubStorage*) 0;
        this.m_pHashStorage = subStoragePtr2;
        DummyStorage* dummyStoragePtr1 = (DummyStorage*) \u003CModule\u003E.@new(16U);
        DummyStorage* dummyStoragePtr2;
        if ((IntPtr) dummyStoragePtr1 != IntPtr.Zero)
        {
          *(int*) dummyStoragePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
          // ISSUE: fault handler
          try
          {
            *(int*) dummyStoragePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
            *(int*) ((IntPtr) dummyStoragePtr1 + 4) = 0;
            *(long*) ((IntPtr) dummyStoragePtr1 + 8) = sizeStorage;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) dummyStoragePtr1);
          }
          dummyStoragePtr2 = dummyStoragePtr1;
        }
        else
          dummyStoragePtr2 = (DummyStorage*) 0;
        this.m_pDummyStorageBuffer = dummyStoragePtr2;
        SubStorage* subStoragePtr3 = (SubStorage*) \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EAllocate(32U);
        SubStorage* subStoragePtr4;
        if ((IntPtr) subStoragePtr3 != IntPtr.Zero)
        {
          IStorage* dummyStorageBuffer = (IStorage*) this.m_pDummyStorageBuffer;
          *(int*) subStoragePtr3 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
          // ISSUE: fault handler
          try
          {
            *(int*) subStoragePtr3 = (int) &\u003CModule\u003E.\u003F\u003F_7SubStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
            *(int*) ((IntPtr) subStoragePtr3 + 4) = (int) dummyStorageBuffer;
            *(long*) ((IntPtr) subStoragePtr3 + 8) = 0L;
            *(long*) ((IntPtr) subStoragePtr3 + 16) = sizeStorage;
            shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) subStoragePtr3 + 24);
            *(int*) sharedPtrNnFsIstoragePtr = 0;
            *(int*) ((IntPtr) sharedPtrNnFsIstoragePtr + 4) = 0;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) subStoragePtr3);
          }
          subStoragePtr4 = subStoragePtr3;
        }
        else
          subStoragePtr4 = (SubStorage*) 0;
        this.m_pDummyStorage = subStoragePtr4;
        long num3 = 0;
        HierarchicalIntegrityVerificationMetaInformation* verificationMetaInformationPtr1 = (HierarchicalIntegrityVerificationMetaInformation*) \u003CModule\u003E.@new(192U);
        HierarchicalIntegrityVerificationMetaInformation* verificationMetaInformationPtr2;
        if ((IntPtr) verificationMetaInformationPtr1 != IntPtr.Zero)
        {
          // ISSUE: initblk instruction
          __memset((IntPtr) verificationMetaInformationPtr1, 0, 192);
          verificationMetaInformationPtr2 = verificationMetaInformationPtr1;
        }
        else
          verificationMetaInformationPtr2 = (HierarchicalIntegrityVerificationMetaInformation*) 0;
        this.m_pMetaInfo = verificationMetaInformationPtr2;
        \u003CModule\u003E.nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationMetaInformation\u002EFormat(verificationMetaInformationPtr2);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) ((IntPtr) this.m_pMetaInfo + 8) = (int) ^(long&) ((IntPtr) &verificationSizeSet + 8);
        nn.fs.Int64* int64Ptr1 = (nn.fs.Int64*) ((IntPtr) this.m_pMetaInfo + 144);
        *(int*) int64Ptr1 = (int) sizeStorage;
        *(int*) ((IntPtr) int64Ptr1 + 4) = (int) (uint) ((ulong) sizeStorage >> 32);
        *(int*) ((IntPtr) this.m_pMetaInfo + 12) = 7;
        int num4 = 0;
        HierarchicalIntegrityVerificationStorageControlArea.InputParam* inputParamPtr = &inputParam;
        int num5 = (int) ((IntPtr) &verificationSizeSet + 16);
        do
        {
          long num6 = *(long*) num5;
          nn.fs.Int64* int64Ptr2 = (nn.fs.Int64*) (num4 + (IntPtr) this.m_pMetaInfo + 16);
          *(int*) int64Ptr2 = (int) num3;
          *(int*) ((IntPtr) int64Ptr2 + 4) = (int) (uint) ((ulong) num3 >> 32);
          nn.fs.Int64* int64Ptr3 = (nn.fs.Int64*) (num4 + (IntPtr) this.m_pMetaInfo + 24);
          *(int*) int64Ptr3 = (int) num6;
          *(int*) ((IntPtr) int64Ptr3 + 4) = (int) (uint) ((ulong) num6 >> 32);
          uint num7 = (uint) (31 - \u003CModule\u003E.nn\u002Eutil\u002Ecntl0\u003Cunsigned\u0020int\u003E((uint) *(int*) inputParamPtr));
          *(int*) (num4 + (IntPtr) this.m_pMetaInfo + 32) = (int) num7;
          num3 += num6;
          num5 += 8;
          inputParamPtr += 4;
          num4 += 24;
        }
        while (num4 < 120);
        nn.fs.Int64* int64Ptr4 = (nn.fs.Int64*) ((IntPtr) this.m_pMetaInfo + 136);
        *(int*) int64Ptr4 = (int) num3;
        *(int*) ((IntPtr) int64Ptr4 + 4) = (int) (uint) ((ulong) num3 >> 32);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) ((IntPtr) this.m_pMetaInfo + 152) = 31 - \u003CModule\u003E.nn\u002Eutil\u002Ecntl0\u003Cunsigned\u0020int\u003E((uint) ^(int&) ((IntPtr) &inputParam + 20));
        SubStorage subStorage1;
        SubStorage* subStoragePtr5 = &subStorage1;
        SubStorage* subStoragePtr6 = \u003CModule\u003E.nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D(&subStorage1, this.m_pHashStorage);
        HierarchicalIntegrityVerificationMetaInformation* pMetaInfo;
        // ISSUE: fault handler
        try
        {
          pMetaInfo = this.m_pMetaInfo;
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002ESubStorage\u002E\u007Bdtor\u007D), (void*) subStoragePtr5);
        }
        Result result2;
        \u003CModule\u003E.nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002EFormat(&result2, subStoragePtr6, pMetaInfo);
        byte* numPtr = (byte*) \u003CModule\u003E.new\u005B\u005D(4194304U);
        FileSystemBufferManager* systemBufferManagerPtr1 = (FileSystemBufferManager*) \u003CModule\u003E.@new(144U);
        FileSystemBufferManager* systemBufferManagerPtr2 = (IntPtr) systemBufferManagerPtr1 == IntPtr.Zero ? (FileSystemBufferManager*) 0 : \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002E\u007Bctor\u007D(systemBufferManagerPtr1);
        this.m_pBufferManager = systemBufferManagerPtr2;
        Result result3;
        \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002EInitialize(systemBufferManagerPtr2, &result3, 1024, (uint) numPtr, 4194304U, 4096U);
        SubStorage subStorage2;
        SubStorage* subStoragePtr7 = &subStorage2;
        SubStorage* subStoragePtr8 = \u003CModule\u003E.nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D(&subStorage2, this.m_pDummyStorage);
        SubStorage* subStoragePtr9;
        IntegrityRomFsStorage* integrityRomFsStorage;
        FileSystemBufferManager* pBufferManager;
        // ISSUE: fault handler
        try
        {
          SubStorage subStorage3;
          SubStorage* subStoragePtr10 = &subStorage3;
          subStoragePtr9 = \u003CModule\u003E.nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D(&subStorage3, this.m_pHashStorage);
          // ISSUE: fault handler
          try
          {
            integrityRomFsStorage = this.m_pIntegrityRomFsStorage;
            pBufferManager = this.m_pBufferManager;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002ESubStorage\u002E\u007Bdtor\u007D), (void*) subStoragePtr10);
          }
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002ESubStorage\u002E\u007Bdtor\u007D), (void*) subStoragePtr7);
        }
        Result result4;
        \u003CModule\u003E.nn\u002Efssystem\u002EIntegrityRomFsStorage\u002EInitialize(integrityRomFsStorage, &result4, subStoragePtr9, subStoragePtr8, (IBufferManager*) pBufferManager);
        SubStorage subStorage4;
        SubStorage* subStoragePtr11 = &subStorage4;
        SubStorage* subStoragePtr12 = \u003CModule\u003E.nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D(&subStorage4, this.m_pHashStorage);
        Result result5;
        \u003CModule\u003E.nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002EInitialize(&storageControlArea, &result5, subStoragePtr12);
        HierarchicalIntegrityVerificationInformation* verificationInformationPtr1 = (HierarchicalIntegrityVerificationInformation*) \u003CModule\u003E.@new(180U);
        HierarchicalIntegrityVerificationInformation* verificationInformationPtr2;
        if ((IntPtr) verificationInformationPtr1 != IntPtr.Zero)
        {
          // ISSUE: initblk instruction
          __memset((IntPtr) verificationInformationPtr1, 0, 180);
          verificationInformationPtr2 = verificationInformationPtr1;
        }
        else
          verificationInformationPtr2 = (HierarchicalIntegrityVerificationInformation*) 0;
        this.m_pInfoLevelHash = verificationInformationPtr2;
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) verificationInformationPtr2, (HierarchicalIntegrityVerificationStorageControlArea&) ((IntPtr) &storageControlArea + 44), 180);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002E\u007Bdtor\u007D), (void*) &storageControlArea);
      }
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ((IntPtr) &storageControlArea + 28) == 0)
          return;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &storageControlArea + 28));
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) &storageControlArea);
      }
    }

    public unsafe void Read(long offset, byte[] data)
    {
      fixed (byte* numPtr = &data[0])
      {
        IntegrityRomFsStorage* integrityRomFsStorage = this.m_pIntegrityRomFsStorage;
        IntegrityRomFsStorage* integrityRomFsStoragePtr = integrityRomFsStorage;
        Result result;
        ref Result local1 = ref result;
        long num = offset;
        // ISSUE: cast to a reference type
        // ISSUE: variable of a reference type
        byte* local2 = (byte*) numPtr;
        int length = data.GetLength(0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) integrityRomFsStorage + 4))((uint) integrityRomFsStoragePtr, (void*) ref local1, num, (Result*) local2, (IntPtr) length);
      }
    }

    public unsafe void Write(long offset, byte[] data)
    {
      fixed (byte* numPtr = &data[0])
      {
        IntegrityRomFsStorage* integrityRomFsStorage = this.m_pIntegrityRomFsStorage;
        IntegrityRomFsStorage* integrityRomFsStoragePtr = integrityRomFsStorage;
        Result result;
        ref Result local1 = ref result;
        long num = offset;
        // ISSUE: cast to a reference type
        // ISSUE: variable of a reference type
        byte* local2 = (byte*) numPtr;
        int length = data.GetLength(0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) integrityRomFsStorage + 8))((uint) integrityRomFsStoragePtr, (void*) ref local1, num, (Result*) local2, (IntPtr) length);
      }
    }

    public unsafe void Commit()
    {
      Result result;
      \u003CModule\u003E.nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorage\u002ECommit((nn.fssystem.save.HierarchicalIntegrityVerificationStorage*) ((IntPtr) this.m_pIntegrityRomFsStorage + 8), &result);
    }

    public static int GetHashBlockSize()
    {
      return 16384;
    }

    public static int GetMetaInfoSize()
    {
      return 192;
    }

    public unsafe uint GetMasterHashSize()
    {
      return (uint) *(int*) ((IntPtr) this.m_pMetaInfo + 8);
    }

    public unsafe long GetLayerHashSize()
    {
      HierarchicalIntegrityVerificationInformation* pInfoLevelHash = this.m_pInfoLevelHash;
      int num = *(int*) pInfoLevelHash * 24;
      nn.fs.Int64* int64Ptr = (nn.fs.Int64*) ((IntPtr) pInfoLevelHash + num - 44);
      return (long) (uint) *(int*) ((IntPtr) int64Ptr + 4) << 32 | (long) (uint) *(int*) int64Ptr;
    }

    public unsafe long GetBodySize()
    {
      HierarchicalIntegrityVerificationInformation* pInfoLevelHash = this.m_pInfoLevelHash;
      int num = *(int*) pInfoLevelHash * 24;
      nn.fs.Int64* int64Ptr = (nn.fs.Int64*) ((IntPtr) pInfoLevelHash + num - 36);
      return (long) (uint) *(int*) ((IntPtr) int64Ptr + 4) << 32 | (long) (uint) *(int*) int64Ptr;
    }

    public unsafe byte[] GetMetaInfo()
    {
      byte[] numArray = new byte[192];
      fixed (byte* numPtr = &numArray[0])
      {
        SubStorage* pHashStorage = this.m_pHashStorage;
        SubStorage* subStoragePtr = pHashStorage;
        Result result;
        ref Result local1 = ref result;
        long num1 = 0;
        // ISSUE: cast to a reference type
        // ISSUE: variable of a reference type
        byte* local2 = (byte*) numPtr;
        int num2 = 192;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) pHashStorage + 4))((uint) subStoragePtr, (void*) ref local1, num1, (Result*) local2, (IntPtr) num2);
        return numArray;
      }
    }

    public unsafe byte[] GetMasterHash()
    {
      long num1 = (long) (uint) *(int*) ((IntPtr) this.m_pMetaInfo + 8);
      byte[] numArray = new byte[(int) num1];
      fixed (byte* numPtr = &numArray[0])
      {
        SubStorage* pHashStorage = this.m_pHashStorage;
        SubStorage* subStoragePtr = pHashStorage;
        Result result;
        ref Result local1 = ref result;
        long num2 = 192;
        // ISSUE: cast to a reference type
        // ISSUE: variable of a reference type
        byte* local2 = (byte*) numPtr;
        int num3 = (int) num1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) pHashStorage + 4))((uint) subStoragePtr, (void*) ref local1, num2, (Result*) local2, (IntPtr) num3);
        return numArray;
      }
    }

    public unsafe byte[] GetLayerHash(long offset, long size)
    {
      HierarchicalIntegrityVerificationInformation* pInfoLevelHash = this.m_pInfoLevelHash;
      HierarchicalIntegrityVerificationInformation* verificationInformationPtr1 = pInfoLevelHash;
      int num1 = *(int*) verificationInformationPtr1 * 24;
      nn.fs.Int64* int64Ptr1 = (nn.fs.Int64*) ((IntPtr) verificationInformationPtr1 + num1 - 44);
      long num2;
      if (offset + size > ((long) (uint) *(int*) ((IntPtr) int64Ptr1 + 4) << 32 | (long) (uint) *(int*) int64Ptr1))
      {
        HierarchicalIntegrityVerificationInformation* verificationInformationPtr2 = pInfoLevelHash;
        int num3 = *(int*) verificationInformationPtr2 * 24;
        nn.fs.Int64* int64Ptr2 = (nn.fs.Int64*) ((IntPtr) verificationInformationPtr2 + num3 - 44);
        num2 = ((long) (uint) *(int*) ((IntPtr) int64Ptr2 + 4) << 32 | (long) (uint) *(int*) int64Ptr2) - offset;
      }
      else
        num2 = size;
      long num4 = (long) (uint) (*(int*) ((IntPtr) this.m_pMetaInfo + 8) + 192) + offset;
      byte[] numArray = new byte[(int) num2];
      fixed (byte* numPtr = &numArray[0])
      {
        SubStorage* pHashStorage = this.m_pHashStorage;
        SubStorage* subStoragePtr = pHashStorage;
        Result result;
        ref Result local1 = ref result;
        long num3 = num4;
        // ISSUE: cast to a reference type
        // ISSUE: variable of a reference type
        byte* local2 = (byte*) numPtr;
        int num5 = (int) num2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) pHashStorage + 4))((uint) subStoragePtr, (void*) ref local1, num3, (Result*) local2, (IntPtr) num5);
        return numArray;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u0021HierarchicalIntegrityVerificationStorage();
      }
      else
      {
        try
        {
          this.\u0021HierarchicalIntegrityVerificationStorage();
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

    ~HierarchicalIntegrityVerificationStorage()
    {
      this.Dispose(false);
    }
  }
}
