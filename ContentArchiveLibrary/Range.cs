// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Range
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Range
  {
    public long Offset { get; private set; }

    public long Size { get; private set; }

    public long End
    {
      get
      {
        return this.Offset + this.Size;
      }
    }

    public Range(long offset, long size)
    {
      this.Offset = offset;
      this.Size = size;
    }

    internal void SetSize(long size)
    {
      this.Size = size;
    }
  }
}
