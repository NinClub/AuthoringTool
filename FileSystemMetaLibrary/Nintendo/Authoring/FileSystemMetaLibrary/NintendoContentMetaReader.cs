// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentMetaReader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn.ncm;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoContentMetaReader : IDisposable
  {
    private unsafe sbyte* m_Buffer;
    private unsafe PackagedContentMetaReader* m_Reader;
    private uint m_Size;

    public unsafe NintendoContentMetaReader(byte[] buffer)
    {
      this.m_Size = (uint) buffer.Length;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      NintendoContentMetaReader contentMetaReader = this;
      contentMetaReader.m_Buffer = (sbyte*) \u003CModule\u003E.new\u005B\u005D(contentMetaReader.m_Size);
      fixed (byte* numPtr = &buffer[0])
      {
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) this.m_Buffer, (byte*) numPtr, (int) this.m_Size);
        PackagedContentMetaReader* contentMetaReaderPtr1 = (PackagedContentMetaReader*) \u003CModule\u003E.@new(12U);
        PackagedContentMetaReader* contentMetaReaderPtr2;
        if ((IntPtr) contentMetaReaderPtr1 != IntPtr.Zero)
        {
          uint size = this.m_Size;
          void* buffer1 = (void*) this.m_Buffer;
          *(sbyte*) contentMetaReaderPtr1 = (sbyte) 1;
          *(int*) ((IntPtr) contentMetaReaderPtr1 + 4) = (int) buffer1;
          *(int*) ((IntPtr) contentMetaReaderPtr1 + 8) = (int) size;
          contentMetaReaderPtr2 = contentMetaReaderPtr1;
        }
        else
          contentMetaReaderPtr2 = (PackagedContentMetaReader*) 0;
        this.m_Reader = contentMetaReaderPtr2;
        GC.KeepAlive((object) this);
      }
    }

    private void \u007ENintendoContentMetaReader()
    {
      this.\u0021NintendoContentMetaReader();
    }

    private unsafe void \u0021NintendoContentMetaReader()
    {
      \u003CModule\u003E.delete((void*) this.m_Reader, 12U);
      \u003CModule\u003E.delete((void*) this.m_Buffer, 1U);
    }

    public unsafe string GetType()
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* reader = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Reader;
      if (*(byte*) reader == (byte) 0)
        \u003CModule\u003E.abort();
      string str = NintendoContentMetaReader.ConvertMetaType((ContentMetaType) *(byte*) (*(int*) ((IntPtr) reader + 4) + 12));
      GC.KeepAlive((object) this);
      return str;
    }

    public unsafe ulong GetId()
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* reader = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Reader;
      if (*(byte*) reader == (byte) 0)
        \u003CModule\u003E.abort();
      int num = *(int*) ((IntPtr) reader + 4);
      GC.KeepAlive((object) this);
      return (ulong) *(long*) num;
    }

    public unsafe uint GetVersion()
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* reader = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Reader;
      if (*(byte*) reader == (byte) 0)
        \u003CModule\u003E.abort();
      int num1 = *(int*) ((IntPtr) reader + 4);
      GC.KeepAlive((object) this);
      int num2 = 8;
      return (uint) *(int*) (num1 + num2);
    }

    public unsafe byte GetAttributes()
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* reader = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Reader;
      if (*(byte*) reader == (byte) 0)
        \u003CModule\u003E.abort();
      int num1 = *(int*) ((IntPtr) reader + 4);
      GC.KeepAlive((object) this);
      int num2 = 20;
      return *(byte*) (num1 + num2);
    }

    public ulong GetApplicationId()
    {
      GC.KeepAlive((object) this);
      return 0;
    }

    public unsafe uint GetRequiredDownloadSystemVersion()
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* reader = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Reader;
      if (*(byte*) reader == (byte) 0)
        \u003CModule\u003E.abort();
      int num1 = *(int*) ((IntPtr) reader + 4);
      GC.KeepAlive((object) this);
      int num2 = 24;
      return (uint) *(int*) (num1 + num2);
    }

    public unsafe List<NintendoContentInfo> GetContentInfoList()
    {
      List<NintendoContentInfo> nintendoContentInfoList = new List<NintendoContentInfo>();
      int index = 0;
      PackagedContentMetaReader* reader = this.m_Reader;
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* packagedContentInfoPtr = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) reader;
      if (*(byte*) packagedContentInfoPtr != (byte) 0)
      {
        while (index < (int) *(ushort*) (*(int*) ((IntPtr) packagedContentInfoPtr + 4) + 16))
        {
          PackagedContentInfo* contentInfo = \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentInfo((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) reader, index);
          byte[] id = new byte[16];
          fixed (byte* numPtr1 = &id[0])
          {
            // ISSUE: cast to a reference type
            // ISSUE: cpblk instruction
            __memcpy((byte*) numPtr1, (IntPtr) contentInfo + 32, 16);
            byte[] hash = new byte[32];
            fixed (byte* numPtr2 = &hash[0])
            {
              // ISSUE: cast to a reference type
              // ISSUE: cpblk instruction
              __memcpy((byte*) numPtr2, (IntPtr) contentInfo, 32);
              ContentInfo* contentInfoPtr = (ContentInfo*) ((IntPtr) contentInfo + 32);
              long size = (long) *(ushort*) ((IntPtr) contentInfoPtr + 20) * 4294967296L + (long) (uint) *(int*) ((IntPtr) contentInfoPtr + 16);
              NintendoContentInfo nintendoContentInfo = new NintendoContentInfo(NintendoContentMetaReader.ConvertType((ContentType) *(byte*) ((IntPtr) contentInfo + 54)), id, size, hash);
              nintendoContentInfoList.Add(nintendoContentInfo);
              ++index;
              reader = this.m_Reader;
              packagedContentInfoPtr = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) reader;
              if (*(byte*) packagedContentInfoPtr == (byte) 0)
                goto label_3;
            }
          }
        }
        goto label_4;
      }
