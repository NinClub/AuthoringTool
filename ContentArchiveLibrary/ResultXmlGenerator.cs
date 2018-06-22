// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ResultXmlGenerator
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ResultXmlGenerator
  {
    private ResultModel m_model;
    private const string CodePass = "Pass";
    private const string CodeFailed = "Failed";

    public ResultXmlGenerator(Stream stream, bool isXci)
    {
      ResultModel model = new ResultModel();
      model.Code = "Pass";
      model.ErrorMessage = string.Empty;
      model.Size = stream.Length;
      SHA256CryptoServiceProvider cryptoServiceProvider = new SHA256CryptoServiceProvider();
      stream.Seek(0L, SeekOrigin.Begin);
      model.SetHashBytes(cryptoServiceProvider.ComputeHash(stream));
      if (!isXci)
      {
        NintendoSubmissionPackageReader submissionPackageReader = new NintendoSubmissionPackageReader(stream);
        foreach (Tuple<string, long> tuple in submissionPackageReader.ListFileInfo())
        {
          string fileName = tuple.Item1;
          long size = tuple.Item2;
          if (fileName.EndsWith(".cnmt.xml"))
          {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof (ContentMetaModel));
            ContentMetaModel contentMetaModel;
            using (MemoryStream memoryStream = new MemoryStream((int) size))
            {
              byte[] buffer = submissionPackageReader.ReadFile(fileName, 0L, size);
              memoryStream.Write(buffer, 0, buffer.Length);
              memoryStream.Seek(0L, SeekOrigin.Begin);
              contentMetaModel = (ContentMetaModel) xmlSerializer.Deserialize((Stream) memoryStream);
            }
            model.ContentMetaList.Add(contentMetaModel);
          }
        }
      }
      this.SetCommon(ref model);
      this.m_model = model;
    }

    public ResultXmlGenerator(string errorMessage)
    {
      ResultModel model = new ResultModel();
      model.Code = "Failed";
      model.ErrorMessage = errorMessage;
      this.SetCommon(ref model);
      this.m_model = model;
    }

    public void SetCommon(ref ResultModel model)
    {
      model.Command = string.Join(" ", Environment.GetCommandLineArgs());
      model.ToolVersion = string.Join(",", (IEnumerable<string>) ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).Select<Assembly, string>((Func<Assembly, string>) (asm => asm.GetName().Name + ":" + asm.GetName().Version.ToString())).ToList<string>());
    }

    public void WriteToStream(Stream stream)
    {
      this.m_model.Date = DateTimeOffset.Now.ToString();
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      stream.Seek(0L, SeekOrigin.Begin);
      new XmlSerializer(typeof (ResultModel)).Serialize((TextWriter) new StreamWriter(stream, Encoding.UTF8), (object) this.m_model, namespaces);
    }
  }
}
