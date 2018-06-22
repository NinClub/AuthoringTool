// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoSubmissionPackageArchive
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoSubmissionPackageArchive : IConnector
  {
    public List<Connection> ConnectionList { get; private set; }

    private bool CheckNeedTicket(NintendoSubmissionPackageFileSystemInfo.EntryInfo entry)
    {
      return TicketUtility.NeedCreateTicket(entry.MetaType);
    }

    private ulong GetApplicationIdFromContentMetaRawData(byte[] contentMetaRawData)
    {
      return BitConverter.ToUInt64(contentMetaRawData, 0);
    }

    private void AddConnection(out IReadableSink outReadableSubSink, ISource source, IReadableSink outSink, long offset)
    {
      if (outSink.Size < offset + source.Size)
        outSink.SetSize(offset + source.Size);
      outReadableSubSink = (IReadableSink) new ReadableSubSink(outSink, offset, source.Size);
      this.ConnectionList.Add(new Connection(source, (ISink) outReadableSubSink));
    }

    private void AddConnection(ISource source, IReadableSink outSink, long offset)
    {
      IReadableSink outReadableSubSink;
      this.AddConnection(out outReadableSubSink, source, outSink, offset);
    }

    private long RegisterRootEntry(IReadableSink outSink, ref PartitionFileSystemInfo rootFsInfo, long rootFsHeaderSize, ref List<ContentHashSource> hashSources, string name, ISource source, long offset, ContentHashSource hashSource)
    {
      PartitionFileSystemInfo.EntryInfo entryInfo = PartitionFileSystemInfo.EntryInfo.Make(name, (ulong) source.Size, (ulong) (offset - rootFsHeaderSize));
      rootFsInfo.entries.Add(entryInfo);
      this.AddConnection(source, outSink, offset);
      hashSources.Add(hashSource);
      return offset + source.Size;
    }

    private bool CheckNeedLogoPartition(NintendoSubmissionPackageFileSystemInfo.EntryInfo entry)
    {
      return entry.MetaType == "Application";
    }

    public NintendoSubmissionPackageArchive(IReadableSink outSink, NintendoSubmissionPackageFileSystemInfo fileSystemInfo, KeyConfiguration config)
    {
      this.ConnectionList = new List<Connection>();
      PartitionFileSystemMeta partitionFileSystemMeta = new PartitionFileSystemMeta();
      List<string> entryNameList = new List<string>();
      for (int index1 = 0; index1 < fileSystemInfo.Entries.Count; ++index1)
      {
        for (int index2 = 0; index2 < fileSystemInfo.Entries[index1].Contents.Count; ++index2)
          entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nca");
        entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt.nca");
        entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt.xml");
        if (NintendoSubmissionPackageArchiveUtils.HasProgramContent(fileSystemInfo.Entries[index1].Contents))
          entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.programinfo.xml");
        if (this.CheckNeedTicket(fileSystemInfo.Entries[index1]))
        {
          entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.tik");
          entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cert");
        }
        if (fileSystemInfo.EnableContentMetaBinaryExport)
          entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt");
        foreach (NintendoSubmissionPackageExtraData packageExtraData in fileSystemInfo.Entries[index1].ExtraData)
          entryNameList.Add(packageExtraData.EntryName);
        if (NintendoSubmissionPackageArchiveUtils.HasControlContent(fileSystemInfo.Entries[index1].Contents))
          entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nacp.xml");
        if (fileSystemInfo.Entries[index1].MetaType == "Application")
          entryNameList.Add("cardspec.xml");
      }
      long dummySize = HashNameEntryPartitionFsHeaderSource<PartitionFileSystemMeta>.GetDummySize(entryNameList);
      long num1 = dummySize;
      List<ContentHashSource> hashSources = new List<ContentHashSource>();
      List<ProgramInfoXml> programInfoXmlList = new List<ProgramInfoXml>();
      PartitionFileSystemInfo rootFsInfo = new PartitionFileSystemInfo();
      rootFsInfo.version = (int) fileSystemInfo.Version;
      for (int index1 = 0; index1 < fileSystemInfo.Entries.Count; ++index1)
      {
        NintendoSubmissionPackageFileSystemInfo.EntryInfo entry = fileSystemInfo.Entries[index1];
        List<Tuple<ISource, NintendoContentInfo>> contentSourceList = new List<Tuple<ISource, NintendoContentInfo>>();
        for (int index2 = 0; index2 < entry.Contents.Count; ++index2)
        {
          NintendoSubmissionPackageFileSystemInfo.ContentInfo content = entry.Contents[index2];
          ISource source;
          if (content.FsInfo != null)
          {
            source = (ISource) new NintendoContentArchiveSource(content.FsInfo as NintendoContentFileSystemInfo, config, this.CheckNeedLogoPartition(entry));
          }
          else
          {
            if (content.Source == null)
              throw new NotImplementedException();
            source = content.Source;
          }
          PartitionFileSystemInfo.EntryInfo entryInfo = PartitionFileSystemInfo.EntryInfo.Make("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nca", (ulong) source.Size, (ulong) (num1 - dummySize));
          rootFsInfo.entries.Add(entryInfo);
          IReadableSink outReadableSubSink;
          this.AddConnection(out outReadableSubSink, source, outSink, num1);
          SinkLinkedSource sinkLinkedSource = new SinkLinkedSource((ISink) outReadableSubSink, (ISource) new Sha256StreamHashSource(outReadableSubSink.ToSource()));
          hashSources.Add(new ContentHashSource((ISource) sinkLinkedSource, ".nca", content.ContentType));
          num1 += source.Size;
          contentSourceList.Add(Tuple.Create<ISource, NintendoContentInfo>(hashSources[hashSources.Count - 1].Source, new NintendoContentInfo(content.ContentType, source.Size)));
        }
        NintendoContentMetaBase nintendoContentMetaBase = entry.ContentMetaInfo == null ? new NintendoContentMetaBase(contentSourceList, entry.MetaType, entry.MetaFilePath) : new NintendoContentMetaBase(contentSourceList, entry.ContentMetaInfo.Data, entry.ContentMetaInfo.Model, fileSystemInfo.IsProdEncryption);
        NintendoContentMetaArchiveSource metaArchiveSource = new NintendoContentMetaArchiveSource(nintendoContentMetaBase, entry.KeyIndex, config, fileSystemInfo.IsProdEncryption, false);
        PartitionFileSystemInfo.EntryInfo entryInfo1 = PartitionFileSystemInfo.EntryInfo.Make("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt.nca", (ulong) metaArchiveSource.Size, (ulong) (num1 - dummySize));
        rootFsInfo.entries.Add(entryInfo1);
        IReadableSink outReadableSubSink1;
        this.AddConnection(out outReadableSubSink1, (ISource) metaArchiveSource, outSink, num1);
        ISource source1 = (ISource) new SinkLinkedSource((ISink) outReadableSubSink1, (ISource) new Sha256StreamHashSource(outReadableSubSink1.ToSource()));
        hashSources.Add(new ContentHashSource(source1, ".cnmt.nca"));
        long offset1 = num1 + metaArchiveSource.Size;
        NintendoContentMetaXmlSource contentMetaXmlSource = new NintendoContentMetaXmlSource(nintendoContentMetaBase, source1, metaArchiveSource.Size);
        num1 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt.xml", (ISource) contentMetaXmlSource, offset1, new ContentHashSource(source1, ".cnmt.xml"));
        if (NintendoSubmissionPackageArchiveUtils.HasProgramContent(fileSystemInfo.Entries[index1].Contents))
        {
          ISource source2 = (ISource) new ProgramInfoXmlSource(NintendoSubmissionPackageArchiveUtils.GetProgramInfoXml(fileSystemInfo.Entries[index1].Contents, config));
          ISource source3 = hashSources.Where<ContentHashSource>((Func<ContentHashSource, bool>) (x => x.ContentType == "Program")).Select<ContentHashSource, ISource>((Func<ContentHashSource, ISource>) (x => x.Source)).Single<ISource>();
          num1 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.programinfo.xml", source2, num1, new ContentHashSource(source3, ".programinfo.xml"));
        }
        if (fileSystemInfo.EnableContentMetaBinaryExport)
        {
          ISource source2 = nintendoContentMetaBase.GetSource();
          num1 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt", source2, num1, new ContentHashSource(source1, ".cnmt"));
        }
        foreach (NintendoSubmissionPackageExtraData packageExtraData in entry.ExtraData)
          num1 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, packageExtraData.EntryName, (ISource) packageExtraData, num1, new ContentHashSource(source1, ".jpg"));
        if (NintendoSubmissionPackageArchiveUtils.HasControlContent(fileSystemInfo.Entries[index1].Contents))
        {
          ApplicationControlPropertyXmlSource propertyXmlSource = new ApplicationControlPropertyXmlSource(NintendoSubmissionPackageArchiveUtils.GetApplicationControlProperty(fileSystemInfo.Entries[index1].Contents, config));
          ISource source2 = hashSources.Where<ContentHashSource>((Func<ContentHashSource, bool>) (x => x.ContentType == "Control")).Select<ContentHashSource, ISource>((Func<ContentHashSource, ISource>) (x => x.Source)).Single<ISource>();
          num1 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nacp.xml", (ISource) propertyXmlSource, num1, new ContentHashSource(source2, ".nacp.xml"));
        }
        if (this.CheckNeedTicket(fileSystemInfo.Entries[index1]))
        {
          ulong num2 = fileSystemInfo.Entries[index1].ContentMetaInfo != null ? this.GetApplicationIdFromContentMetaRawData(fileSystemInfo.Entries[index1].ContentMetaInfo.Data) : new DotMetaReader(fileSystemInfo.Entries[index1].MetaFilePath).GetContentMetaId();
          string rightsIdText = TicketUtility.CreateRightsIdText(num2);
          Ticket ticket = new Ticket();
          ticket.PublishTicket(num2, fileSystemInfo.IsProdEncryption, config);
          TicketSource ticketSource = new TicketSource(ticket.Data, ticket.Length);
          long offset2 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, rightsIdText + ".tik", (ISource) ticketSource, num1, new ContentHashSource((ISource) null, ".tik"));
          TicketCertificateSource certificateSource = new TicketCertificateSource(fileSystemInfo.IsProdEncryption, config);
          num1 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, rightsIdText + ".cert", (ISource) certificateSource, offset2, new ContentHashSource((ISource) null, ".cert"));
        }
        if (entry.MetaType == "Application")
        {
          ISource source2 = (ISource) new CardSpecXmlSource(fileSystemInfo, config);
          num1 = this.RegisterRootEntry(outSink, ref rootFsInfo, dummySize, ref hashSources, "cardspec.xml", source2, num1, new ContentHashSource((ISource) null, ".xml"));
        }
      }
      ISource source4 = (ISource) new HashNameEntryPartitionFsHeaderSource<PartitionFileSystemMeta>(hashSources, rootFsInfo, dummySize);
      ISink sink = (ISink) new SubSink((ISink) outSink, 0L, source4.Size);
      this.ConnectionList.Add(new Connection(source4, sink));
      outSink.SetSize(num1);
    }

    public ISource GetSource()
    {
      throw new NotImplementedException();
    }
  }
}