label_3:
      \u003CModule\u003E.abort();
label_4:
      GC.KeepAlive((object) this);
      return nintendoContentInfoList;
    }

    public unsafe List<NintendoContentMetaInfo> GetContentMetaInfoList()
    {
      List<NintendoContentMetaInfo> nintendoContentMetaInfoList = new List<NintendoContentMetaInfo>();
      int index = 0;
      PackagedContentMetaReader* reader = this.m_Reader;
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* packagedContentInfoPtr = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) reader;
      if (*(byte*) packagedContentInfoPtr != (byte) 0)
      {
        while (index < (int) *(ushort*) (*(int*) ((IntPtr) packagedContentInfoPtr + 4) + 18))
        {
          ContentMetaInfo* contentMetaInfo = \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfo((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) reader, index);
          NintendoContentMetaInfo nintendoContentMetaInfo = new NintendoContentMetaInfo(NintendoContentMetaReader.ConvertMetaType((ContentMetaType) *(byte*) ((IntPtr) contentMetaInfo + 12)), (ulong) *(long*) contentMetaInfo, (uint) *(int*) ((IntPtr) contentMetaInfo + 8), *(byte*) ((IntPtr) contentMetaInfo + 13));
          nintendoContentMetaInfoList.Add(nintendoContentMetaInfo);
          ++index;
          reader = this.m_Reader;
          packagedContentInfoPtr = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) reader;
          if (*(byte*) packagedContentInfoPtr == (byte) 0)
            goto label_3;
        }
        goto label_4;
      }
label_3:
      \u003CModule\u003E.abort();
