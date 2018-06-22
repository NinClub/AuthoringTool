// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ExternalContentKeyGenerator
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public static class ExternalContentKeyGenerator
  {
    public static AesKey GetNcaExternalContentKey(IHashCalculator hashCalculator, ulong titleId)
    {
      Trace.Assert(hashCalculator != null, "IHashCalculator is null.");
      byte[] array = ((IEnumerable<byte>) BitConverter.GetBytes(titleId)).Reverse<byte>().ToArray<byte>();
      byte[] dst = new byte[hashCalculator.HashSize];
      hashCalculator.CalculateHash(array, 0, array.Length, dst, 0);
      return new AesKey(((IEnumerable<byte>) dst).Where<byte>((Func<byte, int, bool>) ((name, index) => index < 16)).ToArray<byte>());
    }
  }
}
