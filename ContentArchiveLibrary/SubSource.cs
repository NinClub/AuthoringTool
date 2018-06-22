// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SubSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SubSource : ISource
  {
    private ISource m_source;
    private long m_offset;

    public long Size { get; private set; }

    public SubSource(ISource source, long offset, long size)
    {
      this.m_source = source;
      this.m_offset = offset;
      this.Size = size;
    }

    public ByteData PullData(long offset, int size)
    {
      int size1 = size;
      if (offset + (long) size1 > this.Size)
      {
        int num = (int) (this.Size - offset);
        size1 = num > 0 ? num : 0;
      }
      return this.m_source.PullData(this.m_offset + offset, size1);
    }

    public SourceStatus QueryStatus()
    {
      SourceStatus sourceStatus = new SourceStatus();
      RangeList availableRangeList = this.m_source.QueryStatus().AvailableRangeList;
      RangeList rangeList1 = new RangeList();
      rangeList1.Add(new Range(0L, this.m_offset));
      rangeList1.Add(new Range(this.m_offset + this.Size, this.m_source.Size - (this.m_offset + this.Size)));
      RangeList rangeList2 = rangeList1;
      foreach (Range duplicatedDeleted in (List<Range>) availableRangeList.GetDuplicatedDeletedList(rangeList2))
        sourceStatus.AvailableRangeList.MergingAdd(new Range(duplicatedDeleted.Offset - this.m_offset, duplicatedDeleted.Size));
      return sourceStatus;
    }
  }
}
