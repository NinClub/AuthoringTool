// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.IntegrityHierarchicalStorageSink
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class IntegrityHierarchicalStorageSink : ISink
  {
    private HierarchicalIntegrityVerificationStorage m_storage;
    private SinkStatus m_status;

    public long Size { get; private set; }

    public int MasterHashSize
    {
      get
      {
        return (int) this.m_storage.GetMasterHashSize();
      }
    }

    public int LayerHashSize
    {
      get
      {
        return (int) this.m_storage.GetLayerHashSize();
      }
    }

    public IntegrityHierarchicalStorageSink(long size)
    {
      this.Size = size;
      this.m_storage = new HierarchicalIntegrityVerificationStorage();
      this.m_storage.Initialize(size);
      this.m_status = new SinkStatus();
    }

    public int PushData(ByteData data, long offset)
    {
      int writableSize = SinkUtil.GetWritableSize(this.Size, offset, data.Buffer.Count);
      if (writableSize == 0)
        return 0;
      this.m_storage.Write(offset, data.Buffer.Array);
      this.m_storage.Commit();
      this.m_status.FilledRangeList.MergingAdd(new Range(offset, (long) writableSize));
      this.m_status.IsFilled = SinkUtil.CheckIsFilled(this.m_status.FilledRangeList, this.Size);
      return writableSize;
    }

    public SinkStatus QueryStatus()
    {
      return this.m_status;
    }

    public void SetSize(long size)
    {
      throw new NotSupportedException();
    }

    public byte[] GetMetaInfo()
    {
      return this.m_storage.GetMetaInfo();
    }

    public ByteData GetMasterHash(long offset, int size)
    {
      return new ByteData(new ArraySegment<byte>(this.m_storage.GetMasterHash(), (int) offset, size));
    }

    public ByteData GetLayerHash(long offset, int size)
    {
      return new ByteData(new ArraySegment<byte>(this.m_storage.GetLayerHash(offset, (long) size), 0, size));
    }
  }
}
