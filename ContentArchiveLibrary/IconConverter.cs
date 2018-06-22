// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.IconConverter
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.ImageLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class IconConverter
  {
    private const string SoftwareName = "Nintendo AuthoringTool";
    private const uint DefaultNxIconSizeMax = 102400;

    private static void CheckRawIcon(Bitmap icon)
    {
      string str = "元アイコンは解像度が 1024 * 1024 のビットマップで、24 ビット RGB のフォーマットのみが許可されています。";
      if (icon.PixelFormat != PixelFormat.Format24bppRgb && icon.PixelFormat != PixelFormat.Format32bppRgb)
        throw new ArgumentException(string.Format("{0}\n{1}\n", (object) str, (object) "ピクセルフォーマットが不正です。"));
      if (icon.Width != 1024 || icon.Height != 1024)
        throw new ArgumentException(string.Format("{0}\n{1}\n", (object) str, (object) "画像の解像度が 1024 * 1024 ではありません。"));
    }

    private static void CheckNxIcon(Bitmap icon)
    {
      string str = "NX 用アイコンは解像度が 256 * 256、サイズが 100KiB 以下でなければなりません。";
      if (icon.RawFormat.Guid != ImageFormat.Jpeg.Guid)
        throw new ArgumentException(string.Format("{0}\n{1}\n", (object) str, (object) "このファイルは JPEG 形式ではありません。"));
      if (icon.Width != 256 || icon.Height != 256)
        throw new ArgumentException(string.Format("{0}\n{1}\n", (object) str, (object) "画像の解像度が 256 * 256 ではありません。"));
    }

    private static void CheckNxIconJpeg(byte[] data, uint nxIconMaxSize)
    {
      if ((long) data.Length > (long) nxIconMaxSize)
        throw new ArgumentException(string.Format("NX 用アイコンのサイズは {0} バイト以下である必要があります。", (object) nxIconMaxSize));
      if (data.Length > 102400)
        Console.WriteLine(string.Format("[警告] NX 用アイコンのサイズが {0} バイトを超えています。", (object) 102400U));
      byte[] numArray = new byte[2]
      {
        byte.MaxValue,
        (byte) 192
      };
      for (int index = 0; index < data.Length - 1; ++index)
      {
        if ((int) data[index] == (int) numArray[0] && (int) data[index + 1] == (int) numArray[1])
          return;
      }
      throw new ArgumentException("NX 用のアイコンはベースライン JPEG でなければなりません。");
    }

    private static Bitmap GetNxIconBitmap(Bitmap RawIcon, string nxIconPath)
    {
      if (nxIconPath != null)
      {
        Bitmap icon = new Bitmap(nxIconPath);
        IconConverter.CheckNxIcon(icon);
        return icon;
      }
      Bitmap bitmap1 = new Bitmap(512, 512);
      Graphics graphics1 = Graphics.FromImage((Image) bitmap1);
      graphics1.InterpolationMode = InterpolationMode.Bilinear;
      graphics1.DrawImage((Image) RawIcon, 0, 0, 512, 512);
      Bitmap bitmap2 = new Bitmap(256, 256);
      Graphics graphics2 = Graphics.FromImage((Image) bitmap2);
      graphics2.InterpolationMode = InterpolationMode.Bilinear;
      graphics2.DrawImage((Image) bitmap1, 0, 0, 256, 256);
      return bitmap2;
    }

    private static Bitmap GetRawIcon(string rawIconPath)
    {
      Bitmap icon = new Bitmap(rawIconPath);
      IconConverter.CheckRawIcon(icon);
      return icon;
    }

    private static void CorrectRgbChannel(byte[] pixel, PixelFormat format)
    {
      int num1 = format == PixelFormat.Format24bppRgb ? 3 : 4;
      int index = 0;
      while (index < pixel.Length)
      {
        byte num2 = pixel[index];
        pixel[index] = pixel[index + 2];
        pixel[index + 2] = num2;
        index += num1;
      }
    }

    private static void ThrowExceptionIfJpegResultFail(JpegStatus status)
    {
      if (status != JpegStatus.Ok)
        throw new Exception(string.Format("Jpeg のエンコード処理で例外が発生しました。\n{0}", (object) status));
    }

    private static Size ToSize(SizeF sizef)
    {
      return new Size((int) sizef.Width, (int) sizef.Height);
    }

    private static byte[] Encode(Bitmap icon, int quality)
    {
      using (JpegEncoder jpegEncoder = new JpegEncoder())
      {
        BitmapData bitmapdata = icon.LockBits(new Rectangle(0, 0, icon.Width, icon.Height), ImageLockMode.ReadOnly, icon.PixelFormat);
        byte[] numArray = new byte[icon.Height * bitmapdata.Stride];
        Marshal.Copy(bitmapdata.Scan0, numArray, 0, numArray.Length);
        icon.UnlockBits(bitmapdata);
        IconConverter.CorrectRgbChannel(numArray, icon.PixelFormat);
        IconConverter.ThrowExceptionIfJpegResultFail(jpegEncoder.SetPixelData(numArray, icon.PixelFormat, IconConverter.ToSize(icon.PhysicalDimension), 1));
        jpegEncoder.SetQuality(quality);
        jpegEncoder.SetSamplingRatio(SamplingRatio.Ratio_444);
        byte[] outBuffer;
        IconConverter.ThrowExceptionIfJpegResultFail(jpegEncoder.Encode(out outBuffer, new Exif()
        {
          Software = "Nintendo AuthoringTool"
        }));
        return outBuffer;
      }
    }

    private static byte[] EncodeRawIcon(Bitmap icon)
    {
      return IconConverter.Encode(icon, 98);
    }

    private static byte[] EncodeNxIcon(Bitmap icon, uint nxIconMaxSize)
    {
      if (icon.RawFormat.Guid == ImageFormat.Jpeg.Guid)
      {
        Rectangle rect = new Rectangle(0, 0, icon.Width, icon.Height);
        BitmapData bitmapData = icon.LockBits(rect, ImageLockMode.ReadOnly, icon.PixelFormat);
        byte[] destination = new byte[bitmapData.Stride * bitmapData.Height];
        Marshal.Copy(bitmapData.Scan0, destination, 0, destination.Length);
        return destination;
      }
      int num1 = 100;
      int quality = num1;
      int num2 = 0;
      uint num3 = nxIconMaxSize;
      do
      {
        if ((long) IconConverter.Encode(icon, quality).Length > (long) num3)
        {
          quality = (quality + num2) / 2;
        }
        else
        {
          num2 = quality;
          quality = (quality + num1) / 2;
        }
      }
      while (quality != num2);
      return IconConverter.Encode(icon, quality);
    }

    private static byte[] FixExifData(byte[] originalJpegData)
    {
      using (JpegDecoder jpegDecoder = new JpegDecoder())
      {
        using (ExifExtractor exifExtractor = new ExifExtractor())
        {
          using (ExifBuilder exifBuilder = new ExifBuilder())
          {
            using (new JpegEncoder())
            {
              int outOffset;
              byte[] out1;
              JpegStatus exifData1 = jpegDecoder.GetExifData(out outOffset, out out1, originalJpegData);
              if (exifData1 == JpegStatus.WrongFormat)
                return originalJpegData;
              IconConverter.ThrowExceptionIfJpegResultFail(exifData1);
              Exif out2;
              IconConverter.ThrowExceptionIfJpegResultFail(exifExtractor.Parse(out out2, out1));
              out2.Thumbnail = (byte[]) null;
              IconConverter.ThrowExceptionIfJpegResultFail(jpegDecoder.SetJpegData(originalJpegData));
              Size dimension = jpegDecoder.GetDimension();
              IconConverter.ThrowExceptionIfJpegResultFail(exifBuilder.SetExif(out2));
              byte[] exifData2 = exifBuilder.GetExifData(dimension.Width, dimension.Height);
              byte[] numArray = new byte[originalJpegData.Length - out1.Length + exifData2.Length];
              int num1 = 0;
              Array.Copy((Array) originalJpegData, (Array) numArray, outOffset);
              int destinationIndex1 = num1 + outOffset;
              Array.Copy((Array) exifData2, 0, (Array) numArray, destinationIndex1, exifData2.Length);
              int destinationIndex2 = destinationIndex1 + exifData2.Length;
              Array.Copy((Array) originalJpegData, outOffset + out1.Length, (Array) numArray, destinationIndex2, originalJpegData.Length - (outOffset + out1.Length));
              int num2 = exifData2.Length - out1.Length;
              int index = outOffset - 8;
              int num3 = ((int) originalJpegData[index] << 8) + (int) originalJpegData[index + 1] + num2;
              numArray[index] = (byte) (num3 >> 8);
              numArray[index + 1] = (byte) num3;
              return numArray;
            }
          }
        }
      }
    }

    public static Tuple<byte[], byte[]> Convert(string rawIconPath, string nxIconPath, uint nxIconMaxSize)
    {
      Bitmap rawIcon = IconConverter.GetRawIcon(rawIconPath);
      byte[] numArray = IconConverter.EncodeRawIcon(rawIcon);
      Bitmap nxIconBitmap = IconConverter.GetNxIconBitmap(rawIcon, nxIconPath);
      byte[] data = !(nxIconBitmap.RawFormat.Guid != ImageFormat.Jpeg.Guid) ? IconConverter.FixExifData(File.ReadAllBytes(nxIconPath)) : IconConverter.EncodeNxIcon(nxIconBitmap, nxIconMaxSize);
      IconConverter.CheckNxIconJpeg(data, nxIconMaxSize);
      return new Tuple<byte[], byte[]>(numArray, data);
    }

    public static byte[] ConvertNxIcon(string rawIconPath, string nxIconPath, uint nxIconMaxSize)
    {
      return IconConverter.Convert(rawIconPath, nxIconPath, nxIconMaxSize).Item2;
    }

    public static Dictionary<string, Tuple<string, string>> GetMergedIconPathMap(List<Tuple<string, string>> rawIconPathList, List<Tuple<string, string>> nxIconPathList)
    {
      Dictionary<string, Tuple<string, string>> merged = new Dictionary<string, Tuple<string, string>>();
      rawIconPathList.ForEach((Action<Tuple<string, string>>) (p => merged.Add(p.Item1, new Tuple<string, string>(p.Item2, (string) null))));
      nxIconPathList.ForEach((Action<Tuple<string, string>>) (p =>
      {
        string key = p.Item1;
        string str = p.Item2;
        if (!merged.ContainsKey(key))
          merged.Add(key, new Tuple<string, string>((string) null, (string) null));
        Tuple<string, string> tuple = merged[key];
        merged[key] = new Tuple<string, string>(tuple.Item1, str);
      }));
      return merged;
    }
  }
}
