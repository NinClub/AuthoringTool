// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.FileSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.IO;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class FileSource : ISource
  {
    private string m_filePath;
    private long m_offset;
    private SourceStatus m_status;

    public long Size { get; private set; }

    public FileSource(string filePath, long offset, long size)
    {
      this.m_filePath = filePath;
      this.m_offset = offset;
      this.Size = size;
      this.m_status = new SourceStatus();
      this.m_status.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
    }

    public ByteData PullData(long offset, int size)
    {
      int readableSize = SourceUtil.GetReadableSize(this.Size, offset, size);
      if (readableSize == 0)
        return new ByteData(new ArraySegment<byte>());
      byte[] numArray = new byte[size];
      int count = 0;
      using (Stream stream = (Stream) new SubStream((Stream) new FileStream(this.m_filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan), this.m_offset, this.Size))
      {
        stream.Seek(offset, SeekOrigin.Begin);
        count = stream.Read(numArray, 0, readableSize);
      }
      return new ByteData(new ArraySegment<byte>(numArray, 0, count));
    }

    public SourceStatus QueryStatus()
    {
      return this.m_status;
    }
  }
}
