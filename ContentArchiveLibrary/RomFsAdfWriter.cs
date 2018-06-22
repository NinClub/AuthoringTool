// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.RomFsAdfWriter
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
  public class RomFsAdfWriter
  {
    private const int AlignmentSize = 16;
    private string m_adfPath;
    private bool m_IsAdfWritten;

    public RomFsAdfWriter(string adfPath)
    {
      this.m_adfPath = adfPath;
      this.m_IsAdfWritten = false;
    }

    public void Write(string dirPath)
    {
      this.Write(new List<Pair<string, string>>()
      {
        new Pair<string, string>(dirPath, (string) null)
      }, (List<Pair<FilterType, Regex>>) null);
    }

    public void Write(string dirPath, List<Pair<FilterType, Regex>> filterRules)
    {
      this.Write(new List<Pair<string, string>>()
      {
        new Pair<string, string>(dirPath, (string) null)
      }, filterRules);
    }

    public void Write(Pair<string, string> dirPath, List<Pair<FilterType, Regex>> filterRules)
    {
      this.Write(new List<Pair<string, string>>()
      {
        dirPath
      }, filterRules);
    }

    public void Write(List<Pair<string, string>> dirPaths, List<Pair<FilterType, Regex>> filterRules)
    {
      if (this.m_IsAdfWritten)
        throw new InvalidOperationException("RomFs Adf can be written only once.");
      MemoryStream memoryStream = new MemoryStream();
      using (StreamWriter streamWriter = new StreamWriter((Stream) memoryStream, Encoding.UTF8))
      {
        streamWriter.WriteLine("formatType : RomFs");
        streamWriter.WriteLine("version : 0");
        streamWriter.WriteLine("entries :");
        List<Pair<Pair<string, string>, string>> pairList = new List<Pair<Pair<string, string>, string>>();
        foreach (Pair<string, string> dirPath in dirPaths)
        {
          foreach (string enumerateFile in Directory.EnumerateFiles(dirPath.first, "*", SearchOption.AllDirectories))
          {
            if (filterRules == null || !FilterDescription.IsEntryInFilterList(enumerateFile, dirPath.first, filterRules))
              pairList.Add(new Pair<Pair<string, string>, string>(dirPath, enumerateFile));
          }
        }
        Func<Pair<Pair<string, string>, string>, string> functionGetPathName = (Func<Pair<Pair<string, string>, string>, string>) (file =>
        {
          Pair<string, string> first = file.first;
          string second = file.second;
          string str = "";
          if (first.second != null)
            str = first.second.Replace("\\", "/") + "/";
          return str + second.Replace("\\", "/").Replace(first.first + "/", string.Empty);
        });
        pairList.Sort((Comparison<Pair<Pair<string, string>, string>>) ((fileLeft, fileRight) => string.CompareOrdinal(functionGetPathName(fileLeft), functionGetPathName(fileRight))));
        long num = 0;
        foreach (Pair<Pair<string, string>, string> pair in pairList)
        {
          Pair<string, string> first = pair.first;
          string second = pair.second;
          streamWriter.WriteLine("  - type : file");
          streamWriter.WriteLine("    name : {0}", (object) functionGetPathName(pair));
          streamWriter.WriteLine("    offset : {0}", (object) num);
          FileInfo fileInfo = new FileInfo(second);
          num = num + fileInfo.Length + 15L & -16L;
          streamWriter.WriteLine("    path : {0}", (object) Path.GetFullPath(second.Replace("\\", "/")));
        }
      }
      using (FileStream fileStream = File.Open(this.m_adfPath, !File.Exists(this.m_adfPath) ? FileMode.CreateNew : FileMode.Truncate, FileAccess.Write, FileShare.None))
      {
        byte[] array = memoryStream.ToArray();
        fileStream.Write(array, 0, array.Length);
        this.m_IsAdfWritten = true;
      }
    }
  }
}
