// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoSubmissionPackageAdfReader
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.RepresentationModel;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoSubmissionPackageAdfReader
  {
    private string m_adfPath;

    public NintendoSubmissionPackageAdfReader(string adfPath)
    {
      this.m_adfPath = adfPath;
    }

    public NintendoSubmissionPackageFileSystemInfo GetFileSystemInfo()
    {
      NintendoSubmissionPackageFileSystemInfo packageFileSystemInfo = new NintendoSubmissionPackageFileSystemInfo();
      using (StreamReader streamReader = new StreamReader(this.m_adfPath, Encoding.UTF8))
      {
        YamlStream yamlStream = new YamlStream();
        yamlStream.Load((TextReader) streamReader);
        YamlSequenceNode child1;
        try
        {
          YamlMappingNode rootNode = (YamlMappingNode) yamlStream.Documents[0].RootNode;
          if (((YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("formatType")]).Value != "NintendoSubmissionPackage")
            throw new ArgumentException();
          YamlScalarNode child2 = (YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("version")];
          child1 = (YamlSequenceNode) rootNode.Children[(YamlNode) new YamlScalarNode("entries")];
          packageFileSystemInfo.Version = Convert.ToByte(child2.Value);
        }
        catch
        {
          throw new ArgumentException("invalid format .adf file.");
        }
        foreach (YamlMappingNode yamlMappingNode1 in child1)
        {
          NintendoSubmissionPackageFileSystemInfo.EntryInfo entryInfo = new NintendoSubmissionPackageFileSystemInfo.EntryInfo();
          entryInfo.Contents = new List<NintendoSubmissionPackageFileSystemInfo.ContentInfo>();
          YamlNode child2 = yamlMappingNode1.Children[(YamlNode) new YamlScalarNode("contents")];
          if (child2 is YamlSequenceNode)
          {
            foreach (YamlMappingNode yamlMappingNode2 in (YamlSequenceNode) child2)
            {
              NintendoSubmissionPackageFileSystemInfo.ContentInfo contentInfo = new NintendoSubmissionPackageFileSystemInfo.ContentInfo();
              string empty1 = string.Empty;
              string empty2 = string.Empty;
              foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair in yamlMappingNode2)
              {
                string str = ((YamlScalarNode) keyValuePair.Key).Value;
                if (!(str == "type"))
                {
                  if (!(str == "contentType"))
                  {
                    if (!(str == "path"))
                      throw new ArgumentException("invalid format .adf file. invalid key is specified\n" + yamlMappingNode2.ToString());
                    empty2 = ((YamlScalarNode) keyValuePair.Value).Value;
                  }
                  else
                    contentInfo.ContentType = ((YamlScalarNode) keyValuePair.Value).Value;
                }
                else
                  empty1 = ((YamlScalarNode) keyValuePair.Value).Value;
              }
              if (empty2 == null)
                throw new ArgumentException("invalid format .adf file. \"path\" is not specified\n" + yamlMappingNode2.ToString());
              if (empty1 == "format")
              {
                NintendoContentAdfReader contentAdfReader = new NintendoContentAdfReader(empty2);
                contentInfo.FsInfo = (Nintendo.Authoring.FileSystemMetaLibrary.FileSystemInfo) contentAdfReader.GetFileSystemInfo();
              }
              else
              {
                if (!(empty1 == "file"))
                  throw new ArgumentException("invalid format .adf file. unknown \"type\" is specified\n" + yamlMappingNode2.ToString());
                FileInfo fileInfo = new FileInfo(empty2);
                contentInfo.Source = (ISource) new FileSource(empty2, 0L, fileInfo.Length);
              }
              entryInfo.Contents.Add(contentInfo);
            }
          }
          List<Tuple<string, string>> iconList = new List<Tuple<string, string>>();
          List<Tuple<string, string>> nxIconList = new List<Tuple<string, string>>();
          uint maxNxIconSize = 102400;
          foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair in yamlMappingNode1)
          {
            switch (((YamlScalarNode) keyValuePair.Key).Value)
            {
              case "contents":
                continue;
              case "icon":
                using (IEnumerator<YamlNode> enumerator = ((YamlSequenceNode) keyValuePair.Value).GetEnumerator())
                {
                  while (enumerator.MoveNext())
                  {
                    YamlMappingNode current = (YamlMappingNode) enumerator.Current;
                    string str1 = ((YamlScalarNode) current.Children[(YamlNode) new YamlScalarNode("language")]).Value;
                    string str2 = ((YamlScalarNode) current.Children[(YamlNode) new YamlScalarNode("path")]).Value;
                    iconList.Add(new Tuple<string, string>(str1, str2));
                  }
                  continue;
                }
              case "keyIndex":
                entryInfo.KeyIndex = int.Parse(((YamlScalarNode) keyValuePair.Value).Value);
                continue;
              case "metaFilePath":
                entryInfo.MetaFilePath = ((YamlScalarNode) keyValuePair.Value).Value;
                continue;
              case "metaType":
                entryInfo.MetaType = ((YamlScalarNode) keyValuePair.Value).Value;
                continue;
              case "nxIcon":
                using (IEnumerator<YamlNode> enumerator = ((YamlSequenceNode) keyValuePair.Value).GetEnumerator())
                {
                  while (enumerator.MoveNext())
                  {
                    YamlMappingNode current = (YamlMappingNode) enumerator.Current;
                    string str1 = ((YamlScalarNode) current.Children[(YamlNode) new YamlScalarNode("language")]).Value;
                    string str2 = ((YamlScalarNode) current.Children[(YamlNode) new YamlScalarNode("path")]).Value;
                    nxIconList.Add(new Tuple<string, string>(str1, str2));
                  }
                  continue;
                }
              case "nxIconMaxSize":
                maxNxIconSize = uint.Parse(((YamlScalarNode) keyValuePair.Value).Value);
                continue;
              default:
                throw new ArgumentException("invalid format .adf file. invalid key is specified\n" + yamlMappingNode1.ToString());
            }
          }
          if (entryInfo.MetaFilePath == null)
            throw new ArgumentException();
          Tuple<int, int> cardSpec = new DotMetaReader(entryInfo.MetaFilePath).GetCardSpec();
          if (cardSpec != null)
          {
            packageFileSystemInfo.CardSize = cardSpec.Item1;
            packageFileSystemInfo.CardClockRate = cardSpec.Item2;
          }
          else
            Log.Info("\"CardSpec\" is not specified by .meta file. Size and ClockRate will be calculated automatically.");
          entryInfo.ExtraData = this.CreateExtraSource(iconList, nxIconList, maxNxIconSize);
          packageFileSystemInfo.Entries.Add(entryInfo);
        }
      }
      return packageFileSystemInfo;
    }

    private List<NintendoSubmissionPackageExtraData> CreateExtraSource(List<Tuple<string, string>> iconList, List<Tuple<string, string>> nxIconList, uint maxNxIconSize)
    {
      Dictionary<string, Tuple<string, string>> mergedIconPathMap = IconConverter.GetMergedIconPathMap(iconList, nxIconList);
      List<NintendoSubmissionPackageExtraData> packageExtraDataList = new List<NintendoSubmissionPackageExtraData>();
      foreach (KeyValuePair<string, Tuple<string, string>> keyValuePair in mergedIconPathMap)
      {
        string key = keyValuePair.Key;
        Tuple<string, string> tuple1 = keyValuePair.Value;
        Tuple<byte[], byte[]> tuple2 = IconConverter.Convert(tuple1.Item1, tuple1.Item2, maxNxIconSize);
        packageExtraDataList.Add(new NintendoSubmissionPackageExtraData(string.Format("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.raw.{0}.jpg", (object) key), (ISource) new MemorySource(tuple2.Item1, 0, tuple2.Item1.Length)));
        packageExtraDataList.Add(new NintendoSubmissionPackageExtraData(string.Format("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nx.{0}.jpg", (object) key), (ISource) new MemorySource(tuple2.Item2, 0, tuple2.Item2.Length)));
      }
      return packageExtraDataList;
    }
  }
}
