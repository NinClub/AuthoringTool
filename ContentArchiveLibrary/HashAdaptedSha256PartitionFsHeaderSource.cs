// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.HashAdaptedSha256PartitionFsHeaderSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class HashAdaptedSha256PartitionFsHeaderSource : ISource
  {
    private ISource m_Source;

    public long Size { get; private set; }

    public HashAdaptedSha256PartitionFsHeaderSource(ISource source, List<Sha256PartitionFsHashSource> hashSources)
    {
      List<Tuple<ISource, long, long>> adaptSourceInfos = new List<Tuple<ISource, long, long>>();
      foreach (Sha256PartitionFsHashSource hashSource in hashSources)
      {
        if (hashSource.Source == null || hashSource.Source.Size != 32L)
          throw new InvalidOperationException();
        adaptSourceInfos.Add(Tuple.Create<ISource, long, long>(hashSource.Source, Sha256PartitionFileSystemMeta.GetEntryHashOffset(hashSource.Index), hashSource.Source.Size));
      }
      this.m_Source = (ISource) new AdaptedSource(source, adaptSourceInfos);
      this.Size = this.m_Source.Size;
    }

    public ByteData PullData(long offset, int size)
    {
      return this.m_Source.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.m_Source.QueryStatus();
    }
  }
}
