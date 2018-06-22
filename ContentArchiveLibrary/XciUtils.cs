// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.XciUtils
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class XciUtils
  {
    internal static long GetAvailableAreaSize(int size)
    {
      long num = 1073741824;
      return (long) size * num - XciInfo.GetUnusedAreaSize(size) + (long) (XciInfo.PageSize * XciInfo.CardKeyAreaPageCount);
    }

    internal static int GetRomSize(long xciSize)
    {
      IEnumerable<int> source = ((IEnumerable<int>) XciInfo.RomSizeTable).Where<int>((Func<int, bool>) (x => XciUtils.GetAvailableAreaSize(x) >= xciSize));
      if (!source.Any<int>())
        return XciInfo.InvalidRomSize;
      return source.First<int>();
    }

    internal static int GetClockRate(int size)
    {
      XciUtils.CheckRomSize(size);
      return XciInfo.GetClockRateFromRomSize(size);
    }

    internal static void CheckRomSize(int size)
    {
      if (!((IEnumerable<int>) XciInfo.RomSizeTable).Where<int>((Func<int, bool>) (x => x == size)).Any<int>())
        throw new ArgumentException("Invalid card size. (valid: " + string.Join<int>(", ", (IEnumerable<int>) XciInfo.RomSizeTable) + ")");
    }

    internal static void CheckClockRate(int clockRate)
    {
      if (!((IEnumerable<int>) XciInfo.ClockRateTable).Where<int>((Func<int, bool>) (x => x == clockRate)).Any<int>())
        throw new ArgumentException("Invalid card clock rate. (valid: " + string.Join<int>(", ", (IEnumerable<int>) XciInfo.ClockRateTable) + ")");
    }

    internal static void CheckRomSizeAndClockRate(int size, int clockRate)
    {
      XciUtils.CheckRomSize(size);
      XciUtils.CheckClockRate(clockRate);
      if (clockRate == 50 && XciInfo.GetClockRateFromRomSize(size) != 50)
        throw new ArgumentException("Invalid card clock rate. 50 MHz clock rate setting can be used for only the card whose size more than 8 GB.");
    }

    public static void DumpHeader(byte[] xciHeaderData)
    {
      byte[] array1 = ((IEnumerable<byte>) xciHeaderData).Skip<byte>(256).ToArray<byte>();
      Aes128CbcCryptoDriver aes128CbcCryptoDriver = new Aes128CbcCryptoDriver(Aes128KeyIndex.XciHeader);
      byte[] array2 = ((IEnumerable<byte>) array1).Skip<byte>(XciMeta.GetIvOffset()).Take<byte>(XciInfo.IvSize).ToArray<byte>();
      byte[] iv = new byte[array2.Length];
      for (int index = 0; index < array2.Length; ++index)
        iv[index] = array2[array2.Length - 1 - index];
      aes128CbcCryptoDriver.DecryptBlock(iv, array1, XciMeta.GetEncryptionTargetOffset(), XciMeta.GetEncryptionTargetSize(), array1, XciMeta.GetEncryptionTargetOffset());
      XciMeta.DumpHeader(array1);
    }
  }
}
