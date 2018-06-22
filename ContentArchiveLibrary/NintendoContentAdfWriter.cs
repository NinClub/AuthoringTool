// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentAdfWriter
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
  public class NintendoContentAdfWriter
  {
    private string m_adfPath;
    private string m_type;
    private ulong m_ProgramId;
    private string m_DescPath;
    private int m_KeyAreaEncryptionKeyIndex;

    public NintendoContentAdfWriter(string adfPath, string type, string metaPath, string descPath, int keyAreaEncryptionKeyIndex)
    {
      this.m_ProgramId = metaPath != null ? new DotMetaReader(metaPath).GetNcaId() : ulong.MaxValue;
      this.m_adfPath = adfPath;
      this.m_type = type;
      this.m_DescPath = descPath;
      this.m_KeyAreaEncryptionKeyIndex = keyAreaEncryptionKeyIndex;
    }

    public void Write(List<Pair<string, string>> dirPaths, List<Pair<FilterType, Regex>> filterRules)
    {
      using (StreamWriter streamWriter = new StreamWriter(this.m_adfPath, false, Encoding.UTF8))
      {
        streamWriter.WriteLine("formatType : NintendoContent");
        streamWriter.WriteLine("version : 0");
        streamWriter.WriteLine("contentType : {0}", (object) this.m_type);
        streamWriter.WriteLine("keyGeneration : 0");
        streamWriter.WriteLine("programId : {0:X16}", (object) this.m_ProgramId);
        streamWriter.WriteLine("contentIndex : 0");
        if (this.m_DescPath != null)
          streamWriter.WriteLine("descFilePath : " + Path.GetFullPath(this.m_DescPath));
        if (this.m_KeyAreaEncryptionKeyIndex != 0)
          streamWriter.WriteLine("keyAreaEncryptionKeyIndex : " + (object) this.m_KeyAreaEncryptionKeyIndex);
        streamWriter.WriteLine("entries :");
        string type = this.m_type;
        if (!(type == "Program"))
        {
          if (!(type == "Control") && !(type == "Data") && (!(type == "HtmlDocument") && !(type == "LegalInformation")))
            throw new NotImplementedException();
          streamWriter.WriteLine("  - type : format");
          streamWriter.WriteLine("    formatType : RomFs");
          streamWriter.WriteLine("    version : 2");
          streamWriter.WriteLine("    hashType : {0}", (object) 3);
          streamWriter.WriteLine("    encryptionType : {0}", (object) 3);
          string adfPath = Path.GetFullPath(Path.GetDirectoryName(this.m_adfPath)) + "\\" + Path.GetFileNameWithoutExtension(this.m_adfPath) + ".rom.adf";
          streamWriter.WriteLine("    path : {0}", (object) adfPath);
          new RomFsAdfWriter(adfPath).Write(dirPaths, (List<Pair<FilterType, Regex>>) null);
        }
        else
        {
          string str = Path.GetFullPath(Path.GetDirectoryName(this.m_adfPath)) + "\\" + Path.GetFileNameWithoutExtension(this.m_adfPath);
          streamWriter.WriteLine("  - type : format");
          streamWriter.WriteLine("    partitionType : code");
          streamWriter.WriteLine("    formatType : PartitionFs");
          streamWriter.WriteLine("    version : 2");
          streamWriter.WriteLine("    hashType : {0}", (object) 2);
          streamWriter.WriteLine("    encryptionType : {0}", (object) 3);
          string adfPath1 = str + ".code.adf";
          streamWriter.WriteLine("    path : {0}", (object) adfPath1);
          new PartitionFsAdfWriter(adfPath1).Write(dirPaths[0].first);
          if (dirPaths.Count >= 2)
          {
            streamWriter.WriteLine("  - type : format");
            streamWriter.WriteLine("    partitionType : data");
            streamWriter.WriteLine("    formatType : RomFs");
            streamWriter.WriteLine("    version : 2");
            streamWriter.WriteLine("    hashType : {0}", (object) 3);
            streamWriter.WriteLine("    encryptionType : {0}", (object) 3);
            string adfPath2 = str + ".rom.adf";
            streamWriter.WriteLine("    path : {0}", (object) adfPath2);
            new RomFsAdfWriter(adfPath2).Write(dirPaths[1], filterRules);
          }
          if (dirPaths.Count < 3)
            return;
          streamWriter.WriteLine("  - type : format");
          streamWriter.WriteLine("    partitionType : logo");
          streamWriter.WriteLine("    formatType : PartitionFs");
          streamWriter.WriteLine("    version : 2");
          streamWriter.WriteLine("    hashType : {0}", (object) 2);
          streamWriter.WriteLine("    encryptionType : {0}", (object) 1);
          string adfPath3 = str + ".logo.adf";
          streamWriter.WriteLine("    path : {0}", (object) adfPath3);
          new PartitionFsAdfWriter(adfPath3).Write(dirPaths[2].first);
        }
      }
    }
  }
}
