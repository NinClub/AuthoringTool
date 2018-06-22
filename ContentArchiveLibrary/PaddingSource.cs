// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.PaddingSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class PaddingSource : ISource
  {
    private SourceStatus m_status;

    public long Size { get; private set; }

    public PaddingSource(long size)
    {
      this.Size = size;
      this.m_status = new SourceStatus();
      this.m_status.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
    }

    public ByteData PullData(long offset, int size)
    {
      int readableSize = SourceUtil.GetReadableSize(this.Size, offset, size);
      if (readableSize == 0)
        return new ByteData(new ArraySegment<byte>());
      return new ByteData(new ArraySegment<byte>(new byte[readableSize]));
    }

    public SourceStatus QueryStatus()
    {
      return this.m_status;
    }
  }
}
