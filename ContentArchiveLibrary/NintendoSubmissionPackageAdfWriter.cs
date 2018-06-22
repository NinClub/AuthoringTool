// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoSubmissionPackageAdfWriter
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoSubmissionPackageAdfWriter
  {
    private string m_adfPath;

    public NintendoSubmissionPackageAdfWriter(string adfPath)
    {
      this.m_adfPath = adfPath;
    }

    private void WriteContentInfo(StreamWriter writer, int index, List<Pair<string, string>> contentPaths, string contentType, string metaFilePath, string descFilePath, int keyAreaEncryptionKeyIndex, List<Pair<FilterType, Regex>> filterRules)
    {
      if (contentPaths.Count <= 0)
        return;
      if ((File.GetAttributes(contentPaths[0].first) & FileAttributes.Directory) != FileAttributes.Directory)
      {
        writer.WriteLine("      - type : file");
        writer.WriteLine("        contentType : {0}", (object) contentType);
        writer.WriteLine("        path : {0}", (object) contentPaths[0].first);
      }
      else
      {
        string adfPath = Path.GetFullPath(Path.GetDirectoryName(this.m_adfPath)) + "\\" + Path.GetFileNameWithoutExtension(this.m_adfPath) + ".c" + (object) index + "." + contentType + ".nca.adf";
        new NintendoContentAdfWriter(adfPath, contentType, metaFilePath, descFilePath, keyAreaEncryptionKeyIndex).Write(contentPaths, filterRules);
        writer.WriteLine("      - type : format");
        writer.WriteLine("        contentType : {0}", (object) contentType);
        writer.WriteLine("        path : {0}", (object) adfPath);
      }
    }

    public void Write(List<NintendoSubmissionPackageContentInfo> contentInfos)
    {
      this.Write(contentInfos, (List<Pair<FilterType, Regex>>) null);
    }

    public void Write(List<NintendoSubmissionPackageContentInfo> contentInfos, List<Pair<FilterType, Regex>> filterRules)
    {
      StreamWriter adf = new StreamWriter(this.m_adfPath, false, Encoding.UTF8);
      try
      {
        adf.WriteLine("formatType : NintendoSubmissionPackage");
        adf.WriteLine("version : 0");
        adf.WriteLine("entries :");
        for (int index = 0; index < contentInfos.Count; ++index)
        {
          adf.WriteLine("  - contents :");
          int keyAreaEncryptionKeyIndex = contentInfos[index].KeyAreaEncryptionKeyIndex == -1 ? (contentInfos[index].MetaType == "Application" || contentInfos[index].MetaType == "Patch" || contentInfos[index].MetaType == "AddOnContent" ? 0 : 1) : contentInfos[index].KeyAreaEncryptionKeyIndex;
          foreach (NintendoSubmissionPackageContentResource resource in contentInfos[index].ResourceList)
            this.WriteContentInfo(adf, 0, resource.PathList, resource.ContentType, contentInfos[index].MetaFilePath, contentInfos[index].DescFilePath, keyAreaEncryptionKeyIndex, filterRules);
          adf.WriteLine("    metaType : {0}", (object) contentInfos[index].MetaType);
          adf.WriteLine("    metaFilePath : {0}", (object) contentInfos[index].MetaFilePath);
          adf.WriteLine("    nxIconMaxSize: {0}", (object) contentInfos[index].NxIconMaxSize);
          adf.WriteLine("    keyIndex : {0}", (object) keyAreaEncryptionKeyIndex);
          if (contentInfos[index].IconList.Count > 0)
          {
            adf.WriteLine("    icon:");
            contentInfos[index].IconList.ForEach((Action<Tuple<string, string>>) (info =>
            {
              adf.WriteLine("        - language: {0}", (object) info.Item1);
              adf.WriteLine("          path: {0}", (object) info.Item2);
            }));
          }
          if (contentInfos[index].NxIconList.Count > 0)
          {
            adf.WriteLine("    nxIcon:");
            contentInfos[index].NxIconList.ForEach((Action<Tuple<string, string>>) (info =>
            {
              adf.WriteLine("        - language: {0}", (object) info.Item1);
              adf.WriteLine("          path: {0}", (object) info.Item2);
            }));
          }
        }
      }
      finally
      {
        if (adf != null)
          adf.Dispose();
      }
    }
  }
}
