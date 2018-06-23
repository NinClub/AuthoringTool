// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentMeta
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
  public class NintendoContentMeta : IDisposable
  {
    private unsafe sbyte* m_Buffer;
    private unsafe PackagedContentMetaWriter* m_Writer;

    public static unsafe NintendoContentMeta CreateApplicationMeta(ulong id, uint version, byte attributes, uint requiredDownloadSystemVersion, NintendoApplicationExtendedHeader appExHeader, List<NintendoContentInfo> contentInfoList, List<NintendoContentMetaInfo> contentMetaInfoList, byte[] digest)
    {
      NintendoContentMeta nintendoContentMeta = new NintendoContentMeta((ContentMetaType) 128, id, version, attributes, requiredDownloadSystemVersion, contentInfoList, contentMetaInfoList, digest);
      ApplicationMetaExtendedHeader metaExtendedHeader;
      // ISSUE: initblk instruction
      __memset(ref metaExtendedHeader, 0, 16);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(long&) ref metaExtendedHeader = (long) appExHeader.PatchId;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &metaExtendedHeader + 8) = (int) appExHeader.RequiredSystemVersion;
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* writer = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) nintendoContentMeta.m_Writer;
      if (*(byte*) writer == (byte) 0)
        \u003CModule\u003E.abort();
      // ISSUE: cpblk instruction
      __memcpy(*(int*) ((IntPtr) writer + 4) + 32, ref metaExtendedHeader, 16);
      GC.KeepAlive((object) nintendoContentMeta);
      return nintendoContentMeta;
    }

    public static unsafe NintendoContentMeta CreateAddOnContentMeta(ulong id, uint version, byte attributes, uint requiredDownloadSystemVersion, NintendoAddOnContentExtendedHeader aocExHeader, List<NintendoContentInfo> contentInfoList, List<NintendoContentMetaInfo> contentMetaInfoList, byte[] digest)
    {
      NintendoContentMeta nintendoContentMeta = new NintendoContentMeta((ContentMetaType) 130, id, version, attributes, requiredDownloadSystemVersion, contentInfoList, contentMetaInfoList, digest);
      AddOnContentMetaExtendedHeader metaExtendedHeader;
      // ISSUE: initblk instruction
      __memset(ref metaExtendedHeader, 0, 16);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(long&) ref metaExtendedHeader = (long) aocExHeader.ApplicationId;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &metaExtendedHeader + 8) = (int) aocExHeader.RequiredApplicationVersion;
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* writer = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) nintendoContentMeta.m_Writer;
      if (*(byte*) writer == (byte) 0)
        \u003CModule\u003E.abort();
      // ISSUE: cpblk instruction
      __memcpy(*(int*) ((IntPtr) writer + 4) + 32, ref metaExtendedHeader, 16);
      GC.KeepAlive((object) nintendoContentMeta);
      return nintendoContentMeta;
    }

    public static unsafe NintendoContentMeta CreatePatchMeta(ulong id, uint version, byte attributes, uint requiredDownloadSystemVersion, NintendoPatchExtendedHeader patchExHeader, List<NintendoContentInfo> contentInfoList, List<NintendoContentMetaInfo> contentMetaInfoList, byte[] digest)
    {
      NintendoContentMeta nintendoContentMeta = new NintendoContentMeta((ContentMetaType) 129, id, version, attributes, requiredDownloadSystemVersion, contentInfoList, contentMetaInfoList, digest);
      PatchMetaExtendedHeader metaExtendedHeader;
      // ISSUE: initblk instruction
      __memset(ref metaExtendedHeader, 0, 16);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(long&) ref metaExtendedHeader = (long) patchExHeader.ApplicationId;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &metaExtendedHeader + 8) = (int) patchExHeader.RequiredSystemVersion;
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* writer = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) nintendoContentMeta.m_Writer;
      if (*(byte*) writer == (byte) 0)
        \u003CModule\u003E.abort();
      // ISSUE: cpblk instruction
      __memcpy(*(int*) ((IntPtr) writer + 4) + 32, ref metaExtendedHeader, 16);
      GC.KeepAlive((object) nintendoContentMeta);
      return nintendoContentMeta;
    }

    public static NintendoContentMeta CreateDefault(ulong id, uint version, string type, byte attributes, uint requiredDownloadSystemVersion, List<NintendoContentInfo> contentInfoList, List<NintendoContentMetaInfo> contentMetaInfoList, byte[] digest)
    {
      return new NintendoContentMeta(NintendoContentMeta.ConvertMetaType(type), id, version, attributes, requiredDownloadSystemVersion, contentInfoList, contentMetaInfoList, digest);
    }

    public static uint GetRequiredSystemVersion()
    {
      return 0;
    }

    private void \u007ENintendoContentMeta()
    {
      this.\u0021NintendoContentMeta();
    }

    private unsafe void \u0021NintendoContentMeta()
    {
      \u003CModule\u003E.delete((void*) this.m_Writer, 12U);
      \u003CModule\u003E.delete\u005B\u005D((void*) this.m_Buffer);
    }

    public unsafe byte[] GetBytes()
    {
      byte[] numArray = new byte[*(int*) ((IntPtr) this.m_Writer + 8)];
      fixed (byte* numPtr = &numArray[0])
      {
        PackagedContentMetaWriter* writer = this.m_Writer;
        uint num = (uint) *(int*) ((IntPtr) writer + 8);
        void* voidPtr = (void*) *(int*) ((IntPtr) writer + 4);
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((byte*) numPtr, (IntPtr) voidPtr, (int) num);
        GC.KeepAlive((object) this);
        return numArray;
      }
    }

    public unsafe long GetContentInfoIdDataOffset(int index)
    {
      PackagedContentMetaWriter* writer = this.m_Writer;
      uint num = (uint) *(int*) ((IntPtr) writer + 4);
      uint writableContentInfo = (uint) \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetWritableContentInfo((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) writer, index);
      if (writableContentInfo == 0U)
        throw new InvalidOperationException();
      GC.KeepAlive((object) this);
      return (long) (uint) ((int) writableContentInfo - (int) num + 32);
    }

    public static int GetContentInfoIdDataSize()
    {
      return 16;
    }

    public unsafe long GetContentInfoHashOffset(int index)
    {
      PackagedContentMetaWriter* writer = this.m_Writer;
      uint num = (uint) *(int*) ((IntPtr) writer + 4);
      uint writableContentInfo = (uint) \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetWritableContentInfo((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) writer, index);
      if (writableContentInfo == 0U)
        throw new InvalidOperationException();
      GC.KeepAlive((object) this);
      return (long) (writableContentInfo - num);
    }

    public static int GetContentInfoHashSize()
    {
      return 32;
    }

    public unsafe long GetDigestOffset()
    {
      PackagedContentMetaWriter* writer = this.m_Writer;
      uint num = (uint) *(int*) ((IntPtr) writer + 4);
      uint digestAddress = \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetDigestAddress((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) writer);
      if (digestAddress == 0U)
        throw new InvalidOperationException();
      GC.KeepAlive((object) this);
      return (long) (digestAddress - num);
    }

    public static int GetDigestSize()
    {
      return 32;
    }

    private unsafe NintendoContentMeta(ContentMetaType metaType, ulong id, uint version, byte attributes, uint requiredDownloadSystemVersion, List<NintendoContentInfo> contentInfoList, List<NintendoContentMetaInfo> contentMetaInfoList, byte[] digest)
    {
      int count1 = contentMetaInfoList.Count;
      int count2 = contentInfoList.Count;
      uint num1;
      int num2;
      switch (metaType)
      {
        case (ContentMetaType) 128:
          num1 = 16U;
          goto label_6;
        case (ContentMetaType) 129:
          num1 = 16U;
          goto label_6;
        case (ContentMetaType) 130:
          num2 = 16;
          break;
        default:
          num2 = 0;
          break;
      }
      num1 = (uint) num2;
label_6:
      int num3 = 56;
      uint num4 = (uint) (count2 * num3 + ((int) num1 + (count1 + 4) * 16));
      this.m_Buffer = (sbyte*) \u003CModule\u003E.new\u005B\u005D(num4);
      PackagedContentMetaWriter* contentMetaWriterPtr1 = (PackagedContentMetaWriter*) \u003CModule\u003E.@new(12U);
      PackagedContentMetaWriter* contentMetaWriterPtr2;
      if ((IntPtr) contentMetaWriterPtr1 != IntPtr.Zero)
      {
        void* buffer = (void*) this.m_Buffer;
        *(sbyte*) contentMetaWriterPtr1 = (sbyte) 0;
        *(int*) ((IntPtr) contentMetaWriterPtr1 + 4) = (int) buffer;
        *(int*) ((IntPtr) contentMetaWriterPtr1 + 8) = (int) num4;
        contentMetaWriterPtr2 = contentMetaWriterPtr1;
      }
      else
        contentMetaWriterPtr2 = (PackagedContentMetaWriter*) 0;
      this.m_Writer = contentMetaWriterPtr2;
      \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteHeader((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Writer, id, version, metaType, attributes, requiredDownloadSystemVersion, contentInfoList.Count, contentMetaInfoList.Count);
      int index1 = 0;
      if (0 < contentInfoList.Count)
      {
        do
        {
          PackagedContentInfo packagedContentInfo;
          // ISSUE: initblk instruction
          __memset(ref packagedContentInfo, 0, 56);
          ContentId contentId;
          // ISSUE: initblk instruction
          __memset(ref contentId, 0, 16);
          ContentType contentType = NintendoContentMeta.ConvertType(contentInfoList[index1].Type);
          long size = contentInfoList[index1].Size;
          ContentInfo contentInfo;
          // ISSUE: cpblk instruction
          __memcpy(ref contentInfo, ref contentId, 16);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ((IntPtr) &contentInfo + 16) = (int) size;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(short&) ((IntPtr) &contentInfo + 20) = (short) (int) (size >> 32);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(sbyte&) ((IntPtr) &contentInfo + 22) = (sbyte) contentType;
          // ISSUE: cast to a reference type
          // ISSUE: initblk instruction
          __memset((ContentInfo&) ((IntPtr) &contentInfo + 23), 0, 1);
          // ISSUE: cast to a reference type
          // ISSUE: cpblk instruction
          __memcpy((PackagedContentInfo&) ((IntPtr) &packagedContentInfo + 32), ref contentInfo, 24);
          \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteContentInfo((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Writer, &packagedContentInfo, index1);
          ++index1;
        }
        while (index1 < contentInfoList.Count);
      }
      int index2 = 0;
      if (0 < contentMetaInfoList.Count)
      {
        do
        {
          NintendoContentMetaInfo contentMetaInfo1 = contentMetaInfoList[index2];
          byte attributes1 = contentMetaInfo1.Attributes;
          ContentMetaType contentMetaType = NintendoContentMeta.ConvertMetaType(contentMetaInfo1.Type);
          uint version1 = contentMetaInfo1.Version;
          ContentMetaInfo contentMetaInfo2;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(long&) ref contentMetaInfo2 = (long) contentMetaInfo1.Id;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ((IntPtr) &contentMetaInfo2 + 8) = (int) version1;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(sbyte&) ((IntPtr) &contentMetaInfo2 + 12) = (sbyte) contentMetaType;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(sbyte&) ((IntPtr) &contentMetaInfo2 + 13) = (sbyte) attributes1;
          // ISSUE: cast to a reference type
          // ISSUE: initblk instruction
          __memset((ContentMetaInfo&) ((IntPtr) &contentMetaInfo2 + 14), 0, 2);
          \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteContentMetaInfo((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Writer, &contentMetaInfo2, index2);
          ++index2;
        }
        while (index2 < contentMetaInfoList.Count);
      }
      fixed (byte* numPtr = &digest[0])
      {
        Hash hash;
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy(ref hash, (byte*) numPtr, 32);
        // ISSUE: cpblk instruction
        __memcpy((int) \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetDigestAddress((ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Writer), ref hash, 32);
        GC.KeepAlive((object) this);
      }
    }

    private static ContentMetaType ConvertMetaType(string type)
    {
      if (type.Equals("Application"))
        return (ContentMetaType) 128;
      if (type.Equals("Patch"))
        return (ContentMetaType) 129;
      if (type.Equals("AddOnContent"))
        return (ContentMetaType) 130;
      if (type.Equals("SystemProgram"))
        return (ContentMetaType) 1;
      if (type.Equals("SystemData"))
        return (ContentMetaType) 2;
      if (type.Equals("SystemUpdate"))
        return (ContentMetaType) 3;
      if (type.Equals("BootImagePackage"))
        return (ContentMetaType) 4;
      if (type.Equals("BootImagePackageSafe"))
        return (ContentMetaType) 5;
      throw new ArgumentException(string.Format("Unknown content meta type {0}.", (object) type));
    }

    private static ContentType ConvertType(string type)
    {
      if (type.Equals("Program"))
        return (ContentType) 1;
      if (type.Equals("Control"))
        return (ContentType) 3;
      if (type.Equals("Data"))
        return (ContentType) 2;
      if (type.Equals("Meta"))
        return (ContentType) 0;
      if (type.Equals("HtmlDocument"))
        return (ContentType) 4;
      if (type.Equals("LegalInformation"))
        return (ContentType) 5;
      throw new ArgumentException(string.Format("Unknown content type {0}.", (object) type));
    }

    private unsafe void WriteExtendedHeader\u003Cnn\u003A\u003Ancm\u003A\u003AApplicationMetaExtendedHeader\u003E(ApplicationMetaExtendedHeader* data)
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* writer = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Writer;
      if (*(byte*) writer == (byte) 0)
        \u003CModule\u003E.abort();
      // ISSUE: cpblk instruction
      __memcpy(*(int*) ((IntPtr) writer + 4) + 32, (IntPtr) data, 16);
      GC.KeepAlive((object) this);
    }

    private unsafe void WriteExtendedHeader\u003Cnn\u003A\u003Ancm\u003A\u003AAddOnContentMetaExtendedHeader\u003E(AddOnContentMetaExtendedHeader* data)
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* writer = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Writer;
      if (*(byte*) writer == (byte) 0)
        \u003CModule\u003E.abort();
      // ISSUE: cpblk instruction
      __memcpy(*(int*) ((IntPtr) writer + 4) + 32, (IntPtr) data, 16);
      GC.KeepAlive((object) this);
    }

    private unsafe void WriteExtendedHeader\u003Cnn\u003A\u003Ancm\u003A\u003APatchMetaExtendedHeader\u003E(PatchMetaExtendedHeader* data)
    {
      ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* writer = (ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E*) this.m_Writer;
      if (*(byte*) writer == (byte) 0)
        \u003CModule\u003E.abort();
      // ISSUE: cpblk instruction
      __memcpy(*(int*) ((IntPtr) writer + 4) + 32, (IntPtr) data, 16);
      GC.KeepAlive((object) this);
    }

    [HandleProcessCorruptedStateExceptions]
    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u0021NintendoContentMeta();
      }
      else
      {
        try
        {
          this.\u0021NintendoContentMeta();
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

    ~NintendoContentMeta()
    {
      this.Dispose(false);
    }
  }
}
