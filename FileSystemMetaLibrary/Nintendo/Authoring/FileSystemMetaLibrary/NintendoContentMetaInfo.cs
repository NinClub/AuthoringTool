// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentMetaInfo
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoContentMetaInfo
  {
    private string \u003Cbacking_store\u003EType;
    private ulong \u003Cbacking_store\u003EId;
    private uint \u003Cbacking_store\u003EVersion;
    private byte \u003Cbacking_store\u003EAttributes;

    public NintendoContentMetaInfo(string type, ulong id, uint version, byte attributes)
    {
      this.\u003Cbacking_store\u003EId = id;
      this.\u003Cbacking_store\u003EVersion = version;
      this.\u003Cbacking_store\u003EType = type;
      this.\u003Cbacking_store\u003EAttributes = attributes;
      GC.KeepAlive((object) this);
    }

    public string Type
    {
      get
      {
        return this.\u003Cbacking_store\u003EType;
      }
      set
      {
        this.\u003Cbacking_store\u003EType = value;
      }
    }

    public ulong Id
    {
      get
      {
        return this.\u003Cbacking_store\u003EId;
      }
      set
      {
        this.\u003Cbacking_store\u003EId = value;
      }
    }

    public uint Version
    {
      get
      {
        return this.\u003Cbacking_store\u003EVersion;
      }
      set
      {
        this.\u003Cbacking_store\u003EVersion = value;
      }
    }

    public byte Attributes
    {
      get
      {
        return this.\u003Cbacking_store\u003EAttributes;
      }
      set
      {
        this.\u003Cbacking_store\u003EAttributes = value;
      }
    }
  }
}
