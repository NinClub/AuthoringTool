// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoApplicationExtendedHeader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoApplicationExtendedHeader : NintendoExtendedHeader
  {
    private ulong \u003Cbacking_store\u003EPatchId;
    private uint \u003Cbacking_store\u003ERequiredSystemVersion;

    public NintendoApplicationExtendedHeader(ulong patchId, uint requiredSystemVersion)
    {
      this.\u003Cbacking_store\u003EPatchId = patchId;
      this.\u003Cbacking_store\u003ERequiredSystemVersion = requiredSystemVersion;
      GC.KeepAlive((object) this);
    }

    public ulong PatchId
    {
      get
      {
        return this.\u003Cbacking_store\u003EPatchId;
      }
      set
      {
        this.\u003Cbacking_store\u003EPatchId = value;
      }
    }

    public uint RequiredSystemVersion
    {
      get
      {
        return this.\u003Cbacking_store\u003ERequiredSystemVersion;
      }
      set
      {
        this.\u003Cbacking_store\u003ERequiredSystemVersion = value;
      }
    }
  }
}
