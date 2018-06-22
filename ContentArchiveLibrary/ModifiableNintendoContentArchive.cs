// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ModifiableNintendoContentArchive
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class ModifiableNintendoContentArchive : IConnector
  {
    private KeyConfiguration m_KeyConfig;

    public List<Connection> ConnectionList { get; private set; }

    public ModifiableNintendoContentArchive(IReadableSink outSink, NintendoContentArchiveReader ncaReader, ISource inSource, string targetEntryPath, string descFilePath, KeyConfiguration keyConfig)
    {
      this.m_KeyConfig = keyConfig;
      NintendoContentArchiveSource contentArchiveSource = new NintendoContentArchiveSource(ArchiveReconstructionUtils.GetReplacedNcaInfo(ncaReader, descFilePath, new EntryReplaceRule()
      {
        Source = inSource,
        Path = targetEntryPath
      }), this.m_KeyConfig, false);
      outSink.SetSize(contentArchiveSource.Size);
      this.ConnectionList = new List<Connection>();
      this.ConnectionList.Add(new Connection((ISource) contentArchiveSource, (ISink) outSink));
    }

    public ISource GetSource()
    {
      throw new NotImplementedException();
    }
  }
}
