// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Connection
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Connection
  {
    public ISource Source { get; set; }

    public ISink Sink { get; set; }

    public Connection(ISource source, ISink sink)
    {
      this.Source = source;
      this.Sink = sink;
    }
  }
}
