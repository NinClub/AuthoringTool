// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.RomFsAdfReader
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
  public class RomFsAdfReader
  {
    private string m_adfPath;

    public RomFsAdfReader(string adfPath)
    {
      this.m_adfPath = adfPath;
    }

    public RomFsFileSystemInfo GetFileSystemInfo()
    {
      RomFsFileSystemInfo fsFileSystemInfo = new RomFsFileSystemInfo();
      using (StreamReader streamReader = new StreamReader(this.m_adfPath, Encoding.UTF8))
      {
        YamlStream yamlStream = new YamlStream();
        yamlStream.Load((TextReader) streamReader);
        YamlMappingNode rootNode;
        try
        {
          rootNode = (YamlMappingNode) yamlStream.Documents[0].RootNode;
          if (((YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("formatType")]).Value != "RomFs")
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
          throw new ArgumentException("invalid format .adf file. At least one file must be included in the data region.");
        }
        DirectoryList directoryList = new DirectoryList();
        foreach (YamlMappingNode yamlMappingNode in child)
        {
          RomFsFileSystemInfo.EntryInfo entryInfo = new RomFsFileSystemInfo.EntryInfo();
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
                entryInfo.name = "/" + ((YamlScalarNode) keyValuePair.Value).Value;
            }
            else
              entryInfo.type = ((YamlScalarNode) keyValuePair.Value).Value;
          }
          if (entryInfo.type == null)
            throw new ArgumentException("invalid format .adf file. invalid \"type\"\n" + yamlMappingNode.ToString());
          if (entryInfo.type == "file" && (entryInfo.name == null || entryInfo.path == null))
            throw new ArgumentException("invalid format .adf file. \"type == file\" but \"name\" or \"path\" is not specified.\n" + yamlMappingNode.ToString());
          if (entryInfo.type == "directory" && entryInfo.name == null)
            throw new ArgumentException("invalid format .adf file. \"type == directory\" but \"name\" is not specified.\n" + yamlMappingNode.ToString());
          if (entryInfo.type == "file")
          {
            FileInfo fileInfo = new FileInfo(entryInfo.path);
            entryInfo.size = (ulong) fileInfo.Length;
            fsFileSystemInfo.entries.Add(entryInfo);
            ++fsFileSystemInfo.fileEntryCount;
            directoryList.AddAncestors(Path.GetDirectoryName(entryInfo.name));
          }
          else
          {
            if (!(entryInfo.type == "directory"))
              throw new ArgumentException("invalid format .adf file. \"type\" should be \"directory\" or \"file\".\n" + yamlMappingNode.ToString());
            fsFileSystemInfo.entries.Add(entryInfo);
            directoryList.AddAncestors(entryInfo.name);
          }
        }
        fsFileSystemInfo.directoryEntryCount = directoryList.Count;
      }
      return fsFileSystemInfo;
    }
  }
}
