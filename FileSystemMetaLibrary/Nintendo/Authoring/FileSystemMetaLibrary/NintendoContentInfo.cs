// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentInfo
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Diagnostics;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoContentInfo
  {
    private string \u003Cbacking_store\u003EType;
    private byte[] \u003Cbacking_store\u003EId;
    private long \u003Cbacking_store\u003ESize;
    private byte[] \u003Cbacking_store\u003EHash;

    public NintendoContentInfo(string type, byte[] id, long size, byte[] hash)
    {
      Debug.Assert(id.Length == 16);
      Debug.Assert(hash.Length == 32);
      this.\u003Cbacking_store\u003EType = type;
      this.\u003Cbacking_store\u003EId = id;
      this.\u003Cbacking_store\u003ESize = size;
      this.\u003Cbacking_store\u003EHash = hash;
      GC.KeepAlive((object) this);
    }

    public NintendoContentInfo(string type, long size)
    {
      this.\u003Cbacking_store\u003EType = type;
      this.\u003Cbacking_store\u003ESize = size;
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

    public byte[] Id
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

    public long Size
    {
      get
      {
        return this.\u003Cbacking_store\u003ESize;
      }
      set
      {
        this.\u003Cbacking_store\u003ESize = value;
      }
    }

    public byte[] Hash
    {
      get
      {
        return this.\u003Cbacking_store\u003EHash;
      }
      set
      {
        this.\u003Cbacking_store\u003EHash = value;
      }
    }
  }
}
