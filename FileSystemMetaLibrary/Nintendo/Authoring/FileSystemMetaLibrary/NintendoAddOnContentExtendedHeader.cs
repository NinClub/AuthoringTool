// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoAddOnContentExtendedHeader
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoAddOnContentExtendedHeader : NintendoExtendedHeader
  {
    private ulong \u003Cbacking_store\u003EApplicationId;
    private uint \u003Cbacking_store\u003ERequiredApplicationVersion;
    private string \u003Cbacking_store\u003ETag;

    public NintendoAddOnContentExtendedHeader(ulong applicationId, uint requiredApplicationVersion, string tag)
    {
      this.\u003Cbacking_store\u003EApplicationId = applicationId;
      this.\u003Cbacking_store\u003ERequiredApplicationVersion = requiredApplicationVersion;
      this.\u003Cbacking_store\u003ETag = tag;
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

    public uint RequiredApplicationVersion
    {
      get
      {
        return this.\u003Cbacking_store\u003ERequiredApplicationVersion;
      }
      set
      {
        this.\u003Cbacking_store\u003ERequiredApplicationVersion = value;
      }
    }

    public string Tag
    {
      get
      {
        return this.\u003Cbacking_store\u003ETag;
      }
      set
      {
        this.\u003Cbacking_store\u003ETag = value;
      }
    }
  }
}
