// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Sha256PartitionFsHashSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Sha256PartitionFsHashSource
  {
    public ISource Source { get; private set; }

    public int Index { get; private set; }

    public Sha256PartitionFsHashSource(ISource source, int index)
    {
      this.Source = source;
      this.Index = index;
    }
  }
}
