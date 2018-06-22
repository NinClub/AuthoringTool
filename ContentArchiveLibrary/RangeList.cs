// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.RangeList
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class RangeList : List<Range>
  {
    public void MergingAdd(Range range)
    {
      if (this.Count == 0)
      {
        this.Add(range);
      }
      else
      {
        IEnumerable<Range> source = this.Where<Range>((Func<Range, bool>) (e => e.Offset <= range.Offset));
        if (source.Count<Range>() == 0)
        {
          this.Insert(0, range);
          this.TryMergeToNext(0);
        }
        else
        {
          Range range1 = source.Last<Range>();
          if (range.Offset <= range1.End && range1.End < range.End)
          {
            range1.SetSize(range1.Size + (range.End - range1.End));
            this.TryMergeToNext(this.IndexOf(range1));
          }
          else
          {
            if (range1.End >= range.Offset)
              return;
            int num = this.IndexOf(range1);
            this.Insert(num + 1, range);
            this.TryMergeToNext(num + 1);
          }
        }
      }
    }

    private void TryMergeToNext(int index)
    {
      if (index == this.Count - 1)
        return;
      Range range1 = this[index];
      Range range2 = this[index + 1];
      if (range1.End < range2.Offset)
        return;
      range1.SetSize(range1.Size + (range2.End - range1.End));
      this.Remove(range2);
      this.TryMergeToNext(index);
    }

    public RangeList GetDuplicatedDeletedList(RangeList rangeList)
    {
      RangeList rangeList1 = new RangeList();
      foreach (Range range in (List<Range>) this)
        rangeList1.MergingAdd(range);
      if (rangeList1.Count == 0)
        return rangeList1;
      int index = 0;
      Range range1 = rangeList1[0];
      using (List<Range>.Enumerator enumerator = rangeList.GetEnumerator())
      {
label_26:
        while (enumerator.MoveNext())
        {
          Range current = enumerator.Current;
          while (true)
          {
            for (; range1.End <= current.Offset; range1 = rangeList1[index])
            {
              ++index;
              if (index == rangeList1.Count)
                return rangeList1;
            }
            if (range1.Offset < current.End)
            {
              bool flag1 = range1.End <= current.End;
              bool flag2 = range1.Offset >= current.Offset;
              if (flag2 & flag1)
                rangeList1.Remove(range1);
              else if (flag2 && !flag1)
              {
                Range range2 = new Range(current.End, range1.End - current.End);
                rangeList1.Remove(range1);
                rangeList1.MergingAdd(range2);
              }
              else if (!flag2 & flag1)
              {
                Range range2 = new Range(range1.Offset, current.Offset - range1.Offset);
                rangeList1.Remove(range1);
                rangeList1.MergingAdd(range2);
              }
              else if (!flag2 && !flag1)
              {
                Range range2 = new Range(range1.Offset, current.Offset - range1.Offset);
                Range range3 = new Range(current.End, range1.End - current.End);
                rangeList1.Remove(range1);
                rangeList1.MergingAdd(range2);
                rangeList1.MergingAdd(range3);
              }
              if (rangeList1.Count != 0)
                range1 = rangeList1[index];
              else
                break;
            }
            else
              goto label_26;
          }
          return rangeList1;
        }
      }
      return rangeList1;
    }
  }
}
