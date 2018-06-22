// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NsoHeaderFlags
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public enum NsoHeaderFlags
  {
    TextCompress = 1,
    RoCompress = 2,
    DataCompress = 4,
    TextHash = 8,
    RoHash = 16, // 0x00000010
    DataHash = 32, // 0x00000020
  }
}
