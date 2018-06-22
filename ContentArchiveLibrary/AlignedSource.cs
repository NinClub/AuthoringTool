// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.AlignedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class AlignedSource : ISource
  {
    private ISource m_source;

    public long Size
    {
      get
      {
        return this.m_source.Size;
      }
    }

    public int AlignmentSize { get; private set; }

    public AlignedSource(ISource source, int alignmentSize)
    {
      this.AlignmentSize = alignmentSize;
      this.m_source = source;
    }

    public ByteData PullData(long offset, int size)
    {
      this.CheckAlignment(offset);
      int size1 = size;
      if (offset + (long) size1 < this.Size && (size1 & this.AlignmentSize - 1) != 0)
        size1 = size1 / this.AlignmentSize * this.AlignmentSize;
      ByteData byteData = this.m_source.PullData(offset, size1);
      if (offset + (long) byteData.Buffer.Count < this.Size)
        this.CheckAlignment((long) byteData.Buffer.Count);
      return byteData;
    }

    public SourceStatus QueryStatus()
    {
      SourceStatus sourceStatus = new SourceStatus();
      foreach (Range availableRange in (List<Range>) this.m_source.QueryStatus().AvailableRangeList)
      {
        long offset = availableRange.Offset;
        long size = availableRange.Size;
        if ((offset & (long) (this.AlignmentSize - 1)) != 0L)
        {
          offset = (offset + (long) this.AlignmentSize) / (long) this.AlignmentSize * (long) this.AlignmentSize;
          size -= offset - availableRange.Offset;
        }
        if (offset + size != this.Size)
        {
          if (size >= (long) this.AlignmentSize)
          {
            if ((size & (long) (this.AlignmentSize - 1)) != 0L)
              size = size / (long) this.AlignmentSize * (long) this.AlignmentSize;
          }
          else
            continue;
        }
        sourceStatus.AvailableRangeList.MergingAdd(new Range(offset, size));
      }
      return sourceStatus;
    }

    private void CheckSize(long value)
    {
      if (value < (long) this.AlignmentSize)
        throw new ArgumentException();
    }

    private void CheckAlignment(long value)
    {
      if ((value & (long) (this.AlignmentSize - 1)) != 0L)
        throw new ArgumentException();
    }
  }
}
