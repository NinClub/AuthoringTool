// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentMetaXmlSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class NintendoContentMetaXmlSource : ISource
  {
    private Type m_ModelType = typeof (ContentMetaModel);
    private NintendoContentMetaBase m_contentMetaBase;
    private ContentMetaModel m_model;
    private ContentModel m_MetaModel;
    private ISource m_MetaHashSource;

    public NintendoContentMetaXmlSource(NintendoContentMetaBase contentMetaBase, ISource metaHashSource, long metaSize)
    {
      this.m_contentMetaBase = contentMetaBase;
      this.m_MetaHashSource = metaHashSource;
      NintendoContentMetaReader contentMetaReader = new NintendoContentMetaReader(contentMetaBase.GetBytes());
      ContentMetaModel contentMetaModel1 = this.PrepareContentMetaModel(contentMetaBase.GetContentMetaDescryptor());
      contentMetaModel1.Type = contentMetaReader.GetType();
      contentMetaModel1.SetUInt64Id(contentMetaReader.GetId());
      contentMetaModel1.Version = contentMetaReader.GetVersion();
      contentMetaModel1.AttributeList = ((ContentMetaAttribute) contentMetaReader.GetAttributes()).ToStringList();
      contentMetaModel1.RequiredDownloadSystemVersion = contentMetaReader.GetRequiredDownloadSystemVersion();
      byte[] bytes1 = new byte[NintendoContentMeta.GetDigestSize()];
      contentMetaModel1.SetDigestBytes(bytes1);
      List<NintendoContentInfo> contentInfoList = contentMetaReader.GetContentInfoList();
      if (contentInfoList.Count > 0)
      {
        contentMetaModel1.ContentList = new List<ContentModel>();
        foreach (NintendoContentInfo nintendoContentInfo in contentInfoList)
        {
          ContentModel contentModel = new ContentModel();
          contentModel.Type = nintendoContentInfo.Type;
          contentModel.Size = nintendoContentInfo.Size;
          byte[] bytes2 = new byte[NintendoContentMeta.GetContentInfoHashSize()];
          contentModel.SetIdBytes(bytes2);
          contentModel.SetHashBytes(bytes2);
          contentMetaModel1.ContentList.Add(contentModel);
        }
      }
      contentMetaModel1.ContentList = contentMetaModel1.ContentList ?? new List<ContentModel>();
      this.m_MetaModel = new ContentModel();
      contentMetaModel1.ContentList.Add(this.m_MetaModel);
      this.m_MetaModel.Type = "Meta";
      this.m_MetaModel.Size = metaSize;
      byte[] bytes3 = new byte[NintendoContentMeta.GetContentInfoHashSize()];
      this.m_MetaModel.SetIdBytes(bytes3);
      this.m_MetaModel.SetHashBytes(bytes3);
      List<NintendoContentMetaInfo> contentMetaInfoList = contentMetaReader.GetContentMetaInfoList();
      if (contentMetaInfoList.Count > 0)
      {
        contentMetaModel1.ContentMetaList = new List<ContentMetaModel>();
        foreach (NintendoContentMetaInfo nintendoContentMetaInfo in contentMetaInfoList)
        {
          ContentMetaModel contentMetaModel2 = new ContentMetaModel();
          contentMetaModel2.Type = nintendoContentMetaInfo.Type;
          contentMetaModel2.SetUInt64Id(nintendoContentMetaInfo.Id);
          contentMetaModel2.Version = nintendoContentMetaInfo.Version;
          contentMetaModel2.AttributeList = ((ContentMetaAttribute) nintendoContentMetaInfo.Attributes).ToStringList();
          contentMetaModel1.ContentMetaList.Add(contentMetaModel2);
        }
      }
      this.m_model = contentMetaModel1;
      this.Size = (long) this.GetBytes().Length;
    }

    public long Size { get; private set; }

    public SourceStatus QueryStatus()
    {
      foreach (ISource source in new List<ISource>()
      {
        this.m_contentMetaBase.GetSource(),
        this.m_MetaHashSource
      })
      {
        RangeList availableRangeList = source.QueryStatus().AvailableRangeList;
        if (availableRangeList.Count == 0 || availableRangeList[0].Size != source.Size)
          return new SourceStatus();
      }
      SourceStatus sourceStatus = new SourceStatus();
      sourceStatus.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
      return sourceStatus;
    }

    public ByteData PullData(long offset, int size)
    {
      ISource source = this.m_contentMetaBase.GetSource();
      NintendoContentMetaReader contentMetaReader = new NintendoContentMetaReader(source.PullData(0L, (int) source.Size).Buffer.Array);
      List<NintendoContentInfo> contentInfoList = contentMetaReader.GetContentInfoList();
      for (int index = 0; index < contentInfoList.Count; ++index)
      {
        NintendoContentInfo nintendoContentInfo = contentInfoList[index];
        this.m_model.ContentList[index].SetIdBytes(nintendoContentInfo.Id);
        this.m_model.ContentList[index].SetHashBytes(nintendoContentInfo.Hash);
      }
      this.m_model.SetDigestBytes(contentMetaReader.GetDigest());
      ByteData byteData = this.m_MetaHashSource.PullData(0L, NintendoContentMeta.GetContentInfoHashSize());
      this.m_MetaModel.SetIdBytes(byteData.Buffer.Array);
      this.m_MetaModel.SetHashBytes(byteData.Buffer.Array);
      byte[] bytes = this.GetBytes();
      return new MemorySource(bytes, 0, bytes.Length).PullData(offset, size);
    }

    private byte[] GetBytes()
    {
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      MemoryStream memoryStream = new MemoryStream();
      new XmlSerializer(this.m_ModelType).Serialize((Stream) memoryStream, (object) this.m_model, namespaces);
      return memoryStream.ToArray();
    }

    private ContentMetaModel PrepareContentMetaModel(ContentMetaDescriptor descriptor)
    {
      string type = descriptor.Type;
      ContentMetaModel contentMetaModel1;
      if (!(type == "Application"))
      {
        if (!(type == "Patch"))
        {
          if (type == "AddOnContent")
          {
            NintendoAddOnContentExtendedHeader extendedHeader = (NintendoAddOnContentExtendedHeader) descriptor.ExtendedHeader;
            AddOnContentContentMetaModel contentMetaModel2 = new AddOnContentContentMetaModel();
            contentMetaModel2.RequiredApplicationVersion = extendedHeader.RequiredApplicationVersion;
            contentMetaModel2.SetUInt64ApplicationId(extendedHeader.ApplicationId);
            contentMetaModel2.Tag = extendedHeader.Tag;
            contentMetaModel2.Index = this.GetAddOnContentIndex(descriptor, extendedHeader);
            contentMetaModel1 = (ContentMetaModel) contentMetaModel2;
            this.m_ModelType = typeof (AddOnContentContentMetaModel);
          }
          else
            contentMetaModel1 = new ContentMetaModel();
        }
        else
        {
          NintendoPatchExtendedHeader extendedHeader = (NintendoPatchExtendedHeader) descriptor.ExtendedHeader;
          PatchContentMetaModel contentMetaModel2 = new PatchContentMetaModel();
          contentMetaModel2.RequiredSystemVersion = extendedHeader.RequiredSystemVersion;
          contentMetaModel2.SetUInt64ApplicationId(extendedHeader.ApplicationId);
          contentMetaModel1 = (ContentMetaModel) contentMetaModel2;
          this.m_ModelType = typeof (PatchContentMetaModel);
        }
      }
      else
      {
        NintendoApplicationExtendedHeader extendedHeader = (NintendoApplicationExtendedHeader) descriptor.ExtendedHeader;
        ApplicationContentMetaModel contentMetaModel2 = new ApplicationContentMetaModel();
        contentMetaModel2.RequiredSystemVersion = extendedHeader.RequiredSystemVersion;
        contentMetaModel2.SetUInt64PatchId(extendedHeader.PatchId);
        contentMetaModel1 = (ContentMetaModel) contentMetaModel2;
        this.m_ModelType = typeof (ApplicationContentMetaModel);
      }
      return contentMetaModel1;
    }

    private uint GetAddOnContentIndex(ContentMetaDescriptor descriptor, NintendoAddOnContentExtendedHeader exHeader)
    {
      return (uint) (descriptor.Id - IdConverter.ConvertToAocBaseId(exHeader.ApplicationId));
    }
  }
}
