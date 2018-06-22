// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ModifiableNintendoSubmissionPackageArchive
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class ModifiableNintendoSubmissionPackageArchive : IConnector
  {
    private KeyConfiguration m_KeyConfig;

    public List<Connection> ConnectionList { get; private set; }

    public ModifiableNintendoSubmissionPackageArchive(IReadableSink outSink, NintendoSubmissionPackageReader nspReader, ISource inSource, string targetEntryPath, string descFilePath, KeyConfiguration keyConfig)
    {
      this.m_KeyConfig = keyConfig;
      NintendoSubmissionPackageFileSystemInfo replacedNspInfo = ArchiveReconstructionUtils.GetReplacedNspInfo(nspReader, inSource, targetEntryPath, descFilePath, this.m_KeyConfig);
      this.ConnectionList = new List<Connection>((IEnumerable<Connection>) new NintendoSubmissionPackageArchive(outSink, replacedNspInfo, this.m_KeyConfig).ConnectionList);
    }

    public ISource GetSource()
    {
      throw new NotImplementedException();
    }
  }
}
