// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentAdfReader
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using YamlDotNet.RepresentationModel;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoContentAdfReader
  {
    private string m_adfPath;

    public NintendoContentAdfReader(string adfPath)
    {
      this.m_adfPath = adfPath;
    }

    internal byte ConvertToContentTypeByte(string contentType)
    {
      if (contentType == "Program")
        return 0;
      if (contentType == "Control")
        return 2;
      if (contentType == "Data")
        return 4;
      if (contentType == "Meta")
        return 1;
      if (contentType == "HtmlDocument" || contentType == "LegalInformation")
        return 3;
      throw new ArgumentException();
    }

    internal byte[] ReadAcid(string npdmPath)
    {
      byte[] buffer1;
      using (FileStream fileStream = new FileStream(npdmPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan))
      {
        byte[] buffer2 = new byte[128];
        fileStream.Read(buffer2, 0, buffer2.Length);
        uint uint32_1 = BitConverter.ToUInt32(buffer2, 120);
        uint uint32_2 = BitConverter.ToUInt32(buffer2, 124);
        buffer1 = new byte[(int) uint32_2];
        fileStream.Seek((long) uint32_1, SeekOrigin.Begin);
        fileStream.Read(buffer1, 0, (int) uint32_2);
      }
      return buffer1;
    }

    private int GetPartitionIndex(string partitionType)
    {
      if (partitionType == "code")
        return 0;
      if (partitionType == "data")
        return 1;
      if (partitionType == "logo")
        return 2;
      throw new ArgumentException("Invalid partition type: " + partitionType.ToString());
    }

    public static byte[] RetrieveInfoFromDesc(ref NintendoContentFileSystemInfo fileSystemInfo, string descFilePath)
    {
      byte[] numArray = (byte[]) null;
      if (descFilePath != null)
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(descFilePath);
        numArray = Convert.FromBase64String(xmlDocument.DocumentElement.SelectSingleNode("/Desc/Acid").InnerText);
        try
        {
          fileSystemInfo.header2SignKeyModulus = Convert.FromBase64String(xmlDocument.DocumentElement.SelectSingleNode("/Desc/RSAKeyValue/Modulus").InnerText);
          fileSystemInfo.header2SignKeyPrivateExponent = Convert.FromBase64String(xmlDocument.DocumentElement.SelectSingleNode("/Desc/RSAKeyValue/D").InnerText);
          fileSystemInfo.header2SignKeyPublicExponent = Convert.FromBase64String(xmlDocument.DocumentElement.SelectSingleNode("/Desc/RSAKeyValue/Exponent").InnerText);
        }
        catch
        {
          fileSystemInfo.header2SignKeyModulus = (byte[]) null;
          fileSystemInfo.header2SignKeyPrivateExponent = (byte[]) null;
          fileSystemInfo.header2SignKeyPublicExponent = (byte[]) null;
        }
      }
      return numArray;
    }

    public NintendoContentFileSystemInfo GetFileSystemInfo()
    {
      NintendoContentFileSystemInfo fileSystemInfo1 = new NintendoContentFileSystemInfo();
      using (StreamReader streamReader = new StreamReader(this.m_adfPath, Encoding.UTF8))
      {
        YamlStream yamlStream = new YamlStream();
        yamlStream.Load((TextReader) streamReader);
        YamlMappingNode rootNode;
        YamlSequenceNode child1;
        try
        {
          rootNode = (YamlMappingNode) yamlStream.Documents[0].RootNode;
          if (((YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("formatType")]).Value != "NintendoContent")
            throw new ArgumentException();
          YamlScalarNode child2 = (YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("contentType")];
          YamlScalarNode child3 = (YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("keyGeneration")];
          YamlScalarNode child4 = (YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("programId")];
          YamlScalarNode child5 = (YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("contentIndex")];
          child1 = (YamlSequenceNode) rootNode.Children[(YamlNode) new YamlScalarNode("entries")];
          fileSystemInfo1.contentType = this.ConvertToContentTypeByte(child2.Value);
          fileSystemInfo1.keyGeneration = Convert.ToByte(child3.Value);
          fileSystemInfo1.programId = Convert.ToUInt64(child4.Value, 16);
          fileSystemInfo1.contentIndex = Convert.ToUInt32(child5.Value);
        }
        catch
        {
          throw new ArgumentException("invalid format .adf file.");
        }
        try
        {
          YamlScalarNode child2 = (YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("keyAreaEncryptionKeyIndex")];
          fileSystemInfo1.keyAreaEncryptionKeyIndex = Convert.ToByte(child2.Value);
        }
        catch
        {
          fileSystemInfo1.keyAreaEncryptionKeyIndex = (byte) 0;
        }
        string descFilePath;
        if (fileSystemInfo1.contentType == (byte) 0)
        {
          try
          {
            descFilePath = ((YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("descFilePath")]).Value;
          }
          catch
          {
            throw new ArgumentException(".desc file is not specified for program content.");
          }
        }
        else
          descFilePath = (string) null;
        byte[] numArray = (byte[]) null;
        if (descFilePath != null)
          numArray = NintendoContentAdfReader.RetrieveInfoFromDesc(ref fileSystemInfo1, descFilePath);
        foreach (YamlMappingNode yamlMappingNode in child1)
        {
          NintendoContentFileSystemInfo.EntryInfo entryInfo1 = new NintendoContentFileSystemInfo.EntryInfo();
          string adfPath = (string) null;
          foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair in yamlMappingNode)
          {
            switch (((YamlScalarNode) keyValuePair.Key).Value)
            {
              case "encryptionType":
                entryInfo1.encryptionType = Convert.ToByte(((YamlScalarNode) keyValuePair.Value).Value);
                continue;
              case "formatType":
                entryInfo1.formatType = ((YamlScalarNode) keyValuePair.Value).Value;
                continue;
              case "hashType":
                entryInfo1.hashType = Convert.ToByte(((YamlScalarNode) keyValuePair.Value).Value);
                continue;
              case "partitionType":
                entryInfo1.partitionType = ((YamlScalarNode) keyValuePair.Value).Value;
                entryInfo1.partitionIndex = this.GetPartitionIndex(entryInfo1.partitionType);
                continue;
              case "path":
                adfPath = ((YamlScalarNode) keyValuePair.Value).Value;
                continue;
              case "type":
                entryInfo1.type = ((YamlScalarNode) keyValuePair.Value).Value;
                continue;
              case "version":
                entryInfo1.version = Convert.ToUInt16(((YamlScalarNode) keyValuePair.Value).Value);
                continue;
              default:
                throw new ArgumentException("invalid format .adf file. invalid key is specified\n" + yamlMappingNode.ToString());
            }
          }
          if (entryInfo1.type == null || entryInfo1.formatType == null || adfPath == null)
            throw new ArgumentException("invalid format .adf file. \"type\" or \"formatType\" is not specified\n" + yamlMappingNode.ToString());
          entryInfo1.version = (ushort) 2;
          entryInfo1.hashType = NintendoContentArchiveSource.VerifyHashType(fileSystemInfo1, entryInfo1);
          entryInfo1.encryptionType = NintendoContentArchiveSource.VerifyEncryptionType(fileSystemInfo1, entryInfo1);
          string formatType = entryInfo1.formatType;
          if (!(formatType == "PartitionFs"))
          {
            if (!(formatType == "RomFs"))
              throw new NotImplementedException("invalid format .adf file. invalid formatType." + yamlMappingNode.ToString());
            RomFsAdfReader romFsAdfReader = new RomFsAdfReader(adfPath);
            entryInfo1.fileSystemInfo = (Nintendo.Authoring.FileSystemMetaLibrary.FileSystemInfo) romFsAdfReader.GetFileSystemInfo();
          }
          else
          {
            PartitionFileSystemInfo fileSystemInfo2 = new PartitionFsAdfReader(adfPath).GetFileSystemInfo();
            if (numArray != null && entryInfo1.partitionType == "code")
            {
              IEnumerable<PartitionFileSystemInfo.EntryInfo> source = fileSystemInfo2.entries.Where<PartitionFileSystemInfo.EntryInfo>((Func<PartitionFileSystemInfo.EntryInfo, bool>) (p => p.name == "main.npdm"));
              if (fileSystemInfo1.contentType == (byte) 0 && source.Count<PartitionFileSystemInfo.EntryInfo>() != 1)
                throw new ArgumentException("\"main.npdm\" must be included in the code region.");
              foreach (PartitionFileSystemInfo.EntryInfo entryInfo2 in source)
              {
                if (!((IEnumerable<byte>) this.ReadAcid(entryInfo2.path)).SequenceEqual<byte>((IEnumerable<byte>) numArray))
                  throw new ArgumentException(".desc file specified differ from the one used to build code.");
              }
            }
            entryInfo1.fileSystemInfo = (Nintendo.Authoring.FileSystemMetaLibrary.FileSystemInfo) fileSystemInfo2;
          }
          fileSystemInfo1.fsEntries.Add(entryInfo1);
        }
      }
      fileSystemInfo1.numFsEntries = fileSystemInfo1.fsEntries.Count;
      fileSystemInfo1.isProdEncryption = false;
      return fileSystemInfo1;
    }
  }
}
