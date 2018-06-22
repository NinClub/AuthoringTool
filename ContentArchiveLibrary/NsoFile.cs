// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NsoFile
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class NsoFile
  {
    public string fileName { get; private set; }

    public byte[] roBinary { get; private set; }

    public byte[] apiInfoBinary { get; private set; }

    public string[] GetApiInfoStrings()
    {
      if (this.apiInfoBinary == null)
        return (string[]) null;
      List<string> stringList = new List<string>((IEnumerable<string>) Encoding.GetEncoding("Shift_JIS").GetString(this.apiInfoBinary).Split(new char[1]));
      stringList.Remove(string.Empty);
      return stringList.ToArray();
    }

    public void ParseNsoData(byte[] fileData, string path)
    {
      this.fileName = this.GetNsoName(path);
      int count = Marshal.SizeOf(typeof (NsoHeader));
      GCHandle gcHandle = GCHandle.Alloc((object) ((IEnumerable<byte>) fileData).Skip<byte>(0).Take<byte>(count).ToArray<byte>(), GCHandleType.Pinned);
      NsoHeader structure = (NsoHeader) Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof (NsoHeader));
      gcHandle.Free();
      byte[] array = ((IEnumerable<byte>) fileData).Skip<byte>((int) structure.RoFileOffset).Take<byte>((int) structure.RoFileSize).ToArray<byte>();
      this.roBinary = new byte[(int) structure.RoSize];
      if (((int) structure.Flags & 2) == 2)
      {
        if (Lz4.LZ4_decompress_safe(array, 0, this.roBinary, 0, array.Length, this.roBinary.Length) != this.roBinary.Length)
          throw new Exception("lz4の展開に失敗しました。\n" + path);
      }
      else
        array.CopyTo((Array) this.roBinary, 0);
      if (structure.EmbededSize <= 0U)
        return;
      this.apiInfoBinary = new byte[(int) structure.EmbededSize];
      Array.Copy((Array) this.roBinary, (long) structure.EmbededOffset, (Array) this.apiInfoBinary, 0L, (long) this.apiInfoBinary.Length);
    }

    private string GetNsoName(string path)
    {
      Regex regex = new Regex("([^\\\\]+)\\.nspd");
      return !regex.IsMatch(path) ? path : regex.Match(path).Groups[1].Value + ".nso";
    }
  }
}