label_4:
      GC.KeepAlive((object) this);
      return nintendoContentMetaInfoList;
    }

    public unsafe byte[] GetDigest()
    {
      byte[] numArray = new byte[32];
      fixed (byte* numPtr = &numArray[0])
      {
        uint digestAddress = \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetDigestAddress((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Reader);
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((byte*) numPtr, (int) digestAddress, 32);
        GC.KeepAlive((object) this);
        return numArray;
      }
    }

    public unsafe NintendoExtendedHeader GetExtendedHeader()
    {
      PackagedContentMetaReader* reader = this.m_Reader;
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* packagedContentInfoPtr = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) reader;
      if (*(byte*) packagedContentInfoPtr == (byte) 0)
        \u003CModule\u003E.abort();
      switch (*(byte*) (*(int*) ((IntPtr) packagedContentInfoPtr + 4) + 12))
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
          GC.KeepAlive((object) this);
          return (NintendoExtendedHeader) null;
        case 128:
          ApplicationMetaExtendedHeader* metaExtendedHeaderPtr1 = (ApplicationMetaExtendedHeader*) (*(int*) ((IntPtr) reader + 4) + 32);
          NintendoApplicationExtendedHeader applicationExtendedHeader = new NintendoApplicationExtendedHeader((ulong) *(long*) metaExtendedHeaderPtr1, (uint) *(int*) ((IntPtr) metaExtendedHeaderPtr1 + 8));
          GC.KeepAlive((object) this);
          return (NintendoExtendedHeader) applicationExtendedHeader;
        case 129:
          PatchMetaExtendedHeader* metaExtendedHeaderPtr2 = (PatchMetaExtendedHeader*) (*(int*) ((IntPtr) reader + 4) + 32);
          NintendoPatchExtendedHeader patchExtendedHeader = new NintendoPatchExtendedHeader((ulong) *(long*) metaExtendedHeaderPtr2, (uint) *(int*) ((IntPtr) metaExtendedHeaderPtr2 + 8));
          GC.KeepAlive((object) this);
          return (NintendoExtendedHeader) patchExtendedHeader;
        case 130:
          AddOnContentMetaExtendedHeader* metaExtendedHeaderPtr3 = (AddOnContentMetaExtendedHeader*) (*(int*) ((IntPtr) reader + 4) + 32);
          NintendoAddOnContentExtendedHeader contentExtendedHeader = new NintendoAddOnContentExtendedHeader((ulong) *(long*) metaExtendedHeaderPtr3, (uint) *(int*) ((IntPtr) metaExtendedHeaderPtr3 + 8), (string) null);
          GC.KeepAlive((object) this);
          return (NintendoExtendedHeader) contentExtendedHeader;
        default:
          throw new ArgumentException(string.Format("Unknown content meta type."));
      }
    }

    private static string ConvertMetaType(ContentMetaType type)
    {
      switch (type)
      {
        case (ContentMetaType) 1:
          return "SystemProgram";
        case (ContentMetaType) 2:
          return "SystemData";
        case (ContentMetaType) 3:
          return "SystemUpdate";
        case (ContentMetaType) 4:
          return "BootImagePackage";
        case (ContentMetaType) 5:
          return "BootImagePackageSafe";
        case (ContentMetaType) 128:
          return "Application";
        case (ContentMetaType) 129:
          return "Patch";
        case (ContentMetaType) 130:
          return "AddOnContent";
        default:
          throw new ArgumentException(string.Format("Unknown content meta type."));
      }
    }

    private static string ConvertType(ContentType type)
    {
      switch (type)
      {
        case (ContentType) 0:
          return "Meta";
        case (ContentType) 1:
          return "Program";
        case (ContentType) 2:
          return "Data";
        case (ContentType) 3:
          return "Control";
        case (ContentType) 4:
          return "HtmlDocument";
        case (ContentType) 5:
          return "LegalInformation";
        default:
          throw new ArgumentException(string.Format("Unknown content type."));
      }
    }

    [HandleProcessCorruptedStateExceptions]
    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u0021NintendoContentMetaReader();
      }
      else
      {
        try
        {
          this.\u0021NintendoContentMetaReader();
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

    ~NintendoContentMetaReader()
    {
      this.Dispose(false);
    }
  }
}
