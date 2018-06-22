// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ContentMetaAttributeExtension
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal static class ContentMetaAttributeExtension
  {
    public static ContentMetaAttribute FromStringList(IEnumerable<string> list)
    {
      ContentMetaAttribute contentMetaAttribute = ContentMetaAttribute.None;
      foreach (string str in list)
        contentMetaAttribute |= (ContentMetaAttribute) Enum.Parse(typeof (ContentMetaAttribute), str);
      return contentMetaAttribute;
    }

    public static List<string> ToStringList(this ContentMetaAttribute attributes)
    {
      List<string> stringList = new List<string>();
      if (attributes.HasFlag((Enum) ContentMetaAttribute.IncludesExFatDriver))
      {
        ContentMetaAttribute contentMetaAttribute = ContentMetaAttribute.IncludesExFatDriver;
        stringList.Add(contentMetaAttribute.ToString());
      }
      return stringList;
    }
  }
}
