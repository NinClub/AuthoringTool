// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ContentArchiveLibraryInterface
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.RepresentationModel;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ContentArchiveLibraryInterface
  {
    public static ArchiveFormatType GetArchiveType(string adfPath)
    {
      using (StreamReader streamReader = new StreamReader(adfPath, Encoding.UTF8))
      {
        YamlStream yamlStream = new YamlStream();
        yamlStream.Load((TextReader) streamReader);
        YamlMappingNode rootNode;
        try
        {
          rootNode = (YamlMappingNode) yamlStream.Documents[0].RootNode;
        }
        catch
        {
          throw new ArgumentException("invalid format .adf file. no \"entries\"");
        }
        YamlScalarNode child;
        try
        {
          child = (YamlScalarNode) rootNode.Children[(YamlNode) new YamlScalarNode("formatType")];
        }
        catch
        {
          throw new ArgumentException("invalid format .adf file. no \"formatType\"\n");
        }
        string str = child.Value;
        if (str == "NintendoContent")
          return ArchiveFormatType.NintendoContent;
        if (str == "PartitionFs")
          return ArchiveFormatType.PartitionFs;
        if (str == "RomFs")
          return ArchiveFormatType.RomFs;
        if (str == "NintendoSubmissionPackage")
          return ArchiveFormatType.NintendoSubmissionPackage;
        throw new ArgumentException("invalid format .adf file. invalid \"formatType\"\n");
      }
    }

    public static void CreateArchiveFromAdf(Stream stream, string adfPath, AuthoringConfiguration config)
    {
      SourceSinkDriver sourceSinkDriver = new SourceSinkDriver();
      switch (ContentArchiveLibraryInterface.GetArchiveType(adfPath))
      {
        case ArchiveFormatType.NintendoContent:
          ISource source1 = (ISource) new NintendoContentArchiveSource(new NintendoContentAdfReader(adfPath).GetFileSystemInfo(), config.GetKeyConfiguration(), false);
          ISink sink1 = (ISink) new StreamSink(stream);
          sink1.SetSize(source1.Size);
          sourceSinkDriver.Add(source1, sink1);
          break;
        case ArchiveFormatType.PartitionFs:
          ISource source2 = (ISource) new PartitionFsArchiveSource(new PartitionFsAdfReader(adfPath).GetFileSystemInfo());
          ISink sink2 = (ISink) new StreamSink(stream);
          sink2.SetSize(source2.Size);
          sourceSinkDriver.Add(source2, sink2);
          break;
        case ArchiveFormatType.RomFs:
          ISource source3 = (ISource) new RomFsArchiveSource(new RomFsAdfReader(adfPath).GetFileSystemInfo());
          ISink sink3 = (ISink) new StreamSink(stream);
          sink3.SetSize(source3.Size);
          sourceSinkDriver.Add(source3, sink3);
          break;
        case ArchiveFormatType.NintendoSubmissionPackage:
          NintendoSubmissionPackageAdfReader packageAdfReader = new NintendoSubmissionPackageAdfReader(adfPath);
          IConnector connector = (IConnector) new NintendoSubmissionPackageArchive((IReadableSink) new StreamSink(stream), packageAdfReader.GetFileSystemInfo(), config.GetKeyConfiguration());
          sourceSinkDriver.Add(connector);
          break;
        default:
          throw new NotImplementedException();
      }
      sourceSinkDriver.Run();
    }

    public static void MergeNintendoSubmissionPackageArchive(Stream outStream, List<Stream> inStreams)
    {
      SourceSinkDriver sourceSinkDriver = new SourceSinkDriver();
      ISource source = (ISource) new PartitionFsArchiveSource(ArchiveReconstructionUtils.GetMergedNspInfo(inStreams.Select<Stream, NintendoSubmissionPackageReader>((Func<Stream, NintendoSubmissionPackageReader>) (x => new NintendoSubmissionPackageReader(x))).ToList<NintendoSubmissionPackageReader>()));
      ISink sink = (ISink) new StreamSink(outStream);
      sink.SetSize(source.Size);
      sourceSinkDriver.Add(source, sink);
      sourceSinkDriver.Run();
    }

    public static void ProdEncryptNintendoSubmissionPackageArchive(Stream outStream, Stream outXmlStream, Stream inStream, AuthoringConfiguration config)
    {
      try
      {
        SourceSinkDriver sourceSinkDriver = new SourceSinkDriver();
        sourceSinkDriver.Add((IConnector) new ProdEncryptedNintendoSubmissionPackageArchive((IReadableSink) new StreamSink(outStream), new NintendoSubmissionPackageReader(inStream), config.GetKeyConfiguration(), config.DebugConfig));
        sourceSinkDriver.Run();
      }
      catch (Exception ex)
      {
        new ResultXmlGenerator(ex.Message + Environment.NewLine + ex.StackTrace).WriteToStream(outXmlStream);
        throw;
      }
      new ResultXmlGenerator(outStream, false).WriteToStream(outXmlStream);
    }

    public static void ProdEncryptNintendoSubmissionPackageArchiveForXci(Stream outStream, Stream outXmlStream, Stream inStream, Stream inUppStream, Stream inPatchStream, byte launchFlags, AuthoringConfiguration config)
    {
      try
      {
        SourceSinkDriver sourceSinkDriver = new SourceSinkDriver();
        NintendoSubmissionPackageReader uppReader = inUppStream != null ? new NintendoSubmissionPackageReader(inUppStream) : (NintendoSubmissionPackageReader) null;
        sourceSinkDriver.Add((IConnector) new ProdEncryptedXciArchive((IReadableSink) new StreamSink(outStream), new NintendoSubmissionPackageReader(inStream), uppReader, (NintendoSubmissionPackageReader) null, launchFlags, config.GetKeyConfiguration()));
        sourceSinkDriver.Run();
      }
      catch (Exception ex)
      {
        new ResultXmlGenerator(ex.Message + Environment.NewLine + ex.StackTrace).WriteToStream(outXmlStream);
        throw;
      }
    }

    public static void EncryptXci(Stream outStream, Stream outXmlStream, Stream inStream, AuthoringConfiguration config)
    {
      try
      {
        SourceSinkDriver sourceSinkDriver = new SourceSinkDriver();
        sourceSinkDriver.Add((IConnector) new ProdEncryptedXciArchive((ISink) new StreamSink(outStream), (ISource) new StreamSource(inStream, 0L, inStream.Length), config.GetKeyConfiguration()));
        sourceSinkDriver.Run();
      }
      catch (Exception ex)
      {
        new ResultXmlGenerator(ex.Message + Environment.NewLine + ex.StackTrace).WriteToStream(outXmlStream);
        throw;
      }
    }

    public static void ModifyArchive(Stream outStream, Stream inStream, Stream inEntryStream, string targetEntryPath, string descFilePath, bool isNsp, AuthoringConfiguration config)
    {
      SourceSinkDriver sourceSinkDriver = new SourceSinkDriver();
      sourceSinkDriver.Add(!isNsp ? (IConnector) new ModifiableNintendoContentArchive((IReadableSink) new StreamSink(outStream), new NintendoContentArchiveReader(inStream, config.GetKeyConfiguration().GetKeyAreaEncryptionKeys()), (ISource) new StreamSource(inEntryStream, 0L, inEntryStream.Length), targetEntryPath, descFilePath, config.GetKeyConfiguration()) : (IConnector) new ModifiableNintendoSubmissionPackageArchive((IReadableSink) new StreamSink(outStream), new NintendoSubmissionPackageReader(inStream), (ISource) new StreamSource(inEntryStream, 0L, inEntryStream.Length), targetEntryPath, descFilePath, config.GetKeyConfiguration()));
      sourceSinkDriver.Run();
    }
  }
}
