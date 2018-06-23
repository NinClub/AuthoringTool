// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.XciInfo
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class XciInfo
  {
    public static long UpdatePartitionLimitSize = 536805376;
    public static int UppHashSize = 8;
    public static uint AccCtrl1_50MHz = 10551312;
    public static uint AccCtrl1_25MHz = 10551313;
    public static ulong FwVersion = 1;
    public static ulong FwVersionForDev = 0;
    public static int PartitionFsHeaderHashSize = 32;
    public static int IvSize = 16;
    public static byte HistoryEraseFlag = 2;
    public static byte AutoBootFlag = 1;
    public static byte KekIndexVersionForDev = 1;
    public static byte KekIndexVersion0 = 0;
    public static uint RomAreaStartPageCountAlignment = 64;
    public static uint CardKeyAreaPageCount = 8;
    public static uint PageSize = 512;
    public static uint CardHeaderPageCount = 1;
    public static uint ReservedAreaPageCount = 55;
    public static uint CertAreaPageCount = 64;
    public static uint NormalAreaStartPageAddress = (uint) ((int) XciInfo.ReservedAreaPageCount + (int) XciInfo.CertAreaPageCount + (int) XciInfo.CardHeaderPageCount + 8);
    public static byte RomSize1GB = 250;
    public static byte RomSize2GB = 248;
    public static byte RomSize4GB = 240;
    public static byte RomSize8GB = 224;
    public static byte RomSize16GB = 225;
    public static byte RomSize32GB = 226;
    public static uint SelSecForT1 = 1;
    public static uint SelSecForT2 = 2;
    public static int[] RomSizeTable = new int[6];
    public uint romAreaStartPageAddress;
    public byte kekIndex;
    public byte romSize;
    public byte flags;
    public ulong packageId;
    public uint validDataEndAddress;
    public byte[] iv;
    public ulong partitionFsHeaderAddress;
    public ulong partitionFsHeaderSize;
    public byte[] partitionFsHeaderHash;
    public uint selSec;
    public ulong fwVersion;
    public uint accCtrl1;
    public uint fwMode;
    public uint cupVersion;
    public ulong cupId;
    public byte[] uppHash;
    public static int[] ClockRateTable;
    public static long EmptyUpdatePartitionSize;
    public static int InvalidRomSize;
    public static int InvalidClockRate;

    public static byte ConvertRomSizeToRomSizeByte(int romSize)
    {
      switch (romSize)
      {
        case 1:
          return XciInfo.RomSize1GB;
        case 2:
          return XciInfo.RomSize2GB;
        case 4:
          return XciInfo.RomSize4GB;
        case 8:
          return XciInfo.RomSize8GB;
        case 16:
          return XciInfo.RomSize16GB;
        case 32:
          return XciInfo.RomSize32GB;
        default:
          throw new ArgumentException();
      }
    }

    public static uint ConvertClockRateToAccCtrl1(int clockRate)
    {
      if (clockRate == 25)
        return 10551313;
      if (clockRate != 50)
        throw new ArgumentException();
      return 10551312;
    }

    public static int GetClockRateFromRomSize(int romSize)
    {
      return romSize < 8 ? 25 : 50;
    }

    public static long GetUnusedAreaSize(int romSize)
    {
      switch (romSize)
      {
        case 1:
          return 75497472;
        case 2:
          return 150994944;
        case 4:
          return 301989888;
        case 8:
          return 603979776;
        case 16:
          return 1207959552;
        case 32:
          return 2415919104;
        default:
          throw new ArgumentException();
      }
    }

    static XciInfo()
    {
      XciInfo.RomSizeTable[0] = 1;
      XciInfo.RomSizeTable[1] = 2;
      XciInfo.RomSizeTable[2] = 4;
      XciInfo.RomSizeTable[3] = 8;
      XciInfo.RomSizeTable[4] = 16;
      XciInfo.RomSizeTable[5] = 32;
      XciInfo.ClockRateTable = new int[2];
      XciInfo.ClockRateTable[0] = 25;
      XciInfo.ClockRateTable[1] = 50;
      XciInfo.EmptyUpdatePartitionSize = (long) XciInfo.PageSize;
      XciInfo.InvalidRomSize = -1;
      XciInfo.InvalidClockRate = -1;
    }
  }
}
