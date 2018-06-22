// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.DirectoryList
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Collections.Generic;
using System.IO;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class DirectoryList
  {
    private HashSet<string> directories = new HashSet<string>();

    public void AddAncestors(string directoryPath)
    {
      string path = directoryPath;
      while (path != null && !(path == string.Empty) && !this.directories.Add(path.Replace("\\", "/")))
        path = Path.GetDirectoryName(path);
    }

    public int Count
    {
      get
      {
        return this.directories.Count;
      }
    }
  }
}
