// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentMetaBase
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoContentMetaBase
  {
    public const string ApplicationType = "Application";
    public const string PatchType = "Patch";
    public const string AddOnContentType = "AddOnContent";
    public const string SystemUpdateType = "SystemUpdate";
    public const string MetaType = "Meta";
    private NintendoContentMeta m_contentMeta;
    private ContentMetaDescriptor m_descriptor;
    private List<Tuple<ISource, NintendoContentInfo>> m_contentSourceList;
    private NintendoContentMetaBaseSource m_source;

    public NintendoContentMetaBase(List<Tuple<ISource, NintendoContentInfo>> contentSourceList, byte[] buffer, ContentMetaModel model, bool isProdEncryption)
      : this(contentSourceList, NintendoContentMetaBase.ExtractContentMetaDescriptor(buffer, model, contentSourceList.Select<Tuple<ISource, NintendoContentInfo>, NintendoContentInfo>((Func<Tuple<ISource, NintendoContentInfo>, NintendoContentInfo>) (tuple => tuple.Item2)).ToList<NintendoContentInfo>()), isProdEncryption)
    {
    }

    public NintendoContentMetaBase(List<Tuple<ISource, NintendoContentInfo>> contentSourceList, string type, string metaPath)
      : this(contentSourceList, NintendoContentMetaBase.ExtractContentMetaDescriptor(type, metaPath, contentSourceList.Select<Tuple<ISource, NintendoContentInfo>, NintendoContentInfo>((Func<Tuple<ISource, NintendoContentInfo>, NintendoContentInfo>) (tuple => tuple.Item2)).ToList<NintendoContentInfo>()), false)
    {
    }

    internal NintendoContentMetaBase(List<Tuple<ISource, NintendoContentInfo>> contentSourceList, ContentMetaDescriptor descriptor, bool isProdEncryption)
    {
      this.m_contentSourceList = contentSourceList;
      this.m_descriptor = descriptor;
      string type = this.m_descriptor.Type;
      ulong id = this.m_descriptor.Id;
      uint version = this.m_descriptor.Version;
      byte attributes = this.m_descriptor.Attributes;
      long applicationId = (long) this.m_descriptor.ApplicationId;
      uint downloadSystemVersion = this.m_descriptor.RequiredDownloadSystemVersion;
      List<NintendoContentInfo> contentInfoList = this.m_descriptor.ContentInfoList;
      List<NintendoContentMetaInfo> contentMetaInfoList = this.m_descriptor.ContentMetaInfoList;
      byte[] digest = this.m_descriptor.Digest;
      if (!(type == "Application"))
      {
        if (!(type == "AddOnContent"))
        {
          if (type == "Patch")
          {
            NintendoPatchExtendedHeader extendedHeader = (NintendoPatchExtendedHeader) descriptor.ExtendedHeader;
            this.m_contentMeta = NintendoContentMeta.CreatePatchMeta(id, version, attributes, downloadSystemVersion, extendedHeader, contentInfoList, contentMetaInfoList, digest);
          }
          else
            this.m_contentMeta = NintendoContentMeta.CreateDefault(id, version, type, attributes, downloadSystemVersion, contentInfoList, contentMetaInfoList, digest);
        }
        else
        {
          NintendoAddOnContentExtendedHeader extendedHeader = (NintendoAddOnContentExtendedHeader) descriptor.ExtendedHeader;
          this.m_contentMeta = NintendoContentMeta.CreateAddOnContentMeta(id, version, attributes, downloadSystemVersion, extendedHeader, contentInfoList, contentMetaInfoList, digest);
        }
      }
      else
      {
        NintendoApplicationExtendedHeader extendedHeader = (NintendoApplicationExtendedHeader) descriptor.ExtendedHeader;
        this.m_contentMeta = NintendoContentMeta.CreateApplicationMeta(id, version, attributes, downloadSystemVersion, extendedHeader, contentInfoList, contentMetaInfoList, digest);
      }
      this.m_source = new NintendoContentMetaBaseSource(this, !isProdEncryption);
    }

    public byte[] GetBytes()
    {
      return this.m_contentMeta.GetBytes();
    }

    public ISource GetSource()
    {
      return (ISource) this.m_source;
    }

    public long GetContentInfoHashOffset(int index)
    {
      return this.m_contentMeta.GetContentInfoHashOffset(index);
    }

    public long GetContentInfoHashSize()
    {
      return (long) NintendoContentMeta.GetContentInfoHashSize();
    }

    public long GetContentInfoIdDataOffset(int index)
    {
      return this.m_contentMeta.GetContentInfoIdDataOffset(index);
    }

    public long GetContentInfoIdDataSize()
    {
      return (long) NintendoContentMeta.GetContentInfoIdDataSize();
    }

    public long GetDigestOffset()
    {
      return this.m_contentMeta.GetDigestOffset();
    }

    public long GetDigestSize()
    {
      return (long) NintendoContentMeta.GetDigestSize();
    }

    public string GetEntryName()
    {
      return this.m_descriptor.Type + "_" + string.Format("{0:x16}", (object) this.m_descriptor.Id) + ".cnmt";
    }

    internal ContentMetaDescriptor GetContentMetaDescryptor()
    {
      return this.m_descriptor;
    }

    internal List<Tuple<ISource, NintendoContentInfo>> GetContentSourceList()
    {
      return this.m_contentSourceList;
    }

    private static ContentMetaDescriptor ExtractContentMetaDescriptor(byte[] buffer, ContentMetaModel model, List<NintendoContentInfo> contentInfoList)
    {
      NintendoContentMetaReader contentMetaReader = new NintendoContentMetaReader(buffer);
      NintendoExtendedHeader extendedHeader = contentMetaReader.GetExtendedHeader();
      if (contentMetaReader.GetType() == "AddOnContent")
        (extendedHeader as NintendoAddOnContentExtendedHeader).Tag = (model as AddOnContentContentMetaModel).Tag;
      return new ContentMetaDescriptor(contentMetaReader.GetType(), contentMetaReader.GetId(), contentMetaReader.GetVersion(), contentMetaReader.GetAttributes(), contentMetaReader.GetApplicationId(), contentMetaReader.GetRequiredDownloadSystemVersion(), contentInfoList, contentMetaReader.GetContentMetaInfoList(), extendedHeader, contentMetaReader.GetDigest());
    }

    private static uint GetDefaultDownloadSystemVersion()
    {
      return 0;
    }

    private static uint ShiftVersion(uint version, string type)
    {
      if (version > (uint) ushort.MaxValue)
        throw new ArgumentException(string.Format("{0} version should be UInt16 value.", (object) type));
      return version <<= 16;
    }

    private static ContentMetaDescriptor ExtractContentMetaDescriptor(string type, string metaPath, List<NintendoContentInfo> contentInfoList)
    {
      ulong applicationId = 0;
      byte attributes = 0;
      NintendoExtendedHeader extendedHeader = (NintendoExtendedHeader) null;
      List<NintendoContentMetaInfo> contentMetaInfoList = new List<NintendoContentMetaInfo>();
      uint num1 = NintendoContentMetaBase.GetDefaultDownloadSystemVersion();
      ulong id;
      uint version;
      if (type.Equals("SystemUpdate"))
      {
        ContentMetaModel contentMeta1 = NintendoContentMetaBase.GetDeserializedModel<SystemUpdateModel>(metaPath, false).ContentMeta;
        if (contentMeta1.Type != "SystemUpdate")
          throw new ArgumentException("The content meta type is not SystemUpdate.");
        id = contentMeta1.GetUInt64Id();
        version = contentMeta1.Version;
        foreach (ContentMetaModel contentMeta2 in contentMeta1.ContentMetaList)
          contentMetaInfoList.Add(new NintendoContentMetaInfo(contentMeta2.Type, contentMeta2.GetUInt64Id(), contentMeta2.Version, (byte) ContentMetaAttributeExtension.FromStringList((IEnumerable<string>) contentMeta2.AttributeList)));
      }
      else
      {
        DotMetaReader dotMetaReader = new DotMetaReader(metaPath);
        id = dotMetaReader.GetContentMetaId();
        version = dotMetaReader.GetVersion();
        attributes = dotMetaReader.GetContentMetaAttributes();
        num1 = dotMetaReader.GetRequiredDownloadSystemVersion().GetValueOrDefault(num1);
        if (!(type == "Application"))
        {
          if (!(type == "AddOnContent"))
          {
            if (type == "Patch")
            {
              applicationId = dotMetaReader.GetApplicationId();
              uint? requiredSystemVersion1 = dotMetaReader.GetRequiredSystemVersion();
              uint requiredSystemVersion2 = requiredSystemVersion1.HasValue ? requiredSystemVersion1.Value : NintendoContentMeta.GetRequiredSystemVersion();
              extendedHeader = (NintendoExtendedHeader) new NintendoPatchExtendedHeader(dotMetaReader.GetApplicationId(), requiredSystemVersion2);
              version = NintendoContentMetaBase.ShiftVersion(version, "Patch");
            }
          }
          else
          {
            applicationId = dotMetaReader.GetApplicationId();
            extendedHeader = (NintendoExtendedHeader) new NintendoAddOnContentExtendedHeader(dotMetaReader.GetApplicationId(), dotMetaReader.GetRequiredApplicationVersion(), dotMetaReader.GetAddOnContentTag());
            version = NintendoContentMetaBase.ShiftVersion(version, "AddOnContent");
          }
        }
        else
        {
          long num2 = (long) id + 2048L;
          uint? requiredSystemVersion = dotMetaReader.GetRequiredSystemVersion();
          int num3 = requiredSystemVersion.HasValue ? (int) requiredSystemVersion.Value : (int) NintendoContentMeta.GetRequiredSystemVersion();
          extendedHeader = (NintendoExtendedHeader) new NintendoApplicationExtendedHeader((ulong) num2, (uint) num3);
          version = NintendoContentMetaBase.ShiftVersion(version, "Application");
        }
      }
      return new ContentMetaDescriptor(type, id, version, attributes, applicationId, num1, contentInfoList, contentMetaInfoList, extendedHeader, new byte[NintendoContentMeta.GetDigestSize()]);
    }

    private static ModelT GetDeserializedModel<ModelT>(string metaPath, bool nullable)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(metaPath);
      XmlRootAttribute customAttribute = (XmlRootAttribute) typeof (ModelT).GetCustomAttributes(typeof (XmlRootAttribute), false)[0];
      XmlNode xmlNode = xmlDocument.SelectSingleNode("//" + customAttribute.ElementName);
      if (xmlNode != null)
        return (ModelT) new XmlSerializer(typeof (ModelT)).Deserialize(XmlReader.Create((TextReader) new StringReader(xmlNode.OuterXml)));
      if (nullable)
        return default (ModelT);
      throw new ArgumentException(string.Format("Could not find <{0}> element in {1}.", (object) customAttribute.ElementName, (object) metaPath));
    }
  }
}
