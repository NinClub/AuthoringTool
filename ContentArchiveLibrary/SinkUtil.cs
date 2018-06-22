// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SinkUtil
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SinkUtil
  {
    public static bool CheckIsFilled(RangeList rangeList, long size)
    {
      return rangeList.Count != 0 && rangeList.Count == 1 && (rangeList.First<Range>().Offset == 0L && rangeList.First<Range>().Size == size);
    }

    public static int GetWritableSize(long sinkSize, long offset, int sizeToWrite)
    {
      if (offset < 0L || offset >= sinkSize)
        return 0;
      return (int) Math.Min((long) sizeToWrite, sinkSize - offset);
    }
  }
}
