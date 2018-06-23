// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.PartitionFileSystemMeta
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn;
using nn.fssystem;
using nn.fssystem.detail;
using std;
using System;
using System.Runtime.CompilerServices;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class PartitionFileSystemMeta : IPartitionFileSystemMeta
  {
    public virtual unsafe byte[] Create(PartitionFileSystemInfo fileSystemInfo)
    {
      PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E fileSystemFormat;
      \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002E\u007Bctor\u007D(&fileSystemFormat);
      byte[] numArray;
      // ISSUE: fault handler
      try
      {
        int count = fileSystemInfo.entries.Count;
        vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E entryForConstruct;
        \u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bctor\u007D(&entryForConstruct, (uint) count);
        // ISSUE: fault handler
        try
        {
          int index = 0;
          if (0 < count)
          {
            int num = 0;
            do
            {
              PartitionFileSystemInfo.EntryInfo entry1 = fileSystemInfo.entries[index];
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(long*) (num + ^(int&) ref entryForConstruct) = (long) entry1.offset;
              PartitionFileSystemInfo.EntryInfo entry2 = fileSystemInfo.entries[index];
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(long*) (num + ^(int&) ref entryForConstruct + 8) = (long) entry2.size;
              // ISSUE: cast to a reference type
              // ISSUE: variable of a reference type
              byte* local1 = (byte*) fileSystemInfo.entries[index].name;
              if (local1 != null)
              {
                // ISSUE: cast to a reference type
                local1 = (byte*) (RuntimeHelpers.OffsetToStringData + (IntPtr) local1);
              }
              // ISSUE: cast to a reference type
              // ISSUE: variable of a reference type
              char* local2 = (char*) local1;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              PartitionFileSystemFormat.FileEntryForConstruct* entryForConstructPtr = (PartitionFileSystemFormat.FileEntryForConstruct*) (num + ^(int&) ref entryForConstruct);
              if (\u003CModule\u003E.WideCharToMultiByte(65001U, 0U, (char*) local2, -1, (sbyte*) ((IntPtr) entryForConstructPtr + 16), 769, (sbyte*) 0, (int*) 0) != 0)
              {
                // ISSUE: cast to a reference type
                local2 = (char*) null;
                ++index;
                num += 792;
              }
              else
                goto label_8;
            }
            while (index < count);
            goto label_9;
label_8:
            throw new ArgumentException(string.Format("Failed to convert UTF8 to multi byte."));
          }
label_9:
          uint num1 = 0;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          uint num2 = (uint) ((^(int&) ((IntPtr) &entryForConstruct + 4) - ^(int&) ref entryForConstruct) / 792);
          Result result1;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002EQueryMetaDataSize(&result1, &num1, (PartitionFileSystemFormat.FileEntryForConstruct*) ^(int&) ref entryForConstruct, (int) num2);
          numArray = new byte[(int) num1];
          fixed (byte* numPtr = &numArray[0])
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            uint num3 = (uint) ((^(int&) ((IntPtr) &entryForConstruct + 4) - ^(int&) ref entryForConstruct) / 792);
            Result result2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002EConstructMetaData(&result2, (void*) numPtr, num1, (PartitionFileSystemFormat.FileEntryForConstruct*) ^(int&) ref entryForConstruct, (int) num3);
            GC.KeepAlive((object) this);
          }
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &entryForConstruct);
        }
        \u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Tidy(&entryForConstruct);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002E\u007Bdtor\u007D), (void*) &fileSystemFormat);
      }
      \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002E\u007Bdtor\u007D(&fileSystemFormat);
      return numArray;
    }
  }
}
