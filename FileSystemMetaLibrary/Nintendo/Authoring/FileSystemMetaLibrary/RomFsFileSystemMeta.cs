// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.RomFsFileSystemMeta
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn;
using nn.fs;
using nn.fssystem;
using System;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class RomFsFileSystemMeta
  {
    public unsafe RomFsFileSystemMetaInfo Create(RomFsFileSystemInfo fileSystemInfo)
    {
      HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E istorageNnFsIstorage;
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002E\u007Bctor\u007D((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) &istorageNnFsIstorage);
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002E\u007Bctor\u007D((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) ((IntPtr) &istorageNnFsIstorage + 40));
      uint num1 = (uint) (\u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECalculateBucketCount(fileSystemInfo.directoryEntryCount) << 2);
      uint sizeKeyValue1 = (uint) ((fileSystemInfo.directoryEntryCount + 1) * 793);
      uint num2 = (uint) (\u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECalculateBucketCount(fileSystemInfo.fileEntryCount) << 2);
      uint sizeKeyValue2 = (uint) (fileSystemInfo.fileEntryCount * 801);
      uint num3 = sizeKeyValue2 + num2 + sizeKeyValue1 + num1;
      RomFsFileSystemMetaInfo fileSystemMetaInfo = new RomFsFileSystemMetaInfo();
      byte[] numArray1 = new byte[512];
      fileSystemMetaInfo.header = numArray1;
      fixed (byte* numPtr1 = &numArray1[0])
      {
        byte[] numArray2 = new byte[(int) num3];
        fileSystemMetaInfo.data = numArray2;
        fixed (byte* numPtr2 = &numArray2[0])
        {
          nn.fssystem.MemoryStorage memoryStorage1;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ref memoryStorage1 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
          long num4;
          // ISSUE: fault handler
          try
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ref memoryStorage1 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryStorage\u0040fssystem\u0040nn\u0040\u00406B\u0040;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &memoryStorage1 + 4) = (int) numPtr2;
            num4 = (long) num1;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(long&) ((IntPtr) &memoryStorage1 + 8) = num4;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage1);
          }
          // ISSUE: fault handler
          try
          {
            void* voidPtr1 = (void*) ((IntPtr) numPtr2 + (int) num1);
            nn.fssystem.MemoryStorage memoryStorage2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ref memoryStorage2 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
            // ISSUE: fault handler
            try
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ref memoryStorage2 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryStorage\u0040fssystem\u0040nn\u0040\u00406B\u0040;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ((IntPtr) &memoryStorage2 + 4) = (int) voidPtr1;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(long&) ((IntPtr) &memoryStorage2 + 8) = (long) sizeKeyValue1;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage2);
            }
            // ISSUE: fault handler
            try
            {
              uint num5 = sizeKeyValue1 + num1;
              void* voidPtr2 = (void*) ((IntPtr) numPtr2 + (int) num5);
              nn.fssystem.MemoryStorage memoryStorage3;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ref memoryStorage3 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
              long num6;
              // ISSUE: fault handler
              try
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ref memoryStorage3 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryStorage\u0040fssystem\u0040nn\u0040\u00406B\u0040;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ((IntPtr) &memoryStorage3 + 4) = (int) voidPtr2;
                num6 = (long) num2;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(long&) ((IntPtr) &memoryStorage3 + 8) = num6;
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage3);
              }
              // ISSUE: fault handler
              try
              {
                uint num7 = num2 + num5;
                void* voidPtr3 = (void*) ((IntPtr) numPtr2 + (int) num7);
                nn.fssystem.MemoryStorage memoryStorage4;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ref memoryStorage4 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
                // ISSUE: fault handler
                try
                {
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  ^(int&) ref memoryStorage4 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryStorage\u0040fssystem\u0040nn\u0040\u00406B\u0040;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  ^(int&) ((IntPtr) &memoryStorage4 + 4) = (int) voidPtr3;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  ^(long&) ((IntPtr) &memoryStorage4 + 8) = (long) sizeKeyValue2;
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage4);
                }
                // ISSUE: fault handler
                try
                {
                  uint countBucket = num1 >> 2;
                  Result result1;
                  \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EFormat(&result1, (IStorage*) &memoryStorage1, 0L, countBucket, (IStorage*) &memoryStorage2, 0L, sizeKeyValue1);
                  Result result2;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (^(int&) ref result1 == 0)
                  {
                    Result result3;
                    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EFormat(&result3, (IStorage*) &memoryStorage3, 0L, num2 >> 2, (IStorage*) &memoryStorage4, 0L, sizeKeyValue2);
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if (^(int&) ref result3 == 0)
                    {
                      Result result4;
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      ^(int&) ref result4 = 0;
                      goto label_18;
                    }
                    else
                      result2 = result3;
                  }
                  else
                    result2 = result1;
                  int num8;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (^(int&) ref result2 != 0)
                  {
                    num8 = 0;
                    goto label_20;
                  }
label_18:
                  num8 = 1;
label_20:
                  if ((byte) num8 == (byte) 0)
                    throw new Exception("Failed to initialize meta data.");
                  Result result5;
                  \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EInitialize((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) &istorageNnFsIstorage, &result5, (IStorage*) &memoryStorage1, 0L, countBucket, (IStorage*) &memoryStorage2, 0L, sizeKeyValue1);
                  Result result6;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (^(int&) ref result5 == 0)
                  {
                    Result result3;
                    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EInitialize((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) ((IntPtr) &istorageNnFsIstorage + 40), &result3, (IStorage*) &memoryStorage3, 0L, num2 >> 2, (IStorage*) &memoryStorage4, 0L, sizeKeyValue2);
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if (^(int&) ref result3 == 0)
                    {
                      Result result4;
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      ^(int&) ref result4 = 0;
                      goto label_28;
                    }
                    else
                      result6 = result3;
                  }
                  else
                    result6 = result5;
                  int num9;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (^(int&) ref result6 != 0)
                  {
                    num9 = 0;
                    goto label_30;
                  }
label_28:
                  num9 = 1;
label_30:
                  if ((byte) num9 == (byte) 0)
                    throw new Exception("Failed to initialize meta data.");
                  Result result7;
                  if (*(int*) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECreateRootDirectory(&istorageNnFsIstorage, &result7) != 0)
                    throw new Exception("Failed to initialize meta data.");
                  int index = 0;
                  if (0 < fileSystemInfo.entries.Count)
                  {
                    RomFsFileSystemInfo.EntryInfo entry;
                    do
                    {
                      entry = fileSystemInfo.entries[index];
                      string type = entry.type;
                      if (!(type == "file") && !(type == "source"))
                      {
                        if (type == "directory")
                          \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECreateDirectoryRecursively(&istorageNnFsIstorage, entry.name);
                        else
                          goto label_40;
                      }
                      else
                      {
                        \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECreateDirectoryRecursively(&istorageNnFsIstorage, \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002EGetDirectoryName(entry.name));
                        \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECreateFileW(&istorageNnFsIstorage, &entry);
                      }
                      ++index;
                    }
                    while (index < fileSystemInfo.entries.Count);
                    goto label_41;
label_40:
                    throw new Exception("Invalid entry type: " + entry.type);
                  }
label_41:
                  RomFsFileSystemInfo.EntryInfo entry1 = fileSystemInfo.entries[fileSystemInfo.entries.Count - 1];
                  ulong num10 = (ulong) ((long) entry1.size + (long) entry1.offset + 7L & -8L);
                  fileSystemMetaInfo.offsetData = (long) num10 + 512L;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  uint num11 = (uint) (^(int&) ((IntPtr) &istorageNnFsIstorage + 32) + 3 & -4);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  uint num12 = (uint) (^(int&) ((IntPtr) &istorageNnFsIstorage + 72) + 3 & -4);
                  uint num13 = sizeKeyValue1 - num11;
                  uint num14 = num5 - num13;
                  \u003CModule\u003E.memmove((void*) ((IntPtr) numPtr2 + (int) num14), (void*) ((IntPtr) numPtr2 + (int) num5), num2);
                  uint num15 = num7 - num13;
                  \u003CModule\u003E.memmove((void*) ((IntPtr) numPtr2 + (int) num15), (void*) ((IntPtr) numPtr2 + (int) num7), num12);
                  uint num16 = sizeKeyValue2 - num12 + num13;
                  // ISSUE: initblk instruction
                  __memset((IntPtr) numPtr1, 0, 512);
                  *(long*) numPtr1 = 80L;
                  *(long*) ((IntPtr) numPtr1 + 8) = 0L;
                  *(long*) ((IntPtr) numPtr1 + 16) = num4;
                  *(long*) ((IntPtr) numPtr1 + 24) = num4;
                  *(long*) ((IntPtr) numPtr1 + 32) = (long) num11;
                  *(long*) ((IntPtr) numPtr1 + 40) = (long) num14;
                  *(long*) ((IntPtr) numPtr1 + 48) = num6;
                  *(long*) ((IntPtr) numPtr1 + 56) = (long) num15;
                  *(long*) ((IntPtr) numPtr1 + 64) = (long) num12;
                  *(long*) ((IntPtr) numPtr1 + 72) = 512L;
                  *(long*) ((IntPtr) numPtr1 + 8) = fileSystemMetaInfo.offsetData;
                  *(long*) ((IntPtr) numPtr1 + 24) = *(long*) ((IntPtr) numPtr1 + 24) + fileSystemMetaInfo.offsetData;
                  *(long*) ((IntPtr) numPtr1 + 40) = *(long*) ((IntPtr) numPtr1 + 40) + fileSystemMetaInfo.offsetData;
                  *(long*) ((IntPtr) numPtr1 + 56) = *(long*) ((IntPtr) numPtr1 + 56) + fileSystemMetaInfo.offsetData;
                  Array.Resize<byte>(ref fileSystemMetaInfo.data, (int) num3 - (int) num16);
                  GC.KeepAlive((object) this);
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EMemoryStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage4);
                }
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ref memoryStorage4 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EMemoryStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage3);
              }
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ref memoryStorage3 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EMemoryStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage2);
            }
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ref memoryStorage2 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EMemoryStorage\u002E\u007Bdtor\u007D), (void*) &memoryStorage1);
          }
          return fileSystemMetaInfo;
        }
      }
    }
  }
}
