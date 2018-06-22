// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SinkStatus
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SinkStatus
  {
    public RangeList FilledRangeList { get; set; }

    public bool IsFilled { get; set; }

    public SinkStatus()
    {
      this.FilledRangeList = new RangeList();
      this.IsFilled = false;
    }
  }
}
