// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.FileSystemArchvieBaseSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class FileSystemArchvieBaseSource : ISource
  {
    private IFileSystemArchiveReader m_Reader;
    private SourceStatus m_status;

    public long Size { get; private set; }

    public FileSystemArchvieBaseSource(IFileSystemArchiveReader reader)
    {
      this.m_Reader = reader;
      this.Size = this.m_Reader.GetBaseSize();
      this.m_status = new SourceStatus();
      this.m_status.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
    }

    public ByteData PullData(long offset, int size)
    {
      int num1 = size;
      if (offset + (long) num1 > this.Size)
      {
        int num2 = (int) (this.Size - offset);
        num1 = num2 > 0 ? num2 : 0;
      }
      byte[] array = this.m_Reader.ReadBase(offset, (long) num1);
      return new ByteData(new ArraySegment<byte>(array, 0, array.Length));
    }

    public SourceStatus QueryStatus()
    {
      return this.m_status;
    }

    public IFileSystemArchiveReader GetReader()
    {
      return this.m_Reader;
    }
  }
}
