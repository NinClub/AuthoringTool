// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentFileSystemEntryInfoContainer
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System.Collections;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoContentFileSystemEntryInfoContainer : IEnumerable<NintendoContentFileSystemInfo.EntryInfo>, IEnumerable
  {
    public System.Collections.Generic.List<NintendoContentFileSystemInfo.EntryInfo> List { get; private set; }

    public bool IsReverse { get; private set; }

    public int CurrentIndex { get; private set; }

    public NintendoContentFileSystemEntryInfoContainer(System.Collections.Generic.List<NintendoContentFileSystemInfo.EntryInfo> list)
    {
      this.List = list;
      this.IsReverse = 1 < list.Count;
      this.CurrentIndex = 0;
    }

    public IEnumerator<NintendoContentFileSystemInfo.EntryInfo> GetEnumerator()
    {
      if (this.IsReverse)
      {
        for (int i = this.List.Count - 1; 0 <= i; --i)
        {
          this.CurrentIndex = i;
          yield return this.List[i];
        }
      }
      else
      {
        for (int i = 0; i < this.List.Count; ++i)
        {
          this.CurrentIndex = i;
          yield return this.List[i];
        }
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public void Update(NintendoContentFileSystemInfo.EntryInfo entryInfo)
    {
      this.List[this.CurrentIndex] = entryInfo;
    }
  }
}
