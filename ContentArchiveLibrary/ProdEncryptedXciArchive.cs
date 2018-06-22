// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ProdEncryptedXciArchive
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class ProdEncryptedXciArchive : IConnector
  {
    private KeyConfiguration m_keyConfig;
    private IEncryptor m_keyAreaEncryptionKeyIvEncryptor;
    private IEncryptor m_initialDataEncryptor;
    private ICbcModeEncryptor m_headerEncryptor;
    private ISigner m_headerSigner;
    private RNGCryptoServiceProvider m_rng;

    public List<Connection> ConnectionList { get; private set; }

    private void SetCryptor(KeyConfiguration keyConfig)
    {
      this.m_keyAreaEncryptionKeyIvEncryptor = (IEncryptor) new Rsa2048OaepSha256CryptoDriver(Rsa2048OaepSha256KeyIndex.XciKeyArea);
      if (keyConfig.GetProdXciHeaderSignKey() != null)
      {
        RsaKey xciHeaderSignKey = keyConfig.GetProdXciHeaderSignKey();
        this.m_headerSigner = (ISigner) new Rsa2048Pkcs1Sha256SignCryptoDriver(xciHeaderSignKey.KeyModulus, xciHeaderSignKey.KeyPublicExponent, xciHeaderSignKey.KeyPrivateExponent);
      }
      else
        this.m_headerSigner = (ISigner) new HsmRsa2048Pkcs1Sha256SignCryptoDriver(Rsa2048Pkcs1Sha256KeyIndex.XciHeader);
      this.m_initialDataEncryptor = keyConfig.GetProdXciInitialDataEncryptionKey() == null ? (IEncryptor) new HsmAes128CryptoDriver(Aes128KeyIndex.XciInitialData) : (IEncryptor) new Aes128CryptoDriver(keyConfig.GetProdXciInitialDataEncryptionKey().Key);
      this.m_headerEncryptor = (ICbcModeEncryptor) new Aes128CbcCryptoDriver(Aes128KeyIndex.XciHeader);
    }

    private static long RoundupPageSize(long value)
    {
      long pageSize = (long) XciInfo.PageSize;
      return value + (pageSize - 1L) & ~(pageSize - 1L);
    }

    private static long RoundupRomAreaStartPageAddress(long value)
    {
      long num = (long) (XciInfo.RomAreaStartPageCountAlignment * XciInfo.PageSize);
      return value + (num - 1L) & ~(num - 1L);
    }

    private static void CheckAlignmentPageSize(long value)
    {
      if ((value & (long) (XciInfo.PageSize - 1U)) != 0L)
        throw new ArgumentException();
    }

    private static void CalculateRootPartitionHeaderSize(out long rootPartitionHeaderSize)
    {
      List<string> entryNameList = new List<string>()
      {
        "update",
        "normal",
        "secure"
      };
      rootPartitionHeaderSize = HashNameEntryPartitionFsHeaderSource<Sha256PartitionFileSystemMeta>.GetDummySize(entryNameList);
      ProdEncryptedXciArchive.CheckAlignmentPageSize(rootPartitionHeaderSize);
    }

    private static void CalculateUpdatePartitionSize(out long updatePartitionHeaderSize, out long updatePartitionSize, NintendoSubmissionPackageFileSystemInfo uppInfo)
    {
      List<string> entryNameList = new List<string>();
      updatePartitionHeaderSize = HashNameEntryPartitionFsHeaderSource<Sha256PartitionFileSystemMeta>.GetDummySize(entryNameList);
      ProdEncryptedXciArchive.CheckAlignmentPageSize(updatePartitionHeaderSize);
      if (uppInfo != null)
        updatePartitionSize = XciInfo.UpdatePartitionLimitSize;
      else
        updatePartitionSize = XciInfo.EmptyUpdatePartitionSize;
    }

    private static void CalculatePartitionSize(out long partitionHeaderSize, out long partitionSize, NintendoSubmissionPackageFileSystemInfo nspInfo, NintendoSubmissionPackageFileSystemInfo patchInfo, bool isNormal, KeyConfiguration keyConfig)
    {
      long num = 0;
      List<string> entryNameList = new List<string>();
      for (int index1 = 0; index1 < nspInfo.Entries.Count; ++index1)
      {
        List<Tuple<ISource, NintendoContentInfo>> contentSourceList = new List<Tuple<ISource, NintendoContentInfo>>();
        NintendoSubmissionPackageFileSystemInfo.EntryInfo entry = nspInfo.Entries[index1];
        for (int index2 = 0; index2 < entry.Contents.Count; ++index2)
        {
          NintendoSubmissionPackageFileSystemInfo.ContentInfo content = entry.Contents[index2];
          if ((!isNormal || !(content.ContentType != "Control")) && !(content.ContentType == "Meta"))
          {
            ISource source;
            if (content.FsInfo != null)
            {
              source = (ISource) new NintendoContentArchiveSource(content.FsInfo as NintendoContentFileSystemInfo, keyConfig, false);
            }
            else
            {
              if (content.Source == null)
                throw new NotImplementedException();
              source = content.Source;
            }
            contentSourceList.Add(Tuple.Create<ISource, NintendoContentInfo>(source, new NintendoContentInfo(content.ContentType, source.Size)));
            entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nca");
            num += ProdEncryptedXciArchive.RoundupPageSize(source.Size);
          }
        }
        entryNameList.Add("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt.nca");
        NintendoContentMetaArchiveSource metaArchiveSource = new NintendoContentMetaArchiveSource(entry.ContentMetaInfo == null ? new NintendoContentMetaBase(contentSourceList, entry.MetaType, entry.MetaFilePath) : new NintendoContentMetaBase(contentSourceList, entry.ContentMetaInfo.Data, entry.ContentMetaInfo.Model, true), entry.KeyIndex, keyConfig, nspInfo.IsProdEncryption, true);
        num += ProdEncryptedXciArchive.RoundupPageSize(metaArchiveSource.Size);
      }
      partitionHeaderSize = HashNameEntryPartitionFsHeaderSource<Sha256PartitionFileSystemMeta>.GetDummySize(entryNameList);
      ProdEncryptedXciArchive.CheckAlignmentPageSize(partitionHeaderSize);
      partitionSize = num;
    }

    internal static XciSizeInfo CalculateXciSize(NintendoSubmissionPackageFileSystemInfo nspInfo, NintendoSubmissionPackageFileSystemInfo uppInfo, NintendoSubmissionPackageFileSystemInfo patchInfo, KeyConfiguration keyConfig)
    {
      XciSizeInfo xciSizeInfo = new XciSizeInfo();
      xciSizeInfo.RootPartitionOffset = (long) XciInfo.NormalAreaStartPageAddress * (long) XciInfo.PageSize;
      ProdEncryptedXciArchive.CalculateRootPartitionHeaderSize(out xciSizeInfo.RootPartitionHeaderSize);
      xciSizeInfo.UpdatePartitionOffset = xciSizeInfo.RootPartitionOffset + xciSizeInfo.RootPartitionHeaderSize;
      ProdEncryptedXciArchive.CalculateUpdatePartitionSize(out xciSizeInfo.UpdatePartitionHeaderSize, out xciSizeInfo.UpdatePartitionSize, uppInfo);
      xciSizeInfo.NormalPartitionOffset = xciSizeInfo.UpdatePartitionOffset + xciSizeInfo.UpdatePartitionHeaderSize + xciSizeInfo.UpdatePartitionSize;
      ProdEncryptedXciArchive.CalculatePartitionSize(out xciSizeInfo.NormalPartitionHeaderSize, out xciSizeInfo.NormalPartitionSize, nspInfo, patchInfo, true, keyConfig);
      xciSizeInfo.SecurePartitionOffset = ProdEncryptedXciArchive.RoundupRomAreaStartPageAddress(xciSizeInfo.NormalPartitionOffset + xciSizeInfo.NormalPartitionHeaderSize + xciSizeInfo.NormalPartitionSize) + (long) (XciInfo.CardKeyAreaPageCount * XciInfo.PageSize);
      ProdEncryptedXciArchive.CalculatePartitionSize(out xciSizeInfo.SecurePartitionHeaderSize, out xciSizeInfo.SecurePartitionSize, nspInfo, patchInfo, false, keyConfig);
      xciSizeInfo.TotalSize = xciSizeInfo.SecurePartitionOffset + xciSizeInfo.SecurePartitionHeaderSize + xciSizeInfo.SecurePartitionSize;
      return xciSizeInfo;
    }

    internal byte[] CreateInitialData(ulong packageId, Pair<byte[], byte[]> titleKeys)
    {
      byte[] array1 = ((IEnumerable<byte>) titleKeys.first).Concat<byte>((IEnumerable<byte>) titleKeys.second).ToArray<byte>();
      byte[] src = new byte[XciMeta.InitialDataASize];
      byte[] bytes = BitConverter.GetBytes(packageId);
      Buffer.BlockCopy((Array) bytes, 0, (Array) src, 0, bytes.Length);
      byte[] numArray1 = new byte[this.m_initialDataEncryptor.KeySize];
      this.m_initialDataEncryptor.DecryptBlock(src, 0, src.Length, numArray1, 0);
      byte[] dstMac = new byte[XciMeta.InitialDataMacSize];
      byte[] aad = new byte[0];
      byte[] numArray2 = new byte[XciMeta.InitialDataNonceSize];
      this.m_rng.GetBytes(numArray2);
      byte[] dst = new byte[array1.Length];
      new Aes128CcmCryptoDriver(numArray1).EncryptBlock(numArray2, aad, array1, 0, array1.Length, dstMac, 0, dstMac.Length, dst, 0);
      byte[] numArray3 = new byte[XciMeta.InitialDataSize];
      byte[] array2 = ((IEnumerable<byte>) src).Concat<byte>((IEnumerable<byte>) dst).Concat<byte>((IEnumerable<byte>) dstMac).Concat<byte>((IEnumerable<byte>) numArray2).ToArray<byte>();
      Buffer.BlockCopy((Array) array2, 0, (Array) numArray3, 0, array2.Length);
      return numArray3;
    }

    internal byte[] CreateKeyArea(byte[] initialData, Pair<byte[], byte[]> titleKeys)
    {
      byte[] numArray = new byte[(int) XciInfo.PageSize * (int) XciInfo.CardKeyAreaPageCount];
      byte[] array = ((IEnumerable<byte>) initialData).Concat<byte>((IEnumerable<byte>) titleKeys.first).Concat<byte>((IEnumerable<byte>) titleKeys.second).ToArray<byte>();
      Buffer.BlockCopy((Array) array, 0, (Array) numArray, 0, array.Length);
      return numArray;
    }

    internal byte[] EncryptKeyArea(byte[] keyArea)
    {
      byte[] numArray1 = new byte[keyArea.Length];
      Buffer.BlockCopy((Array) keyArea, 0, (Array) numArray1, 0, keyArea.Length);
      byte[] numArray2 = new byte[16];
      byte[] numArray3 = new byte[16];
      this.m_rng.GetBytes(numArray2);
      this.m_rng.GetBytes(numArray3);
      new Aes128CtrCryptoDriver(numArray2).EncryptBlock(numArray3, numArray1, XciMeta.KeyAreaEncryptionTargetOffset, XciMeta.KeyAreaEncryptionTargetSize, numArray1, XciMeta.KeyAreaEncryptionTargetOffset);
      byte[] array = ((IEnumerable<byte>) numArray2).Concat<byte>((IEnumerable<byte>) numArray3).ToArray<byte>();
      byte[] dst = new byte[this.m_keyAreaEncryptionKeyIvEncryptor.KeySize];
      this.m_keyAreaEncryptionKeyIvEncryptor.EncryptBlock(array, 0, array.Length, dst, 0);
      Buffer.BlockCopy((Array) dst, 0, (Array) numArray1, XciMeta.KeyAreaEncryptionTargetOffset + XciMeta.KeyAreaEncryptionTargetSize, dst.Length);
      return numArray1;
    }

    private void AddPaddingConnection(ISink outSink, long offset, long size)
    {
      if (size == 0L)
        return;
      this.ConnectionList.Add(new Connection((ISource) new PaddingSource(size), (ISink) new SubSink(outSink, offset, size)));
    }

    public ProdEncryptedXciArchive(IReadableSink outSink, NintendoSubmissionPackageReader nspReader, NintendoSubmissionPackageReader uppReader, NintendoSubmissionPackageReader patchReader, byte launchFlags, KeyConfiguration keyConfig)
    {
      this.ConnectionList = new List<Connection>();
      this.m_rng = new RNGCryptoServiceProvider();
      this.m_keyConfig = keyConfig;
      this.SetCryptor(this.m_keyConfig);
      uint num1 = 0;
      uint num2 = 0;
      ulong num3 = 0;
      byte[] numArray1 = (byte[]) null;
      NintendoSubmissionPackageFileSystemInfo prodNspInfo = ArchiveReconstructionUtils.GetProdNspInfo(nspReader, this.m_keyConfig);
      XciUtils.CheckRomSizeAndClockRate(prodNspInfo.CardSize, prodNspInfo.CardClockRate);
      NintendoSubmissionPackageFileSystemInfo uppInfo = (NintendoSubmissionPackageFileSystemInfo) null;
      if (uppReader != null)
        uppInfo = ArchiveReconstructionUtils.GetProdNspInfo(uppReader, this.m_keyConfig);
      XciSizeInfo xciSize = ProdEncryptedXciArchive.CalculateXciSize(prodNspInfo, uppInfo, (NintendoSubmissionPackageFileSystemInfo) null, this.m_keyConfig);
      int romSize = XciUtils.GetRomSize(xciSize.TotalSize);
      if (romSize == XciInfo.InvalidRomSize)
        throw new ArgumentException(string.Format("Xci size exceed the maximum size of the game card.", Array.Empty<object>()));
      if (prodNspInfo.CardSize < romSize)
        throw new ArgumentException(string.Format("Xci requires CardSpec/Size = {0}, though it is set as {1}.", (object) romSize, (object) prodNspInfo.CardSize));
      outSink.SetSize(xciSize.TotalSize);
      List<Sha256PartitionFsHashSource> hashSources1 = new List<Sha256PartitionFsHashSource>();
      PartitionFileSystemInfo partFsInfo1 = new PartitionFileSystemInfo();
      List<ContentHashSource> hashSources2 = new List<ContentHashSource>();
      List<Sha256PartitionFsHashSource> hashSources3 = new List<Sha256PartitionFsHashSource>();
      if (uppInfo != null && uppReader != null)
      {
        long partitionHeaderSize = xciSize.UpdatePartitionHeaderSize;
        foreach (NintendoSubmissionPackageFileSystemInfo.EntryInfo entry in uppInfo.Entries)
        {
          if (entry.MetaType == "SystemUpdate")
          {
            NintendoContentMetaReader contentMetaReader = new NintendoContentMetaReader(entry.ContentMetaInfo.Data);
            num2 = contentMetaReader.GetVersion();
            num3 = contentMetaReader.GetId();
          }
        }
        byte[] buffer = uppReader.ReadBase(0L, uppReader.GetBaseSize());
        numArray1 = new SHA256CryptoServiceProvider().ComputeHash(buffer, 0, buffer.Length);
        foreach (Tuple<string, long> tuple in uppReader.ListFileInfo().FindAll((Predicate<Tuple<string, long>>) (x => x.Item1.EndsWith(".nca"))))
        {
          string str = tuple.Item1;
          long num4 = tuple.Item2;
          ulong offset = (ulong) (partitionHeaderSize - xciSize.UpdatePartitionHeaderSize);
          PartitionFileSystemInfo.EntryInfo entryInfo = PartitionFileSystemInfo.EntryInfo.Make(str, (ulong) num4, offset, 0UL, XciInfo.PageSize);
          partFsInfo1.entries.Add(entryInfo);
          FileSystemArchvieFileSource archvieFileSource = new FileSystemArchvieFileSource((IFileSystemArchiveReader) uppReader, str);
          IReadableSink readableSink = (IReadableSink) new ReadableSubSink(outSink, xciSize.UpdatePartitionOffset + partitionHeaderSize, archvieFileSource.Size);
          this.ConnectionList.Add(new Connection((ISource) archvieFileSource, (ISink) readableSink));
          hashSources2.Add(new ContentHashSource((ISource) null, "no_change"));
          SinkLinkedSource sinkLinkedSource = new SinkLinkedSource((ISink) readableSink, (ISource) new Sha256StreamHashSource((ISource) new SubSource(readableSink.ToSource(), 0L, (long) XciInfo.PageSize)));
          hashSources3.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource, hashSources3.Count));
          partitionHeaderSize += archvieFileSource.Size;
        }
      }
      HashAdaptedSha256PartitionFsHeaderSource partitionFsHeaderSource1 = new HashAdaptedSha256PartitionFsHeaderSource((ISource) new HashNameEntryPartitionFsHeaderSource<Sha256PartitionFileSystemMeta>(hashSources2, partFsInfo1, xciSize.UpdatePartitionHeaderSize), hashSources3);
      IReadableSink readableSink1 = (IReadableSink) new ReadableSubSink(outSink, xciSize.UpdatePartitionOffset, partitionFsHeaderSource1.Size);
      this.ConnectionList.Add(new Connection((ISource) partitionFsHeaderSource1, (ISink) readableSink1));
      SinkLinkedSource sinkLinkedSource1 = new SinkLinkedSource((ISink) readableSink1, (ISource) new Sha256StreamHashSource((ISource) new SubSource(readableSink1.ToSource(), 0L, xciSize.UpdatePartitionHeaderSize)));
      hashSources1.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource1, hashSources1.Count));
      PartitionFileSystemInfo partFsInfo2 = new PartitionFileSystemInfo();
      PartitionFileSystemInfo partFsInfo3 = new PartitionFileSystemInfo();
      List<ContentHashSource> hashSources4 = new List<ContentHashSource>();
      List<ContentHashSource> hashSources5 = new List<ContentHashSource>();
      List<Sha256PartitionFsHashSource> hashSources6 = new List<Sha256PartitionFsHashSource>();
      List<Sha256PartitionFsHashSource> hashSources7 = new List<Sha256PartitionFsHashSource>();
      long partitionHeaderSize1 = xciSize.SecurePartitionHeaderSize;
      long partitionHeaderSize2 = xciSize.NormalPartitionHeaderSize;
      for (int index1 = 0; index1 < prodNspInfo.Entries.Count; ++index1)
      {
        NintendoSubmissionPackageFileSystemInfo.EntryInfo entry = prodNspInfo.Entries[index1];
        List<Tuple<ISource, NintendoContentInfo>> contentSourceList = new List<Tuple<ISource, NintendoContentInfo>>();
        for (int index2 = 0; index2 < entry.Contents.Count; ++index2)
        {
          NintendoSubmissionPackageFileSystemInfo.ContentInfo content = entry.Contents[index2];
          if (!(content.ContentType == "Meta"))
          {
            if (content.ContentType == "Program")
              num1 = (content.FsInfo as NintendoContentFileSystemInfo).sdkAddonVersion;
            (content.FsInfo as NintendoContentFileSystemInfo).distributionType = (byte) 1;
            NintendoContentArchiveSource contentArchiveSource = new NintendoContentArchiveSource(content.FsInfo as NintendoContentFileSystemInfo, this.m_keyConfig, false);
            ulong offset1 = (ulong) (partitionHeaderSize1 - xciSize.SecurePartitionHeaderSize);
            PartitionFileSystemInfo.EntryInfo entryInfo1 = PartitionFileSystemInfo.EntryInfo.Make("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nca", (ulong) contentArchiveSource.Size, offset1, 0UL, XciInfo.PageSize);
            partFsInfo2.entries.Add(entryInfo1);
            IReadableSink readableSink2 = (IReadableSink) new ReadableSubSink(outSink, xciSize.SecurePartitionOffset + partitionHeaderSize1, contentArchiveSource.Size);
            this.ConnectionList.Add(new Connection((ISource) contentArchiveSource, (ISink) readableSink2));
            SinkLinkedSource sinkLinkedSource2 = new SinkLinkedSource((ISink) readableSink2, (ISource) new Sha256StreamHashSource(readableSink2.ToSource()));
            SinkLinkedSource sinkLinkedSource3 = new SinkLinkedSource((ISink) readableSink2, (ISource) new Sha256StreamHashSource((ISource) new SubSource(readableSink2.ToSource(), 0L, (long) XciInfo.PageSize)));
            hashSources4.Add(new ContentHashSource((ISource) sinkLinkedSource2, ".nca"));
            hashSources6.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource3, hashSources6.Count));
            contentSourceList.Add(Tuple.Create<ISource, NintendoContentInfo>(hashSources4[hashSources4.Count - 1].Source, new NintendoContentInfo(content.ContentType, contentArchiveSource.Size)));
            partitionHeaderSize1 += ProdEncryptedXciArchive.RoundupPageSize(contentArchiveSource.Size);
            if (content.ContentType == "Control")
            {
              ulong offset2 = (ulong) (partitionHeaderSize2 - xciSize.NormalPartitionHeaderSize);
              PartitionFileSystemInfo.EntryInfo entryInfo2 = PartitionFileSystemInfo.EntryInfo.Make("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.nca", (ulong) contentArchiveSource.Size, offset2, 0UL, XciInfo.PageSize);
              partFsInfo3.entries.Add(entryInfo2);
              SinkLinkedSource sinkLinkedSource4 = new SinkLinkedSource((ISink) readableSink2, readableSink2.ToSource());
              IReadableSink readableSink3 = (IReadableSink) new ReadableSubSink(outSink, xciSize.NormalPartitionOffset + partitionHeaderSize2, sinkLinkedSource4.Size);
              this.ConnectionList.Add(new Connection((ISource) sinkLinkedSource4, (ISink) readableSink3));
              hashSources5.Add(new ContentHashSource((ISource) sinkLinkedSource2, ".nca"));
              hashSources7.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource3, hashSources7.Count));
              partitionHeaderSize2 += ProdEncryptedXciArchive.RoundupPageSize(contentArchiveSource.Size);
            }
          }
        }
        NintendoContentMetaArchiveSource metaArchiveSource = new NintendoContentMetaArchiveSource(new NintendoContentMetaBase(contentSourceList, entry.ContentMetaInfo.Data, entry.ContentMetaInfo.Model, true), entry.KeyIndex, this.m_keyConfig, prodNspInfo.IsProdEncryption, true);
        ulong offset3 = (ulong) (partitionHeaderSize1 - xciSize.SecurePartitionHeaderSize);
        PartitionFileSystemInfo.EntryInfo entryInfo3 = PartitionFileSystemInfo.EntryInfo.Make("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt.nca", (ulong) metaArchiveSource.Size, offset3, 0UL, XciInfo.PageSize);
        partFsInfo2.entries.Add(entryInfo3);
        IReadableSink readableSink4 = (IReadableSink) new ReadableSubSink(outSink, xciSize.SecurePartitionOffset + partitionHeaderSize1, metaArchiveSource.Size);
        this.ConnectionList.Add(new Connection((ISource) metaArchiveSource, (ISink) readableSink4));
        SinkLinkedSource sinkLinkedSource5 = new SinkLinkedSource((ISink) readableSink4, (ISource) new Sha256StreamHashSource(readableSink4.ToSource()));
        SinkLinkedSource sinkLinkedSource6 = new SinkLinkedSource((ISink) readableSink4, (ISource) new Sha256StreamHashSource((ISource) new SubSource(readableSink4.ToSource(), 0L, (long) XciInfo.PageSize)));
        hashSources4.Add(new ContentHashSource((ISource) sinkLinkedSource5, ".cnmt.nca"));
        hashSources6.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource6, hashSources6.Count));
        partitionHeaderSize1 += ProdEncryptedXciArchive.RoundupPageSize(metaArchiveSource.Size);
        ulong offset4 = (ulong) (partitionHeaderSize2 - xciSize.NormalPartitionHeaderSize);
        PartitionFileSystemInfo.EntryInfo entryInfo4 = PartitionFileSystemInfo.EntryInfo.Make("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.cnmt.nca", (ulong) metaArchiveSource.Size, offset4, 0UL, XciInfo.PageSize);
        partFsInfo3.entries.Add(entryInfo4);
        SinkLinkedSource sinkLinkedSource7 = new SinkLinkedSource((ISink) readableSink4, readableSink4.ToSource());
        IReadableSink readableSink5 = (IReadableSink) new ReadableSubSink(outSink, xciSize.NormalPartitionOffset + partitionHeaderSize2, sinkLinkedSource7.Size);
        this.ConnectionList.Add(new Connection((ISource) sinkLinkedSource7, (ISink) readableSink5));
        hashSources5.Add(new ContentHashSource((ISource) sinkLinkedSource5, ".cnmt.nca"));
        hashSources7.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource6, hashSources7.Count));
        partitionHeaderSize2 += ProdEncryptedXciArchive.RoundupPageSize(metaArchiveSource.Size);
      }
      HashAdaptedSha256PartitionFsHeaderSource partitionFsHeaderSource2 = new HashAdaptedSha256PartitionFsHeaderSource((ISource) new HashNameEntryPartitionFsHeaderSource<Sha256PartitionFileSystemMeta>(hashSources5, partFsInfo3, xciSize.NormalPartitionHeaderSize), hashSources7);
      IReadableSink readableSink6 = (IReadableSink) new ReadableSubSink(outSink, xciSize.NormalPartitionOffset, partitionFsHeaderSource2.Size);
      this.ConnectionList.Add(new Connection((ISource) partitionFsHeaderSource2, (ISink) readableSink6));
      SinkLinkedSource sinkLinkedSource8 = new SinkLinkedSource((ISink) readableSink6, (ISource) new Sha256StreamHashSource((ISource) new SubSource(readableSink6.ToSource(), 0L, xciSize.NormalPartitionHeaderSize)));
      hashSources1.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource8, hashSources1.Count));
      HashAdaptedSha256PartitionFsHeaderSource partitionFsHeaderSource3 = new HashAdaptedSha256PartitionFsHeaderSource((ISource) new HashNameEntryPartitionFsHeaderSource<Sha256PartitionFileSystemMeta>(hashSources4, partFsInfo2, xciSize.SecurePartitionHeaderSize), hashSources6);
      IReadableSink readableSink7 = (IReadableSink) new ReadableSubSink(outSink, xciSize.SecurePartitionOffset, partitionFsHeaderSource3.Size);
      this.ConnectionList.Add(new Connection((ISource) partitionFsHeaderSource3, (ISink) readableSink7));
      SinkLinkedSource sinkLinkedSource9 = new SinkLinkedSource((ISink) readableSink7, (ISource) new Sha256StreamHashSource((ISource) new SubSource(readableSink7.ToSource(), 0L, xciSize.SecurePartitionHeaderSize)));
      hashSources1.Add(new Sha256PartitionFsHashSource((ISource) sinkLinkedSource9, hashSources1.Count));
      PartitionFileSystemInfo partFsInfo4 = new PartitionFileSystemInfo();
      List<ContentHashSource> hashSources8 = new List<ContentHashSource>();
      ulong offset5 = (ulong) (xciSize.UpdatePartitionOffset - xciSize.UpdatePartitionOffset);
      PartitionFileSystemInfo.EntryInfo entryInfo5 = PartitionFileSystemInfo.EntryInfo.Make("update", (ulong) (xciSize.UpdatePartitionHeaderSize + xciSize.UpdatePartitionSize), offset5, 0UL, (uint) xciSize.UpdatePartitionHeaderSize);
      partFsInfo4.entries.Add(entryInfo5);
      hashSources8.Add(new ContentHashSource((ISource) null, "update"));
      ulong offset6 = (ulong) (xciSize.NormalPartitionOffset - xciSize.UpdatePartitionOffset);
      PartitionFileSystemInfo.EntryInfo entryInfo6 = PartitionFileSystemInfo.EntryInfo.Make("normal", (ulong) (xciSize.NormalPartitionHeaderSize + xciSize.NormalPartitionSize), offset6, 0UL, (uint) xciSize.NormalPartitionHeaderSize);
      partFsInfo4.entries.Add(entryInfo6);
      hashSources8.Add(new ContentHashSource((ISource) null, "normal"));
      ulong offset7 = (ulong) (xciSize.SecurePartitionOffset - xciSize.UpdatePartitionOffset);
      PartitionFileSystemInfo.EntryInfo entryInfo7 = PartitionFileSystemInfo.EntryInfo.Make("secure", (ulong) (xciSize.SecurePartitionHeaderSize + xciSize.SecurePartitionSize), offset7, 0UL, (uint) xciSize.SecurePartitionHeaderSize);
      partFsInfo4.entries.Add(entryInfo7);
      hashSources8.Add(new ContentHashSource((ISource) null, "secure"));
      HashAdaptedSha256PartitionFsHeaderSource partitionFsHeaderSource4 = new HashAdaptedSha256PartitionFsHeaderSource((ISource) new HashNameEntryPartitionFsHeaderSource<Sha256PartitionFileSystemMeta>(hashSources8, partFsInfo4, xciSize.RootPartitionHeaderSize), hashSources1);
      IReadableSink readableSink8 = (IReadableSink) new ReadableSubSink(outSink, xciSize.RootPartitionOffset, partitionFsHeaderSource4.Size);
      this.ConnectionList.Add(new Connection((ISource) partitionFsHeaderSource4, (ISink) readableSink8));
      ISource rootPartitionFsHeaderHashSource = (ISource) new SinkLinkedSource((ISink) readableSink8, (ISource) new Sha256StreamHashSource((ISource) new SubSource(readableSink8.ToSource(), 0L, xciSize.RootPartitionHeaderSize)));
      byte[] data1 = new byte[8];
      this.m_rng.GetBytes(data1);
      ulong uint64 = BitConverter.ToUInt64(data1, 0);
      byte[] numArray2 = new byte[XciMeta.TitleKey1Size];
      byte[] numArray3 = new byte[XciMeta.TitleKey2Size];
      this.m_rng.GetBytes(numArray2);
      this.m_rng.GetBytes(numArray3);
      byte[] initialData = this.CreateInitialData(uint64, new Pair<byte[], byte[]>(numArray2, numArray3));
      byte[] keyArea = this.CreateKeyArea(initialData, new Pair<byte[], byte[]>(numArray2, numArray3));
      MemorySource memorySource = new MemorySource(keyArea, 0, keyArea.Length);
      byte[] data2 = new byte[XciInfo.IvSize];
      this.m_rng.GetBytes(data2);
      XciInfo xciInfo = new XciInfo();
      xciInfo.romAreaStartPageAddress = (uint) ((ulong) xciSize.SecurePartitionOffset / (ulong) XciInfo.PageSize) - XciInfo.CardKeyAreaPageCount;
      xciInfo.kekIndex = XciInfo.KekIndexVersion0;
      xciInfo.romSize = XciInfo.ConvertRomSizeToRomSizeByte(prodNspInfo.CardSize);
      xciInfo.flags = launchFlags;
      xciInfo.packageId = uint64;
      xciInfo.validDataEndAddress = (uint) ((int) (uint) ((ulong) ProdEncryptedXciArchive.RoundupPageSize(xciSize.TotalSize) / (ulong) XciInfo.PageSize) - (int) XciInfo.CardKeyAreaPageCount - 1);
      xciInfo.iv = data2;
      xciInfo.partitionFsHeaderAddress = (ulong) (XciInfo.NormalAreaStartPageAddress - XciInfo.CardKeyAreaPageCount) * (ulong) XciInfo.PageSize;
      xciInfo.partitionFsHeaderSize = (ulong) xciSize.RootPartitionHeaderSize;
      xciInfo.partitionFsHeaderHash = (byte[]) null;
      xciInfo.selSec = XciInfo.SelSecForT1;
      xciInfo.fwVersion = XciInfo.FwVersion;
      xciInfo.accCtrl1 = XciInfo.ConvertClockRateToAccCtrl1(prodNspInfo.CardClockRate);
      xciInfo.fwMode = num1;
      xciInfo.cupVersion = num2;
      xciInfo.cupId = num3;
      xciInfo.uppHash = numArray1 != null ? ((IEnumerable<byte>) numArray1).Take<byte>(XciInfo.UppHashSize).ToArray<byte>() : new byte[XciInfo.UppHashSize];
      XciMeta xciMeta = new XciMeta(initialData);
      XciHeaderSource xciHeaderSource = new XciHeaderSource(ref xciInfo, xciMeta, rootPartitionFsHeaderHashSource, this.m_headerEncryptor, this.m_headerSigner);
      ReadableSubSink readableSubSink1 = new ReadableSubSink(outSink, 0L, memorySource.Size);
      this.ConnectionList.Add(new Connection((ISource) memorySource, (ISink) readableSubSink1));
      ReadableSubSink readableSubSink2 = new ReadableSubSink(outSink, memorySource.Size, xciHeaderSource.Size);
      this.ConnectionList.Add(new Connection((ISource) xciHeaderSource, (ISink) readableSubSink2));
    }

    public ProdEncryptedXciArchive(ISink outSink, ISource xciSource, KeyConfiguration keyConfig)
    {
      this.ConnectionList = new List<Connection>();
      this.m_rng = new RNGCryptoServiceProvider();
      this.m_keyConfig = keyConfig;
      this.SetCryptor(this.m_keyConfig);
      byte[] keyArea = new byte[(int) XciInfo.PageSize * (int) XciInfo.CardKeyAreaPageCount];
      ByteData byteData = xciSource.PullData(0L, (int) XciInfo.PageSize * (int) XciInfo.CardKeyAreaPageCount);
      ArraySegment<byte> buffer1 = byteData.Buffer;
      byte[] array = buffer1.Array;
      buffer1 = byteData.Buffer;
      int offset = buffer1.Offset;
      byte[] numArray = keyArea;
      int dstOffset = 0;
      buffer1 = byteData.Buffer;
      int count = buffer1.Count;
      Buffer.BlockCopy((Array) array, offset, (Array) numArray, dstOffset, count);
      byte[] buffer2 = this.EncryptKeyArea(keyArea);
      MemorySource memorySource = new MemorySource(buffer2, 0, buffer2.Length);
      AdaptedSource adaptedSource = new AdaptedSource(xciSource, (ISource) memorySource, 0L, memorySource.Size);
      outSink.SetSize(adaptedSource.Size);
      this.ConnectionList.Add(new Connection((ISource) adaptedSource, outSink));
    }

    public ISource GetSource()
    {
      throw new NotImplementedException();
    }
  }
}
