// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ProdEncryptedNintendoSubmissionPackageArchive
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class ProdEncryptedNintendoSubmissionPackageArchive : IConnector
  {
    private KeyConfiguration m_KeyConfig;

    public List<Connection> ConnectionList { get; private set; }

    public ProdEncryptedNintendoSubmissionPackageArchive(IReadableSink outSink, NintendoSubmissionPackageReader nspReader, KeyConfiguration keyConfig, DebugConfiguration debugConfig)
    {
      this.m_KeyConfig = keyConfig;
      NintendoSubmissionPackageFileSystemInfo prodNspInfo = ArchiveReconstructionUtils.GetProdNspInfo(nspReader, this.m_KeyConfig);
      prodNspInfo.EnableContentMetaBinaryExport = debugConfig.EnableContentMetaBinaryExport;
      this.ConnectionList = new List<Connection>((IEnumerable<Connection>) new NintendoSubmissionPackageArchive(outSink, prodNspInfo, this.m_KeyConfig).ConnectionList);
    }

    public ISource GetSource()
    {
      throw new NotImplementedException();
    }
  }
}
