// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentFileSystemInfo
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoContentFileSystemInfo : FileSystemInfo
  {
    public byte contentType;
    public byte distributionType;
    public byte keyGeneration;
    public byte keyAreaEncryptionKeyIndex;
    public ulong contentSize;
    public ulong programId;
    public uint contentIndex;
    public uint sdkAddonVersion;
    public int numFsEntries;
    public List<NintendoContentFileSystemInfo.EntryInfo> fsEntries;
    public byte[] encryptedKey;
    public byte[] header2SignKeyModulus;
    public byte[] header2SignKeyPublicExponent;
    public byte[] header2SignKeyPrivateExponent;
    public bool isProdEncryption;

    public NintendoContentFileSystemInfo()
    {
      this.fsEntries = new List<NintendoContentFileSystemInfo.EntryInfo>();
      this.encryptedKey = new byte[256];
      this.isProdEncryption = false;
      this.distributionType = (byte) 0;
      GC.KeepAlive((object) this);
    }

    public struct EntryInfo
    {
      public string type;
      public string formatType;
      public string partitionType;
      public int partitionIndex;
      public ushort version;
      public byte hashType;
      public byte encryptionType;
      public FileSystemInfo fileSystemInfo;
      public SourceInterface sourceInterface;
      public ulong startOffset;
      public ulong endOffset;
      public ulong hashDataSize;
      public ulong hashTargetOffset;
      public ulong hashTargetSize;
    }
  }
}
