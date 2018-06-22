// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ContentHashSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ContentHashSource
  {
    public ISource Source { get; private set; }

    public string Extension { get; private set; }

    public string ContentType { get; private set; }

    public ContentHashSource(ISource source, string extension, string contentType)
    {
      this.Source = source;
      this.Extension = extension;
      this.ContentType = contentType;
    }

    public ContentHashSource(ISource source, string extension)
      : this(source, extension, string.Empty)
    {
    }
  }
}
