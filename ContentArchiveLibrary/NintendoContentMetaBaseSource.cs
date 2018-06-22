// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentMetaBaseSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoContentMetaBaseSource : ISource
  {
    private NintendoContentMetaBase m_contentMetaBase;
    private ISource m_source;
    private bool m_isUpdateDigest;

    public long Size { get; private set; }

    internal NintendoContentMetaBaseSource(NintendoContentMetaBase contentMetaBase, bool isUpdateDigest)
    {
      this.m_isUpdateDigest = isUpdateDigest;
      this.m_contentMetaBase = contentMetaBase;
      byte[] bytes = contentMetaBase.GetBytes();
      ISource source = (ISource) new MemorySource(bytes, 0, bytes.Length);
      List<ISource> list = contentMetaBase.GetContentSourceList().Select<Tuple<ISource, NintendoContentInfo>, ISource>((Func<Tuple<ISource, NintendoContentInfo>, ISource>) (tuple => tuple.Item1)).ToList<ISource>();
      for (int index = 0; index < list.Count; ++index)
      {
        long contentInfoIdDataSize = contentMetaBase.GetContentInfoIdDataSize();
        long infoIdDataOffset = contentMetaBase.GetContentInfoIdDataOffset(index);
        ISource baseSource = (ISource) new AdaptedSource(source, (ISource) new SubSource(list[index], 0L, contentInfoIdDataSize), infoIdDataOffset, contentInfoIdDataSize);
        long contentInfoHashSize = contentMetaBase.GetContentInfoHashSize();
        long contentInfoHashOffset = contentMetaBase.GetContentInfoHashOffset(index);
        source = (ISource) new AdaptedSource(baseSource, list[index], contentInfoHashOffset, contentInfoHashSize);
      }
      if (isUpdateDigest)
      {
        long digestSize = contentMetaBase.GetDigestSize();
        long digestOffset = contentMetaBase.GetDigestOffset();
        source = (ISource) new AdaptedSource(source, (ISource) new Sha256StreamHashSource((ISource) new SubSource(source, 0L, digestOffset)), digestOffset, digestSize);
      }
      this.m_source = source;
      this.Size = this.m_source.Size;
    }

    public ByteData PullData(long offset, int size)
    {
      return this.m_source.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }
  }
}
