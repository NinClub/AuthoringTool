// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.OptionUtil
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nintendo.Authoring.AuthoringTool
{
  internal class OptionUtil
  {
    public static string GetOutputFilePath(string defaultStr, string argStr)
    {
      string empty = string.Empty;
      string path = argStr.Replace("\\", "/");
      if (!Path.IsPathRooted(path))
        path = "./" + path;
      return !Directory.Exists(path) || (File.GetAttributes(path) & FileAttributes.Directory) != FileAttributes.Directory ? (!path.EndsWith("/") ? path : path + defaultStr.Substring(2)) : path + defaultStr.Substring(1);
    }

    public static string CheckAndNormalizeFilePath(string path, string optionName)
    {
      string path1 = path.Replace("\\", "/");
      if (!Path.IsPathRooted(path1))
        path1 = "./" + path1;
      if ((File.GetAttributes(path1) & FileAttributes.Directory) == FileAttributes.Directory)
        throw new InvalidOptionException(string.Format("file path should be specified for {0}.", (object) optionName));
      return path1;
    }

    public static OptionDescription CreateFilePathOptionDescription(string longName, OptionUtil.PathSetter setter)
    {
      return new OptionDescription(longName, (string) null, 1, (Action<List<string>>) (s => setter(OptionUtil.CheckAndNormalizeFilePath(s.First<string>(), longName))));
    }

    internal static List<Tuple<string, string>> CreateIconFileList(List<string> languageAndPathList)
    {
      List<Tuple<string, string>> tupleList = new List<Tuple<string, string>>();
      int index = 0;
      while (index < languageAndPathList.Count)
      {
        string languageAndPath = languageAndPathList[index];
        string path = languageAndPathList[index + 1].Replace("\\", "/");
        if (!Path.IsPathRooted(path))
          path = "./" + path;
        if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
          throw new InvalidOptionException("file path should be specified for --icon option.");
        tupleList.Add(Tuple.Create<string, string>(languageAndPath, path));
        index += 2;
      }
      return tupleList;
    }

    internal delegate void PathSetter(string path);
  }
}
