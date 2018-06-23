// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoPatchExtendedHeader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoPatchExtendedHeader : NintendoExtendedHeader
  {
    private ulong \u003Cbacking_store\u003EApplicationId;
    private uint \u003Cbacking_store\u003ERequiredSystemVersion;

    public NintendoPatchExtendedHeader(ulong applicationId, uint requiredSystemVersion)
    {
      this.\u003Cbacking_store\u003EApplicationId = applicationId;
      this.\u003Cbacking_store\u003ERequiredSystemVersion = requiredSystemVersion;
      GC.KeepAlive((object) this);
    }

    public ulong ApplicationId
    {
      get
      {
        return this.\u003Cbacking_store\u003EApplicationId;
      }
      set
      {
        this.\u003Cbacking_store\u003EApplicationId = value;
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
