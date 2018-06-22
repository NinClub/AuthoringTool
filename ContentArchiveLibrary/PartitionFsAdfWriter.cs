// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.PartitionFsAdfWriter
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.IO;
using System.Text;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class PartitionFsAdfWriter
  {
    private string m_adfPath;

    public PartitionFsAdfWriter(string adfPath)
    {
      this.m_adfPath = adfPath;
    }

    public void Write(string dirPath)
    {
      using (StreamWriter streamWriter = new StreamWriter(this.m_adfPath, false, Encoding.UTF8))
      {
        streamWriter.WriteLine("formatType : PartitionFs");
        streamWriter.WriteLine("version : 0");
        streamWriter.WriteLine("entries :");
        long num = 0;
        foreach (string enumerateFile in Directory.EnumerateFiles(dirPath, "*", SearchOption.AllDirectories))
        {
          streamWriter.WriteLine("  - type : file");
          streamWriter.WriteLine("    name : {0}", (object) enumerateFile.Replace("\\", "/").Replace(dirPath + "/", string.Empty));
          streamWriter.WriteLine("    offset : {0}", (object) num);
          FileInfo fileInfo = new FileInfo(enumerateFile);
          num += fileInfo.Length;
          streamWriter.WriteLine("    path : {0}", (object) Path.GetFullPath(enumerateFile.Replace("\\", "/")));
        }
      }
    }
  }
}
