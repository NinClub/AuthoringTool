// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.FileSystemMetaLibrary.NintendoContentArchiveFsHeaderInfo
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using nn.fssystem;
using System;

namespace Nintendo.Authoring.FileSystemMetaLibrary
{
  public class NintendoContentArchiveFsHeaderInfo
  {
    private ushort m_Version;
    private byte m_FsType;
    private byte m_HashType;
    private byte m_EncryptionType;

    public ushort GetVersion()
    {
      return this.m_Version;
    }

    public string GetFormatType()
    {
      switch (this.m_FsType)
      {
        case 0:
          return "RomFs";
        case 1:
          return "PartitionFs";
        default:
          throw new ArgumentException("Invalid FsType.");
      }
    }

    public byte GetHashType()
    {
      return this.m_HashType;
    }

    public byte GetEncryptionType()
    {
      return this.m_EncryptionType;
    }

    internal unsafe NintendoContentArchiveFsHeaderInfo(NcaFsHeaderReader* fsHeaderReader)
    {
      this.m_Version = \u003CModule\u003E.nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetVersion(fsHeaderReader);
      this.m_FsType = (byte) \u003CModule\u003E.nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetFsType(fsHeaderReader);
      this.m_HashType = (byte) \u003CModule\u003E.nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetHashType(fsHeaderReader);
      this.m_EncryptionType = (byte) \u003CModule\u003E.nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetEncryptionType(fsHeaderReader);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      GC.KeepAlive((object) this);
    }

    public NintendoContentArchiveFsHeaderInfo()
    {
    }
  }
}
