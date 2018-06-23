// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.XciMeta
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn.gc.detail;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class XciMeta
  {
    private static uint Wait2TimeWrite = 0;
    private static uint Wait1TimeWrite = 0;
    private static uint Wait2TimeRead = 0;
    private static uint Wait1TimeRead = 5000;
    private static byte SelKey = 0;
    private static byte SelT1Key = 2;
    private static byte CardHeaderVersion = 0;
    private static uint BackupAreaStartPageAddress = uint.MaxValue;
    public static int KeyAreaEncryptionTargetSize = 3328;
    public static int KeyAreaEncryptionTargetOffset = 512;
    public static int InitialDataNonceSize = 12;
    public static int InitialDataMacSize = 16;
    public static int InitialDataASize = 16;
    public static int InitialDataSize = 512;
    public static int TitleKey2Size = 8;
    public static int TitleKey1Size = 8;
    private static byte[] MagicCode = new byte[4];
    private byte[] m_initialData;

    public XciMeta(byte[] initialData)
    {
      this.m_initialData = initialData;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      GC.KeepAlive((object) this);
    }

    public static int GetIvOffset()
    {
      return 32;
    }

    public static int GetEncryptionTargetOffset()
    {
      return 144;
    }

    public static int GetEncryptionTargetSize()
    {
      return 112;
    }

    public unsafe byte[] CreateHeader(XciInfo xciInfo)
    {
      if (this.m_initialData == null)
        throw new InvalidOperationException("Invalid initial data.");
      CardHeader cardHeader;
      // ISSUE: initblk instruction
      __memset(ref cardHeader, 0, 256);
      int length1 = XciMeta.MagicCode.Length;
      fixed (byte* numPtr1 = &XciMeta.MagicCode[0])
      {
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy(ref cardHeader, (byte*) numPtr1, length1);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 8) = -1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(sbyte&) ((IntPtr) &cardHeader + 14) = (sbyte) 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 132) = 2;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 136) = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 156) = 5000;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 160) = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 164) = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 168) = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cardHeader + 4) = (int) xciInfo.romAreaStartPageAddress;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(sbyte&) ((IntPtr) &cardHeader + 12) = (sbyte) ((int) xciInfo.kekIndex | (int) ^(byte&) ((IntPtr) &cardHeader + 12) & 240);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(sbyte&) ((IntPtr) &cardHeader + 13) = (sbyte) xciInfo.romSize;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(sbyte&) ((IntPtr) &cardHeader + 15) = (sbyte) xciInfo.flags;
        byte[] bytes1 = BitConverter.GetBytes(xciInfo.packageId);
        int length2 = bytes1.Length;
        fixed (byte* numPtr2 = &bytes1[0])
        {
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cpblk instruction
          __memcpy((CardHeader&) ((IntPtr) &cardHeader + 16), (byte*) numPtr2, length2);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ((IntPtr) &cardHeader + 24) = (int) xciInfo.validDataEndAddress;
          int num1 = 0;
          byte[] iv = xciInfo.iv;
          int length3 = iv.Length;
          int num2 = length3;
          if (0 < num2)
          {
            int index = length3 - 1;
            do
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(sbyte&) (num1 + ((IntPtr) &cardHeader + 32)) = (sbyte) iv[index];
              ++num1;
              --index;
            }
            while (num1 < num2);
          }
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(long&) ((IntPtr) &cardHeader + 48) = (long) xciInfo.partitionFsHeaderAddress;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(long&) ((IntPtr) &cardHeader + 56) = (long) xciInfo.partitionFsHeaderSize;
          byte[] partitionFsHeaderHash = xciInfo.partitionFsHeaderHash;
          int length4 = partitionFsHeaderHash.Length;
          fixed (byte* numPtr3 = &partitionFsHeaderHash[0])
          {
            // ISSUE: cast to a reference type
            // ISSUE: cast to a reference type
            // ISSUE: cpblk instruction
            __memcpy((CardHeader&) ((IntPtr) &cardHeader + 64), (byte*) numPtr3, length4);
            byte[] initialDataHash = this.GetInitialDataHash();
            int length5 = initialDataHash.Length;
            fixed (byte* numPtr4 = &initialDataHash[0])
            {
              // ISSUE: cast to a reference type
              // ISSUE: cast to a reference type
              // ISSUE: cpblk instruction
              __memcpy((CardHeader&) ((IntPtr) &cardHeader + 96), (byte*) numPtr4, length5);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ((IntPtr) &cardHeader + 128) = (int) xciInfo.selSec;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ((IntPtr) &cardHeader + 140) = (int) xciInfo.romAreaStartPageAddress;
              byte[] bytes2 = BitConverter.GetBytes(xciInfo.fwVersion);
              int length6 = bytes2.Length;
              fixed (byte* numPtr5 = &bytes2[0])
              {
                // ISSUE: cast to a reference type
                // ISSUE: cast to a reference type
                // ISSUE: cpblk instruction
                __memcpy((CardHeader&) ((IntPtr) &cardHeader + 144), (byte*) numPtr5, length6);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ((IntPtr) &cardHeader + 152) = (int) xciInfo.accCtrl1;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ((IntPtr) &cardHeader + 172) = (int) xciInfo.fwMode;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ((IntPtr) &cardHeader + 176) = (int) xciInfo.cupVersion;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(long&) ((IntPtr) &cardHeader + 192) = (long) xciInfo.cupId;
                byte[] uppHash = xciInfo.uppHash;
                int length7 = uppHash.Length;
                fixed (byte* numPtr6 = &uppHash[0])
                {
                  // ISSUE: cast to a reference type
                  // ISSUE: cast to a reference type
                  // ISSUE: cpblk instruction
                  __memcpy((CardHeader&) ((IntPtr) &cardHeader + 184), (byte*) numPtr6, length7);
                  byte[] numArray = new byte[256];
                  fixed (byte* numPtr7 = &numArray[0])
                  {
                    // ISSUE: cast to a reference type
                    // ISSUE: cpblk instruction
                    __memcpy((byte*) numPtr7, ref cardHeader, 256);
                    return numArray;
                  }
                }
              }
            }
          }
        }
      }
    }

    public static unsafe void DumpHeader(byte[] buffer)
    {
      Debug.Assert(buffer.Length == 256);
      fixed (byte* numPtr = &buffer[0])
      {
        CardHeader cardHeader;
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy(ref cardHeader, (byte*) numPtr, 256);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("Rom Area Start Page Address: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 4));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("Backup Area Start Page Address: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 8));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("KekIndex: 0x{0:x2}", (object) (byte) ((uint) ^(byte&) ((IntPtr) &cardHeader + 12) & 15U));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("TitleKeyDecIndex: 0x{0:x2}", (object) (byte) ((uint) ^(byte&) ((IntPtr) &cardHeader + 12) >> 4));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("Rom Size: 0x{0:x2}", (object) ^(byte&) ((IntPtr) &cardHeader + 13));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("Card Header Version: 0x{0:x2}", (object) ^(byte&) ((IntPtr) &cardHeader + 14));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("Flags: 0x{0:x}", (object) ^(byte&) ((IntPtr) &cardHeader + 15));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("PackageId: 0x{0:x2}{1:x2}{2:x2}{3:x2}_{4:x2}{5:x2}{6:x2}{7:x2}", (object) ^(byte&) ((IntPtr) &cardHeader + 16), (object) ^(byte&) ((IntPtr) &cardHeader + 17), (object) ^(byte&) ((IntPtr) &cardHeader + 18), (object) ^(byte&) ((IntPtr) &cardHeader + 19), (object) ^(byte&) ((IntPtr) &cardHeader + 20), (object) ^(byte&) ((IntPtr) &cardHeader + 21), (object) ^(byte&) ((IntPtr) &cardHeader + 22), (object) ^(byte&) ((IntPtr) &cardHeader + 23));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("Valid Data End Addess: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 24));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("SelSec: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 128));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("SelT1Key: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 132));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("SelKey: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 136));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("LimArea: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 140));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("FwVersion: 0x{0:x8}_{1:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 148), (object) (uint) ^(int&) ((IntPtr) &cardHeader + 144));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("AccCtrl1: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 152));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("FwMode: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 172));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("CUP version: 0x{0:x8}", (object) (uint) ^(int&) ((IntPtr) &cardHeader + 176));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("CUP Id: 0x{0:x8}", (object) (ulong) ^(long&) ((IntPtr) &cardHeader + 192));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Console.WriteLine("UPP Hash: 0x{0:x2}{1:x2}{2:x2}{3:x2}_{4:x2}{5:x2}{6:x2}{7:x2}", (object) ^(byte&) ((IntPtr) &cardHeader + 184), (object) ^(byte&) ((IntPtr) &cardHeader + 185), (object) ^(byte&) ((IntPtr) &cardHeader + 186), (object) ^(byte&) ((IntPtr) &cardHeader + 187), (object) ^(byte&) ((IntPtr) &cardHeader + 188), (object) ^(byte&) ((IntPtr) &cardHeader + 189), (object) ^(byte&) ((IntPtr) &cardHeader + 190), (object) ^(byte&) ((IntPtr) &cardHeader + 191));
      }
    }

    internal static unsafe void CopyByteArray(void* dst, byte[] src, int size)
    {
      fixed (byte* numPtr = &src[0])
      {
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) dst, (byte*) numPtr, size);
      }
    }

    private byte[] GetInitialDataHash()
    {
      if (this.m_initialData == null)
        throw new InvalidOperationException();
      SHA256CryptoServiceProvider cryptoServiceProvider = new SHA256CryptoServiceProvider();
      byte[] initialData = this.m_initialData;
      byte[] buffer = initialData;
      int offset = 0;
      int length = initialData.Length;
      return cryptoServiceProvider.ComputeHash(buffer, offset, length);
    }

    static XciMeta()
    {
      XciMeta.MagicCode[0] = (byte) 72;
      XciMeta.MagicCode[1] = (byte) 69;
      XciMeta.MagicCode[2] = (byte) 65;
      XciMeta.MagicCode[3] = (byte) 68;
    }
  }
}
