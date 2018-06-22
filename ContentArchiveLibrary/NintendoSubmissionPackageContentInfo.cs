// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoSubmissionPackageContentInfo
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoSubmissionPackageContentInfo
  {
    public const uint DefaultNxIconMaxSize = 102400;

    public string MetaType { get; set; }

    public string MetaFilePath { get; set; }

    public string DescFilePath { get; set; }

    public int KeyAreaEncryptionKeyIndex { get; set; }

    public List<NintendoSubmissionPackageContentResource> ResourceList { get; set; }

    public List<Tuple<string, string>> IconList { get; set; }

    public List<Tuple<string, string>> NxIconList { get; set; }

    public uint NxIconMaxSize { get; set; }

    public NintendoSubmissionPackageContentInfo()
    {
      this.ResourceList = new List<NintendoSubmissionPackageContentResource>();
      this.IconList = new List<Tuple<string, string>>();
      this.NxIconList = new List<Tuple<string, string>>();
      this.NxIconMaxSize = 102400U;
      this.KeyAreaEncryptionKeyIndex = -1;
    }

    public NintendoSubmissionPackageContentResource GetResource(string contentType)
    {
      foreach (NintendoSubmissionPackageContentResource resource in this.ResourceList)
      {
        if (resource.ContentType.Equals(contentType))
          return resource;
      }
      return (NintendoSubmissionPackageContentResource) null;
    }

    public bool HasResource(string contentType)
    {
      return this.GetResource(contentType) != null;
    }
  }
}
