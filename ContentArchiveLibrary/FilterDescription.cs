// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.FilterDescription
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class FilterDescription
  {
    private static string ToolWorkDirEnvStr = "AUTHORING_TOOL_WORK_DIR";
    private static Regex RegexKeywordEnv = new Regex("@<(?<envname>[^>]*)>");
    private static Regex RegexKeywordInclude = new Regex("#include *\"(?<path>[^\"]*)\"");

    private static string ReplaceEnvironmentVariableKeyword(string path)
    {
      MatchEvaluator evaluator = (MatchEvaluator) (x =>
      {
        if (x.Groups["envname"].Value == FilterDescription.ToolWorkDirEnvStr)
          return Environment.CurrentDirectory;
        return Environment.GetEnvironmentVariable(x.Groups["envname"].Value);
      });
      return FilterDescription.RegexKeywordEnv.Replace(path, evaluator);
    }

    public static string FormatFilePathDelimiterForFilter(string target)
    {
      return target.Replace("/", "\\");
    }

    private static string FormatFilePathDelimiterForFilterRegex(string target)
    {
      return target.Replace("/", "\\\\");
    }

    private static string NormalizePathForUri(string path)
    {
      path = Path.GetFullPath(path);
      if (!path.EndsWith("/") && !path.EndsWith("\\"))
        path += "\\";
      return path;
    }

    public static string FormatFilePathForFilter(string target, string rootDir)
    {
      string target1 = target;
      if (!string.IsNullOrEmpty(rootDir))
      {
        Uri uri1 = new Uri(FilterDescription.NormalizePathForUri(rootDir));
        Uri uri2 = new Uri(FilterDescription.NormalizePathForUri(target));
        if (uri1.Scheme == uri2.Scheme)
          target1 = Uri.UnescapeDataString(uri1.MakeRelativeUri(uri2).ToString());
      }
      return FilterDescription.FormatFilePathDelimiterForFilter(target1).TrimEnd('\\');
    }

    public static bool IsEntryInFilterList(string target, string rootDir, List<Pair<FilterType, Regex>> filterRuleList)
    {
      return FilterDescription.IsEntryInFilterList(FilterDescription.FormatFilePathForFilter(target, rootDir), filterRuleList);
    }

    public static bool IsEntryInFilterList(string target, List<Pair<FilterType, Regex>> filterRuleList)
    {
      if (filterRuleList == null)
        return false;
      bool flag = false;
      foreach (Pair<FilterType, Regex> filterRule in filterRuleList)
      {
        if (filterRule.second.IsMatch(target))
        {
          if (filterRule.first == FilterType.Remove)
            flag = true;
          else if (filterRule.first == FilterType.Exception)
            flag = false;
        }
      }
      return flag;
    }

    private static List<Pair<FilterType, Regex>> ParseFdfRecursively(string fdfPath, ref List<string> fdfPathList)
    {
      fdfPath = FilterDescription.FormatFilePathDelimiterForFilter(fdfPath);
      if (!Path.IsPathRooted(fdfPath) && fdfPathList.Count > 0)
        fdfPath = Path.Combine(Path.GetDirectoryName(fdfPathList[fdfPathList.Count - 1]), fdfPath);
      fdfPath = Path.GetFullPath(fdfPath).TrimEnd('\\');
      if (0 <= fdfPathList.FindIndex((Predicate<string>) (path => string.Compare(path, fdfPath, StringComparison.InvariantCultureIgnoreCase) == 0)))
        return new List<Pair<FilterType, Regex>>();
      fdfPathList.Add(fdfPath);
      List<Pair<FilterType, Regex>> pairList = new List<Pair<FilterType, Regex>>();
      using (StreamReader streamReader = new StreamReader(fdfPath))
      {
        while (!streamReader.EndOfStream)
        {
          string path = streamReader.ReadLine();
          if (!string.IsNullOrEmpty(path) && !path.StartsWith(";"))
          {
            string input = FilterDescription.ReplaceEnvironmentVariableKeyword(path);
            Match match = FilterDescription.RegexKeywordInclude.Match(input);
            if (match.Success)
            {
              string fdfPath1 = match.Groups["path"].Value;
              pairList.AddRange((IEnumerable<Pair<FilterType, Regex>>) FilterDescription.ParseFdfRecursively(fdfPath1, ref fdfPathList));
            }
            FilterType a;
            switch (input[0])
            {
              case '+':
                a = FilterType.Exception;
                break;
              case '-':
                a = FilterType.Remove;
                break;
              default:
                continue;
            }
            Regex b = new Regex(FilterDescription.FormatFilePathDelimiterForFilterRegex(input.Substring(1).Trim().Trim('"')), RegexOptions.Compiled);
            pairList.Add(new Pair<FilterType, Regex>(a, b));
          }
        }
        return pairList;
      }
    }

    public static List<Pair<FilterType, Regex>> ParseFdf(string fdfPath)
    {
      List<string> fdfPathList = new List<string>();
      if (fdfPath == null)
        return (List<Pair<FilterType, Regex>>) null;
      return FilterDescription.ParseFdfRecursively(fdfPath, ref fdfPathList);
    }
  }
}
