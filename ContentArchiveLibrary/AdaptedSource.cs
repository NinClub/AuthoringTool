// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.AdaptedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class AdaptedSource : ISource
  {
    private ISource m_baseSource;
    public List<Tuple<ISource, long, long>> m_adaptSourceInfos;

    public long Size { get; private set; }

    public AdaptedSource(ISource baseSource, ISource adaptSource, long offset, long size)
      : this(baseSource, new List<Tuple<ISource, long, long>>()
      {
        Tuple.Create<ISource, long, long>(adaptSource, offset, size)
      })
    {
    }

    public AdaptedSource(ISource baseSource, List<Tuple<ISource, long, long>> adaptSourceInfos)
    {
      this.Size = baseSource.Size;
      this.m_baseSource = baseSource;
      foreach (Tuple<ISource, long, long> adaptSourceInfo in adaptSourceInfos)
      {
        ISource source = adaptSourceInfo.Item1;
        long num1 = adaptSourceInfo.Item2;
        long num2 = adaptSourceInfo.Item3;
        if (num1 < 0L || num1 > this.Size || (num1 + num2 > this.Size || source.Size < num2))
          throw new ArgumentException();
      }
      this.m_adaptSourceInfos = adaptSourceInfos;
    }

    public ByteData PullData(long offset, int size)
    {
      ByteData byteData1 = this.m_baseSource.PullData(offset, size);
      foreach (Tuple<ISource, long, long> adaptSourceInfo in this.m_adaptSourceInfos)
      {
        ISource source = adaptSourceInfo.Item1;
        long num1 = adaptSourceInfo.Item2;
        long num2 = adaptSourceInfo.Item3;
        if (offset < num1 + num2)
        {
          long num3 = offset;
          ArraySegment<byte> buffer = byteData1.Buffer;
          long count1 = (long) buffer.Count;
          if (num3 + count1 > num1)
          {
            ByteData byteData2 = source.PullData(0L, (int) num2);
            buffer = byteData2.Buffer;
            if (buffer.Count == 0)
            {
              buffer = new ArraySegment<byte>();
              return new ByteData(buffer);
            }
            buffer = byteData2.Buffer;
            if ((long) buffer.Count != num2)
              throw new InvalidOperationException();
            long num4 = num1 + num2;
            long num5 = offset;
            buffer = byteData1.Buffer;
            long count2 = (long) buffer.Count;
            long num6 = num5 + count2;
            bool flag1 = num4 <= num6;
            bool flag2 = num1 >= offset;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            if (flag2 & flag1)
            {
              num7 = (int) (num1 - offset);
              num8 = 0;
              num9 = (int) num2;
            }
            else if (flag2 && !flag1)
            {
              num7 = (int) (num1 - offset);
              num8 = 0;
              long num10 = offset;
              buffer = byteData1.Buffer;
              long count3 = (long) buffer.Count;
              num9 = (int) (num10 + count3 - num1);
            }
            else if (!flag2 & flag1)
            {
              num7 = 0;
              num8 = (int) (offset - num1);
              num9 = (int) (num2 - (long) num8);
            }
            else if (!flag2 && !flag1)
            {
              num7 = 0;
              num8 = (int) (offset - num1);
              buffer = byteData1.Buffer;
              num9 = buffer.Count;
            }
            buffer = byteData2.Buffer;
            byte[] array1 = buffer.Array;
            buffer = byteData2.Buffer;
            int srcOffset = buffer.Offset + num8;
            buffer = byteData1.Buffer;
            byte[] array2 = buffer.Array;
            buffer = byteData1.Buffer;
            int dstOffset = buffer.Offset + num7;
            int count4 = num9;
            Buffer.BlockCopy((Array) array1, srcOffset, (Array) array2, dstOffset, count4);
          }
        }
      }
      return byteData1;
    }

    public SourceStatus QueryStatus()
    {
      bool flag = true;
      foreach (Tuple<ISource, long, long> adaptSourceInfo in this.m_adaptSourceInfos)
      {
        ISource source = adaptSourceInfo.Item1;
        RangeList availableRangeList = source.QueryStatus().AvailableRangeList;
        if (availableRangeList.Count != 1 || availableRangeList[0].Size != source.Size)
          flag = false;
      }
      if (flag)
        return this.m_baseSource.QueryStatus();
      return new SourceStatus();
    }
  }
}
