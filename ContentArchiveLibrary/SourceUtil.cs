// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SourceUtil
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SourceUtil
  {
    public static int GetReadableSize(long sourceSize, long offset, int sizeToRead)
    {
      if (offset < 0L || offset >= sourceSize)
        return 0;
      return (int) Math.Min((long) sizeToRead, sourceSize - offset);
    }
  }
}
