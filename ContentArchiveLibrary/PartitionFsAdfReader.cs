// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.PartitionFsAdfReader
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.RepresentationModel;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class PartitionFsAdfReader
  {
    private string m_adfPath;

    public PartitionFsAdfReader(string adfPath)
    {
      this.m_adfPath = adfPath;
    }

    public PartitionFileSystemInfo GetFileSystemInfo()
    {
      PartitionFileSystemInfo partitionFileSystemInfo = new PartitionFileSystemInfo();
      using (StreamReader streamReader = new StreamReader(this.m_adfPath, Encoding.UTF8))
      {
        YamlStream yamlStream = new YamlStream();
        yamlStream.Load((TextReader) streamReader);
        YamlMappingNode rootNode;
        try
        {
          rootNode = (YamlMappingNode) yamlStream.Documents[0].RootNode;
          if (((YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("formatType")]).Value != "PartitionFs")
            throw new ArgumentException();
        }
        catch
        {
          throw new ArgumentException("invalid format .adf file.");
        }
        YamlSequenceNode child;
        try
        {
          child = (YamlSequenceNode) rootNode.Children[(YamlNode) new YamlScalarNode("entries")];
        }
        catch
        {
          throw new ArgumentException("invalid format .adf file. no \"entries\"");
        }
        foreach (YamlMappingNode yamlMappingNode in child)
        {
          PartitionFileSystemInfo.EntryInfo entryInfo = new PartitionFileSystemInfo.EntryInfo();
          foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair in yamlMappingNode)
          {
            string str = ((YamlScalarNode) keyValuePair.Key).Value;
            if (!(str == "type"))
            {
              if (!(str == "name"))
              {
                if (!(str == "offset"))
                {
                  if (!(str == "path"))
                    throw new ArgumentException("invalid format .adf file. invalid key is specified\n" + yamlMappingNode.ToString());
                  entryInfo.path = ((YamlScalarNode) keyValuePair.Value).Value;
                }
                else
                  entryInfo.offset = Convert.ToUInt64(((YamlScalarNode) keyValuePair.Value).Value);
              }
              else
                entryInfo.name = ((YamlScalarNode) keyValuePair.Value).Value;
            }
            else
              entryInfo.type = ((YamlScalarNode) keyValuePair.Value).Value;
          }
          if (entryInfo.type == null || entryInfo.name == null || entryInfo.path == null)
            throw new ArgumentException("invalid format .adf file. \"type\" or \"name\" or \"path\" is not specified.\n" + yamlMappingNode.ToString());
          if (entryInfo.type != "file")
            throw new ArgumentException("invalid format .adf file. \"type\" should be \"file\".\n" + yamlMappingNode.ToString());
          FileInfo fileInfo = new FileInfo(entryInfo.path);
          entryInfo.size = (ulong) fileInfo.Length;
          partitionFileSystemInfo.entries.Add(entryInfo);
        }
      }
      return partitionFileSystemInfo;
    }
  }
}
