// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentFileSystemMeta
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn.fssystem;
using std;
using System;
using System.Diagnostics;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoContentFileSystemMeta
  {
    public int GetIntegrityMasterHashOffset()
    {
      return \u003CModule\u003E.\u003FMasterHashOffset\u0040IntegrityMetaInfo\u0040HashData\u0040NcaFsHeader\u0040fssystem\u0040nn\u0040\u00402HB;
    }

    public int GetHierarchicalSha256MasterHashOffset()
    {
      return \u003CModule\u003E.\u003FMasterHashOffset\u0040HierarchicalSha256Data\u0040HashData\u0040NcaFsHeader\u0040fssystem\u0040nn\u0040\u00402HB;
    }

    public ulong GetHeaderSize()
    {
      return 1024;
    }

    public ulong GetFsHeaderSize()
    {
      return 512;
    }

    public int GetHashBlockSize(ValueType fsEntry)
    {
      if (((NintendoContentFileSystemInfo.EntryInfo) fsEntry).hashType != (byte) 2)
        throw new ArgumentException();
      int num1 = 4096;
      long hashTargetSize = (long) ((NintendoContentFileSystemInfo.EntryInfo) fsEntry).hashTargetSize;
      if (524288L < hashTargetSize)
      {
        while (num1 <= 1048576)
        {
          num1 <<= 1;
          long num2 = (long) num1;
          if (num2 * num2 / 32L >= hashTargetSize)
          {
            if (num1 <= 1048576)
              goto label_6;
            else
              break;
          }
        }
        throw new ArgumentException("Total size of input files is too big.");
      }
label_6:
      GC.KeepAlive((object) this);
      return num1;
    }

    public unsafe byte[] CreateNcaHeader(NintendoContentFileSystemInfo fileSystemInfo)
    {
      NcaHeader* ncaHeaderPtr1 = (NcaHeader*) \u003CModule\u003E.@new(1024U);
      NcaHeader* ncaHeaderPtr2;
      if ((IntPtr) ncaHeaderPtr1 != IntPtr.Zero)
      {
        // ISSUE: initblk instruction
        __memset((IntPtr) ncaHeaderPtr1, 0, 1024);
        ncaHeaderPtr2 = ncaHeaderPtr1;
      }
      else
        ncaHeaderPtr2 = (NcaHeader*) 0;
      unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E fssystemNcaHeader;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref fssystemNcaHeader = (int) ncaHeaderPtr2;
      byte[] numArray;
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: initblk instruction
        __memset(^(int&) ref fssystemNcaHeader, 0, 1024);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) (^(int&) ref fssystemNcaHeader + 512) = 843137870;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(sbyte*) (^(int&) ref fssystemNcaHeader + 516) = (sbyte) fileSystemInfo.distributionType;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(sbyte*) (^(int&) ref fssystemNcaHeader + 517) = (sbyte) fileSystemInfo.contentType;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(sbyte*) (^(int&) ref fssystemNcaHeader + 518) = (sbyte) fileSystemInfo.keyGeneration;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(sbyte*) (^(int&) ref fssystemNcaHeader + 519) = (sbyte) fileSystemInfo.keyAreaEncryptionKeyIndex;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(long*) (^(int&) ref fssystemNcaHeader + 520) = (long) fileSystemInfo.contentSize;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(long*) (^(int&) ref fssystemNcaHeader + 528) = (long) fileSystemInfo.programId;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) (^(int&) ref fssystemNcaHeader + 536) = (int) fileSystemInfo.contentIndex;
        uint sdkAddonVersion = fileSystemInfo.sdkAddonVersion;
        if (sdkAddonVersion != 0U)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          *(int*) (^(int&) ref fssystemNcaHeader + 540) = (int) sdkAddonVersion;
        }
        else
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          *(int*) (^(int&) ref fssystemNcaHeader + 540) = 721920;
        }
        int index = 0;
        if (0 < fileSystemInfo.numFsEntries)
        {
          do
          {
            NintendoContentFileSystemInfo.EntryInfo fsEntry = fileSystemInfo.fsEntries[index];
            int partitionIndex = fsEntry.partitionIndex;
            Debug.Assert(partitionIndex < 4);
            int num = partitionIndex * 16;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            Debug.Assert(*(int*) (^(int&) ref fssystemNcaHeader + num + 580) == 0);
            ulong startOffset = fsEntry.startOffset;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(int*) ((partitionIndex + 36) * 16 + ^(int&) ref fssystemNcaHeader) = (int) (uint) (startOffset >> 9);
            ulong endOffset = fsEntry.endOffset;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(int*) (^(int&) ref fssystemNcaHeader + num + 580) = (int) (uint) (endOffset >> 9);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(int*) (^(int&) ref fssystemNcaHeader + num + 584) = 1;
            ++index;
          }
          while (index < fileSystemInfo.numFsEntries);
        }
        fixed (byte* numPtr1 = &fileSystemInfo.encryptedKey[0])
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: cpblk instruction
          __memcpy(^(int&) ref fssystemNcaHeader + 768, (byte*) numPtr1, 256);
          numArray = new byte[1024];
          fixed (byte* numPtr2 = &numArray[0])
          {
            // ISSUE: cast to a reference type
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cpblk instruction
            __memcpy((byte*) numPtr2, ^(int&) ref fssystemNcaHeader, 1024);
            GC.KeepAlive((object) this);
          }
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &fssystemNcaHeader);
      }
      \u003CModule\u003E.std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&fssystemNcaHeader);
      return numArray;
    }

    public unsafe byte[] CreateNcaFsHeader(ValueType fsEntry, byte[] metaInfo)
    {
      NcaFsHeader* ncaFsHeaderPtr1 = (NcaFsHeader*) \u003CModule\u003E.@new(512U);
      NcaFsHeader* ncaFsHeaderPtr2;
      if ((IntPtr) ncaFsHeaderPtr1 != IntPtr.Zero)
      {
        // ISSUE: initblk instruction
        __memset((IntPtr) ncaFsHeaderPtr1, 0, 512);
        ncaFsHeaderPtr2 = ncaFsHeaderPtr1;
      }
      else
        ncaFsHeaderPtr2 = (NcaFsHeader*) 0;
      unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E fssystemNcaFsHeader;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref fssystemNcaFsHeader = (int) ncaFsHeaderPtr2;
      byte[] numArray;
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: initblk instruction
        __memset(^(int&) ref fssystemNcaFsHeader, 0, 512);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(short*) ^(int&) ref fssystemNcaFsHeader = (short) ((NintendoContentFileSystemInfo.EntryInfo) fsEntry).version;
        if (string.Compare(((NintendoContentFileSystemInfo.EntryInfo) fsEntry).formatType, "RomFs", false) == 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          *(sbyte*) (^(int&) ref fssystemNcaFsHeader + 2) = (sbyte) 0;
        }
        else if (string.Compare(((NintendoContentFileSystemInfo.EntryInfo) fsEntry).formatType, "PartitionFs", false) == 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          *(sbyte*) (^(int&) ref fssystemNcaFsHeader + 2) = (sbyte) 1;
        }
        else
          goto label_16;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(sbyte*) (^(int&) ref fssystemNcaFsHeader + 4) = (sbyte) ((NintendoContentFileSystemInfo.EntryInfo) fsEntry).encryptionType;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(sbyte*) (^(int&) ref fssystemNcaFsHeader + 3) = (sbyte) ((NintendoContentFileSystemInfo.EntryInfo) fsEntry).hashType;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        switch (*(byte*) (^(int&) ref fssystemNcaFsHeader + 3))
        {
          case 2:
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(int*) (^(int&) ref fssystemNcaFsHeader + 40) = this.GetHashBlockSize(fsEntry);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(int*) (^(int&) ref fssystemNcaFsHeader + 44) = 2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(long*) (^(int&) ref fssystemNcaFsHeader + 48) = 0L;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(long*) (^(int&) ref fssystemNcaFsHeader + 56) = (long) ((NintendoContentFileSystemInfo.EntryInfo) fsEntry).hashDataSize;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(long*) (^(int&) ref fssystemNcaFsHeader + 64) = (long) ((NintendoContentFileSystemInfo.EntryInfo) fsEntry).hashTargetOffset;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            *(long*) (^(int&) ref fssystemNcaFsHeader + 72) = (long) ((NintendoContentFileSystemInfo.EntryInfo) fsEntry).hashTargetSize;
            break;
          case 3:
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            Debug.Assert(*(byte*) (^(int&) ref fssystemNcaFsHeader + 2) == (byte) 0);
            fixed (byte* numPtr = &metaInfo[0])
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(int*) (^(int&) ref fssystemNcaFsHeader + 8) = *(int*) numPtr;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(int*) (^(int&) ref fssystemNcaFsHeader + 12) = *(int*) ((IntPtr) numPtr + 4);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(int*) (^(int&) ref fssystemNcaFsHeader + 16) = *(int*) ((IntPtr) numPtr + 8);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(int*) (^(int&) ref fssystemNcaFsHeader + 20) = *(int*) ((IntPtr) numPtr + 12);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 24, (IntPtr) numPtr + 16, 24);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 48, (IntPtr) numPtr + 40, 24);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 72, (IntPtr) numPtr + 64, 24);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 96, (IntPtr) numPtr + 88, 24);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 120, (IntPtr) numPtr + 112, 24);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 144, (IntPtr) numPtr + 136, 24);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 168, (IntPtr) numPtr + 160, 24);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cpblk instruction
              __memcpy(^(int&) ref fssystemNcaFsHeader + 168, (IntPtr) numPtr + 160, 32);
              break;
            }
          default:
            goto label_14;
        }
        numArray = new byte[512];
        fixed (byte* numPtr = &numArray[0])
        {
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cpblk instruction
          __memcpy((byte*) numPtr, ^(int&) ref fssystemNcaFsHeader, 512);
          GC.KeepAlive((object) this);
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &fssystemNcaFsHeader);
      }
      \u003CModule\u003E.std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&fssystemNcaFsHeader);
      return numArray;
label_14:
      // ISSUE: fault handler
      try
      {
        throw new ArgumentException();
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &fssystemNcaFsHeader);
      }
label_16:
      // ISSUE: fault handler
      try
      {
        throw new ArgumentException();
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &fssystemNcaFsHeader);
      }
    }
  }
}
