// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.IntegrityHierarchicalLayerHashSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class IntegrityHierarchicalLayerHashSource : ISource
  {
    private IntegrityHierarchicalStorageSink m_sink;

    public long Size { get; private set; }

    public IntegrityHierarchicalLayerHashSource(IntegrityHierarchicalStorageSink sink)
    {
      this.m_sink = sink;
      this.Size = (long) sink.LayerHashSize;
    }

    public ByteData PullData(long offset, int size)
    {
      int readableSize = SourceUtil.GetReadableSize(this.Size, offset, size);
      return this.m_sink.GetLayerHash(offset, readableSize);
    }

    public SourceStatus QueryStatus()
    {
      throw new NotSupportedException();
    }
  }
}
