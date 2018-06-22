// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ApplicationControl
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.ApplicationControlProperty;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ApplicationControl
  {
    public static void Generate(string metaPath, List<Tuple<string, string>> iconPathList, List<Tuple<string, string>> nxIconPathList, uint nxIconMaxSize, string outputDirectoryPath, bool cleanup = true)
    {
      if (Directory.Exists(outputDirectoryPath))
      {
        if (cleanup)
        {
          Directory.Delete(outputDirectoryPath, true);
          int num = 0;
          while (num < 3000 && Directory.Exists(outputDirectoryPath))
          {
            Thread.Sleep(100);
            num += 100;
          }
          Directory.CreateDirectory(outputDirectoryPath);
        }
      }
      else
        Directory.CreateDirectory(outputDirectoryPath);
      using (FileStream fileStream = new FileStream(outputDirectoryPath + "/control.nacp", FileMode.Create, FileAccess.Write))
      {
        byte[] buffer = ApplicationControl.MakeApplicationControlPropertyBytes(metaPath);
        fileStream.Write(buffer, 0, buffer.Length);
      }
      foreach (KeyValuePair<string, Tuple<string, string>> mergedIconPath in IconConverter.GetMergedIconPathMap(iconPathList, nxIconPathList))
      {
        string key = mergedIconPath.Key;
        string rawIconPath = mergedIconPath.Value.Item1;
        string nxIconPath = mergedIconPath.Value.Item2;
        try
        {
          Enum.Parse(typeof (Language), key);
        }
        catch
        {
          throw new ArgumentException(string.Format("Undefined language '{0}' specified.", (object) key));
        }
        byte[] buffer = IconConverter.ConvertNxIcon(rawIconPath, nxIconPath, nxIconMaxSize);
        using (FileStream fileStream = File.OpenWrite(outputDirectoryPath + "/icon_" + key + ".dat"))
          fileStream.Write(buffer, 0, buffer.Length);
      }
    }

    private static byte[] MakeApplicationControlPropertyBytes(string metaPath)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(metaPath);
      XmlNode xmlNode = xmlDocument.SelectSingleNode("//Application");
      ApplicationControlPropertyModel controlPropertyModel = (ApplicationControlPropertyModel) new XmlSerializer(typeof (ApplicationControlPropertyModel)).Deserialize(XmlReader.Create((TextReader) new StringReader(xmlNode == null ? "<Application></Application>" : xmlNode.OuterXml)));
      DotMetaReader dotMetaReader = new DotMetaReader(metaPath);
      long applicationId = (long) dotMetaReader.GetApplicationId();
      long aocBaseId = (long) IdConverter.ConvertToAocBaseId(dotMetaReader.GetCoreId());
      return controlPropertyModel.MakePropertyBytes((ulong) applicationId, (ulong) aocBaseId);
    }
  }
}
