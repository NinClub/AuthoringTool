// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.IdConverter
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class IdConverter
  {
    public static ulong ConvertToPatchId(ulong applicationId)
    {
      return applicationId + 2048UL;
    }

    public static ulong ConvertToAocBaseId(ulong applicationId)
    {
      return applicationId + 4096UL;
    }
  }
}
