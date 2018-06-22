// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.NintendoContentArchiveSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using ContentArchiveLibrary;
using Nintendo.Authoring.CryptoLibrary;
using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class NintendoContentArchiveSource : ISource
  {
    private ISource m_source;
    private ISource m_headerSource;
    private ISource m_bodySource;
    private NintendoContentFileSystemInfo m_fileSystemInfo;
    private KeyConfiguration m_keyConfig;
    private const int SectorSize = 512;
    private const int AesBlockSize = 512;
    private const int FsHeaderCountMax = 4;
    private IEncryptor m_bodyEncryptionKeyEncryptor;
    private IXtsModeEncryptor m_headerEncryptor;
    private ISigner m_header1Signer;
    private ISigner m_header2Signer;
    private ISigner m_acidSigner;
    private ISigner m_nrrSigner;
    private ISigner m_nrrCertificateSigner;

    public long Size { get; private set; }

    public static byte VerifyHashType(NintendoContentFileSystemInfo fileSystemInfo, NintendoContentFileSystemInfo.EntryInfo entryInfo)
    {
      NintendoContentArchiveHashType contentArchiveHashType = (NintendoContentArchiveHashType) entryInfo.hashType;
      if (contentArchiveHashType == NintendoContentArchiveHashType.Auto)
      {
        string formatType = entryInfo.formatType;
        if (!(formatType == "PartitionFs"))
        {
          if (!(formatType == "RomFs"))
            throw new InvalidDataException("invalid format type.");
          contentArchiveHashType = NintendoContentArchiveHashType.HierarchicalIntegrity;
        }
        else
          contentArchiveHashType = NintendoContentArchiveHashType.HierarchicalSha256;
      }
      if (contentArchiveHashType != NintendoContentArchiveHashType.HierarchicalSha256 && contentArchiveHashType != NintendoContentArchiveHashType.HierarchicalIntegrity)
        throw new InvalidDataException("invalid hash type.");
      return (byte) contentArchiveHashType;
    }

    public static byte VerifyEncryptionType(NintendoContentFileSystemInfo fileSystemInfo, NintendoContentFileSystemInfo.EntryInfo entryInfo)
    {
      NintendoContentArchiveEncryptionType archiveEncryptionType = (NintendoContentArchiveEncryptionType) entryInfo.encryptionType;
      if (archiveEncryptionType == NintendoContentArchiveEncryptionType.Auto)
      {
        if (fileSystemInfo.contentType == (byte) 0)
        {
          switch (entryInfo.partitionIndex)
          {
            case 0:
            case 1:
              archiveEncryptionType = NintendoContentArchiveEncryptionType.AesCtr;
              break;
            case 2:
              archiveEncryptionType = NintendoContentArchiveEncryptionType.None;
              break;
            default:
              throw new InvalidDataException("invalid partition index.");
          }
        }
        else
          archiveEncryptionType = NintendoContentArchiveEncryptionType.AesCtr;
      }
      if (fileSystemInfo.contentType == (byte) 0 && entryInfo.partitionIndex == 2 && archiveEncryptionType != NintendoContentArchiveEncryptionType.None)
        throw new InvalidDataException("logo must be no encryption type.");
      if (archiveEncryptionType != NintendoContentArchiveEncryptionType.None && archiveEncryptionType != NintendoContentArchiveEncryptionType.AesCtr)
        throw new InvalidDataException("invalid encryption type.");
      return (byte) archiveEncryptionType;
    }

    private void SetCryptor(KeyConfiguration config)
    {
      if (this.m_fileSystemInfo.isProdEncryption)
      {
        this.m_bodyEncryptionKeyEncryptor = this.m_keyConfig.GetProdKeyAreaEncryptionKey() == null ? (IEncryptor) new HsmAes128CryptoDriver(Aes128KeyIndex.NcaContentKey) : (IEncryptor) new Aes128CryptoDriver(this.m_keyConfig.GetProdKeyAreaEncryptionKey().Key);
        byte[][] numArray1 = new byte[2][]
        {
          new byte[16],
          new byte[16]
        };
        byte[][] numArray2 = new byte[2][]
        {
          new byte[16]
          {
            (byte) 90,
            (byte) 62,
            (byte) 216,
            (byte) 79,
            (byte) 222,
            (byte) 192,
            (byte) 216,
            (byte) 38,
            (byte) 49,
            (byte) 247,
            (byte) 226,
            (byte) 93,
            (byte) 25,
            (byte) 123,
            (byte) 245,
            (byte) 208
          },
          new byte[16]
          {
            (byte) 28,
            (byte) 155,
            (byte) 123,
            (byte) 250,
            (byte) 246,
            (byte) 40,
            (byte) 24,
            (byte) 61,
            (byte) 113,
            (byte) 246,
            (byte) 77,
            (byte) 115,
            (byte) 241,
            (byte) 80,
            (byte) 185,
            (byte) 210
          }
        };
        IEncryptor encryptor = this.m_keyConfig.GetProdNcaHeaderEncryptionKek() == null ? (IEncryptor) new HsmAes128CryptoDriver(Aes128KeyIndex.NcaHeader) : (IEncryptor) new Aes128CryptoDriver(this.m_keyConfig.GetProdNcaHeaderEncryptionKek().Key);
        encryptor.DecryptBlock(numArray2[0], 0, 16, numArray1[0], 0);
        encryptor.DecryptBlock(numArray2[1], 0, 16, numArray1[1], 0);
        this.m_headerEncryptor = (IXtsModeEncryptor) new Aes128XtsCryptoDriver(numArray1[0], numArray1[1]);
        if (this.m_keyConfig.GetNcaHeader1SignKey() != null)
        {
          RsaKey ncaHeader1SignKey = this.m_keyConfig.GetNcaHeader1SignKey();
          this.m_header1Signer = (ISigner) new Rsa2048PssSha256SignCryptoDriver(ncaHeader1SignKey.KeyModulus, ncaHeader1SignKey.KeyPublicExponent, ncaHeader1SignKey.KeyPrivateExponent);
        }
        else
          this.m_header1Signer = (ISigner) new HsmRsa2048PssSha256SignCryptoDriver(Rsa2048PssSha256KeyIndex.NcaHeader1);
        if (this.m_fileSystemInfo.contentType != (byte) 0)
        {
          this.m_header2Signer = (ISigner) null;
        }
        else
        {
          RsaKey randomRsaKey = this.m_keyConfig.GetRandomRsaKey();
          this.m_header2Signer = (ISigner) new Rsa2048PssSha256SignCryptoDriver(randomRsaKey.KeyModulus, randomRsaKey.KeyPublicExponent, randomRsaKey.KeyPrivateExponent);
        }
        if (this.m_keyConfig.GetAcidSignKey() != null)
        {
          RsaKey acidSignKey = this.m_keyConfig.GetAcidSignKey();
          this.m_acidSigner = (ISigner) new Rsa2048PssSha256SignCryptoDriver(acidSignKey.KeyModulus, acidSignKey.KeyPublicExponent, acidSignKey.KeyPrivateExponent);
        }
        else
          this.m_acidSigner = (ISigner) new HsmRsa2048PssSha256SignCryptoDriver(Rsa2048PssSha256KeyIndex.Acid);
        RsaKey randomRsaKey1 = this.m_keyConfig.GetRandomRsaKey();
        this.m_nrrSigner = (ISigner) new Rsa2048PssSha256SignCryptoDriver(randomRsaKey1.KeyModulus, randomRsaKey1.KeyPublicExponent, randomRsaKey1.KeyPrivateExponent);
        if (this.m_keyConfig.GetNrrCertificateSignKey() != null)
        {
          RsaKey certificateSignKey = this.m_keyConfig.GetNrrCertificateSignKey();
          this.m_nrrCertificateSigner = (ISigner) new Rsa2048PssSha256SignCryptoDriver(certificateSignKey.KeyModulus, certificateSignKey.KeyPublicExponent, certificateSignKey.KeyPrivateExponent);
        }
        else
          this.m_nrrCertificateSigner = (ISigner) new HsmRsa2048PssSha256SignCryptoDriver(Rsa2048PssSha256KeyIndex.NrrCertificate);
      }
      else
      {
        this.m_bodyEncryptionKeyEncryptor = (IEncryptor) new Aes128CryptoDriver(this.m_keyConfig.GetKeyAreaEncryptionKey((uint) this.m_fileSystemInfo.keyAreaEncryptionKeyIndex).Key);
        this.m_headerEncryptor = (IXtsModeEncryptor) new Aes128XtsCryptoDriver(Aes128XtsCryptoDriver.GetDefaultKey(2), Aes128XtsCryptoDriver.GetDefaultKey(3));
        this.m_header1Signer = (ISigner) new Rsa2048PssSha256SignCryptoDriver(Rsa2048PssSha256KeyIndex.NcaHeader1);
        this.m_header2Signer = this.m_fileSystemInfo.contentType != (byte) 0 || this.m_fileSystemInfo.header2SignKeyModulus == null || (this.m_fileSystemInfo.header2SignKeyPublicExponent == null || this.m_fileSystemInfo.header2SignKeyPrivateExponent == null) ? (ISigner) null : (ISigner) new Rsa2048PssSha256SignCryptoDriver(this.m_fileSystemInfo.header2SignKeyModulus, this.m_fileSystemInfo.header2SignKeyPublicExponent, this.m_fileSystemInfo.header2SignKeyPrivateExponent);
        this.m_acidSigner = (ISigner) null;
        this.m_nrrSigner = (ISigner) new Rsa2048PssSha256SignCryptoDriver(Rsa2048PssSha256KeyIndex.NrrCertificate);
        this.m_nrrCertificateSigner = (ISigner) new Rsa2048PssSha256SignCryptoDriver(Rsa2048PssSha256KeyIndex.NrrCertificate);
      }
    }

    private NintendoContentFileSystemInfo.EntryInfo CreateDefaultLogoPartition()
    {
      NintendoContentFileSystemInfo.EntryInfo entryInfo1 = new NintendoContentFileSystemInfo.EntryInfo();
      entryInfo1.type = "format";
      entryInfo1.partitionType = "logo";
      entryInfo1.formatType = "PartitionFs";
      entryInfo1.version = (ushort) 2;
      entryInfo1.hashType = (byte) 2;
      entryInfo1.encryptionType = (byte) 1;
      PartitionFileSystemInfo partitionFileSystemInfo = new PartitionFileSystemInfo();
      \u003C\u003Ef__AnonymousType0<byte[], string>[] dataArray = new \u003C\u003Ef__AnonymousType0<byte[], string>[2]
      {
        new
        {
          Data = Logo.NintendoLogo,
          FileName = "NintendoLogo.png"
        },
        new
        {
          Data = Logo.StartupMovie,
          FileName = "StartupMovie.gif"
        }
      };
      ulong num = 0;
      foreach (var data1 in dataArray)
      {
        byte[] data2 = data1.Data;
        string fileName = data1.FileName;
        PartitionFileSystemInfo.EntryInfo entryInfo2 = new PartitionFileSystemInfo.EntryInfo();
        entryInfo2.type = "file";
        entryInfo2.name = fileName;
        entryInfo2.offset = num;
        entryInfo2.size = (ulong) data2.Length;
        entryInfo2.sourceInterface = (SourceInterface) new CliCompatibleSource((ISource) new MemorySource(data2, 0, data2.Length));
        partitionFileSystemInfo.entries.Add(entryInfo2);
        num += entryInfo2.size;
      }
      entryInfo1.fileSystemInfo = (Nintendo.Authoring.FileSystemMetaLibrary.FileSystemInfo) partitionFileSystemInfo;
      return entryInfo1;
    }

    private bool NeedsDefaultLogoPartition(NintendoContentFileSystemInfo fileSystemInfo, bool needsLogoPartition)
    {
      if (fileSystemInfo.contentType == (byte) 0 & needsLogoPartition)
      {
        bool flag1 = false;
        bool flag2 = false;
        foreach (NintendoContentFileSystemInfo.EntryInfo fsEntry in fileSystemInfo.fsEntries)
        {
          if (fsEntry.partitionType == "logo")
            flag1 = true;
          if (fsEntry.partitionType == "data")
            flag2 = true;
        }
        if (!flag1 & flag2)
          return true;
      }
      return false;
    }

    private void AddDefaultLogoPartitionIfNeeded(bool needsLogoPartition)
    {
      if (!this.NeedsDefaultLogoPartition(this.m_fileSystemInfo, needsLogoPartition))
        return;
      NintendoContentFileSystemInfo.EntryInfo defaultLogoPartition = this.CreateDefaultLogoPartition();
      defaultLogoPartition.partitionIndex = this.m_fileSystemInfo.fsEntries.Count<NintendoContentFileSystemInfo.EntryInfo>();
      this.m_fileSystemInfo.fsEntries.Add(defaultLogoPartition);
      this.m_fileSystemInfo.numFsEntries = this.m_fileSystemInfo.fsEntries.Count<NintendoContentFileSystemInfo.EntryInfo>();
    }

    public NintendoContentArchiveSource(NintendoContentFileSystemInfo fileSystemInfo, KeyConfiguration config, bool needsLogoPartition = false)
    {
      this.m_fileSystemInfo = fileSystemInfo;
      this.m_keyConfig = config;
      this.SetCryptor(this.m_keyConfig);
      this.AddDefaultLogoPartitionIfNeeded(needsLogoPartition);
      fileSystemInfo.fsEntries.Sort((Comparison<NintendoContentFileSystemInfo.EntryInfo>) ((x, y) => x.partitionIndex.CompareTo(y.partitionIndex)));
      NintendoContentFileSystemMeta meta = new NintendoContentFileSystemMeta();
      NintendoContentFileSystemEntryInfoContainer fsEntries = new NintendoContentFileSystemEntryInfoContainer(fileSystemInfo.fsEntries);
      List<ConcatenatedSource.Element> elements1 = new List<ConcatenatedSource.Element>();
      NintendoContentArchiveSource.BodySourceElement[] bodySources = new NintendoContentArchiveSource.BodySourceElement[fileSystemInfo.fsEntries.Count];
      long offset = (long) meta.GetFsHeaderSize() * 4L;
      foreach (NintendoContentFileSystemInfo.EntryInfo entryInfo in fsEntries)
      {
        if (entryInfo.type != null)
        {
          ISource source = NintendoContentArchiveSource.GetDataSource(entryInfo);
          if (fileSystemInfo.isProdEncryption && fileSystemInfo.contentType == (byte) 0 && entryInfo.partitionIndex == 0)
            source = this.AcidResignedSource(source);
          if (fileSystemInfo.contentType == (byte) 0 && entryInfo.partitionIndex == 1)
            source = this.NrrSignedSource(source);
          int currentIndex = fsEntries.CurrentIndex;
          bodySources[currentIndex].DataOffset = offset;
          NintendoContentArchiveSource.BuildDataInfo buildInfo = new NintendoContentArchiveSource.BuildDataInfo(meta, source, offset, currentIndex);
          fileSystemInfo.fsEntries[currentIndex] = this.BuildData(entryInfo, buildInfo);
          offset = buildInfo.CurrentOffset;
          Sha256HierarchicalHashCalculatedSource calculatedSource = new Sha256HierarchicalHashCalculatedSource(buildInfo.HeaderSource, (int) buildInfo.HeaderSource.Size, 1);
          ConcatenatedSource.Element element1 = new ConcatenatedSource.Element(calculatedSource.GetMasterHashSource(), "fsHeaderHash" + (object) currentIndex, (long) (32 * currentIndex));
          elements1.Add(element1);
          ConcatenatedSource.Element element2 = new ConcatenatedSource.Element((ISource) calculatedSource, "fsHeader" + (object) currentIndex, (long) currentIndex * (long) meta.GetFsHeaderSize());
          bodySources[currentIndex].HeaderElement = element2;
          bodySources[currentIndex].DataSourceElements = buildInfo.DataSourceElements;
        }
      }
      if (fsEntries.IsReverse)
        elements1.Reverse();
      NintendoContentArchiveSource.BodyEncryptionKey bodyEncryptionKey = new NintendoContentArchiveSource.BodyEncryptionKey(fileSystemInfo);
      this.MakeBody(meta, fsEntries, bodySources, bodyEncryptionKey);
      this.MakeNcaHeader(meta, (ISource) new ConcatenatedSource(elements1), bodyEncryptionKey);
      List<ConcatenatedSource.Element> elements2 = new List<ConcatenatedSource.Element>();
      ConcatenatedSource.Element element3 = new ConcatenatedSource.Element(this.m_headerSource, "header", 0L);
      ConcatenatedSource.Element element4 = new ConcatenatedSource.Element(this.m_bodySource, "body", element3.Source.Size);
      elements2.Add(element3);
      elements2.Add(element4);
      this.m_source = (ISource) new ConcatenatedSource(elements2);
      this.Size = this.m_source.Size;
    }

    public ByteData PullData(long offset, int size)
    {
      return this.m_source.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.m_source.QueryStatus();
    }

    internal static ISource GetDataSource(NintendoContentFileSystemInfo.EntryInfo fsEntry)
    {
      if (fsEntry.type == "format")
      {
        string formatType = fsEntry.formatType;
        if (formatType == "PartitionFs")
          return (ISource) new PartitionFsArchiveSource(fsEntry.fileSystemInfo as PartitionFileSystemInfo);
        if (formatType == "RomFs")
          return (ISource) new RomFsArchiveSource(fsEntry.fileSystemInfo as RomFsFileSystemInfo);
        throw new NotImplementedException();
      }
      if (fsEntry.type == "source")
        return (ISource) fsEntry.sourceInterface;
      throw new NotImplementedException();
    }

    private NintendoContentFileSystemInfo.EntryInfo BuildData(NintendoContentFileSystemInfo.EntryInfo entryInfo, NintendoContentArchiveSource.BuildDataInfo buildInfo)
    {
      entryInfo.hashType = NintendoContentArchiveSource.VerifyHashType(this.m_fileSystemInfo, entryInfo);
      entryInfo.encryptionType = NintendoContentArchiveSource.VerifyEncryptionType(this.m_fileSystemInfo, entryInfo);
      entryInfo.startOffset = (ulong) buildInfo.CurrentOffset + buildInfo.Meta.GetHeaderSize();
      entryInfo.hashTargetSize = (ulong) buildInfo.DataSource.Size;
      IHierarchicalHashCalculatedSource calculatedSource;
      switch (entryInfo.hashType)
      {
        case 2:
          calculatedSource = (IHierarchicalHashCalculatedSource) new Sha256HierarchicalHashCalculatedSource(buildInfo.DataSource, buildInfo.Meta.GetHashBlockSize((ValueType) entryInfo), 2);
          break;
        case 3:
          calculatedSource = (IHierarchicalHashCalculatedSource) new IntegrityHierarchicalHashCalculatedSource(buildInfo.DataSource);
          break;
        default:
          throw new NotImplementedException();
      }
      long offset1 = 0;
      ISource layerHashSource = calculatedSource.GetLayerHashSource();
      entryInfo.hashDataSize = (ulong) layerHashSource.Size;
      ConcatenatedSource.Element element1 = new ConcatenatedSource.Element(layerHashSource, "fsHash" + (object) buildInfo.Index, offset1);
      buildInfo.DataSourceElements.Add(element1);
      long offset2 = offset1 + element1.Source.Size;
      int num1 = (int) (offset2 % 512L);
      if (0 < num1)
      {
        ConcatenatedSource.Element element2 = new ConcatenatedSource.Element((ISource) new PaddingSource((long) (512 - num1)), "fsHashPadding" + (object) buildInfo.Index, offset2);
        buildInfo.DataSourceElements.Add(element2);
        offset2 += element2.Source.Size;
      }
      entryInfo.hashTargetOffset = (ulong) offset2;
      ConcatenatedSource.Element element3 = new ConcatenatedSource.Element((ISource) calculatedSource, "fsData" + (object) buildInfo.Index, offset2);
      buildInfo.DataSourceElements.Add(element3);
      long offset3 = offset2 + element3.Source.Size;
      int num2 = (int) (offset3 % 512L);
      if (0 < num2)
      {
        ConcatenatedSource.Element element2 = new ConcatenatedSource.Element((ISource) new PaddingSource((long) (512 - num2)), "fsDataPadding" + (object) buildInfo.Index, offset3);
        buildInfo.DataSourceElements.Add(element2);
        offset3 += element2.Source.Size;
      }
      buildInfo.CurrentOffset += offset3;
      entryInfo.endOffset = (ulong) buildInfo.CurrentOffset + buildInfo.Meta.GetHeaderSize();
      buildInfo.HeaderSource = calculatedSource.GetFsHeaderSource(entryInfo);
      return entryInfo;
    }

    private void MakeBody(NintendoContentFileSystemMeta meta, NintendoContentFileSystemEntryInfoContainer fsEntries, NintendoContentArchiveSource.BodySourceElement[] bodySources, NintendoContentArchiveSource.BodyEncryptionKey bodyEncryptionKey)
    {
      List<ConcatenatedSource.Element> elements = new List<ConcatenatedSource.Element>();
      for (int index = 0; index < bodySources.Length; ++index)
      {
        if (bodySources[index].HeaderElement == null)
        {
          PaddingSource paddingSource = new PaddingSource((long) meta.GetFsHeaderSize());
          elements.Add(new ConcatenatedSource.Element((ISource) paddingSource, "fsHeader" + (object) index, (long) index * (long) meta.GetFsHeaderSize()));
        }
        else
        {
          ConcatenatedSource.Element headerElement = bodySources[index].HeaderElement;
          ISource source = (ISource) new Aes128XtsEncryptedSource(headerElement.Source, this.m_headerEncryptor);
          elements.Add(new ConcatenatedSource.Element(source, headerElement.Signature, headerElement.Offset));
        }
      }
      for (int length = bodySources.Length; length < 4; ++length)
      {
        PaddingSource paddingSource = new PaddingSource((long) meta.GetFsHeaderSize());
        elements.Add(new ConcatenatedSource.Element((ISource) paddingSource, "fsHeader" + (object) length, (long) length * (long) meta.GetFsHeaderSize()));
      }
      foreach (NintendoContentFileSystemInfo.EntryInfo fsEntry in fsEntries)
      {
        int currentIndex = fsEntries.CurrentIndex;
        ISource source = (ISource) new ConcatenatedSource(bodySources[currentIndex].DataSourceElements);
        switch (fsEntry.encryptionType)
        {
          case 1:
            elements.Add(new ConcatenatedSource.Element(source, "fsData" + (object) currentIndex, bodySources[currentIndex].DataOffset));
            continue;
          case 3:
            source = (ISource) new Aes128CtrEncryptedSource(source, (ICtrModeEncryptor) new Aes128CtrCryptoDriver(bodyEncryptionKey.GetInternalKey(NintendoContentArchiveEncryptionKeyIndex.AesCtr)), (int) this.m_fileSystemInfo.keyGeneration, (long) fsEntry.startOffset);
            goto case 1;
          default:
            throw new InvalidDataException();
        }
      }
      this.m_bodySource = (ISource) new ConcatenatedSource(elements);
      this.m_fileSystemInfo.contentSize = meta.GetHeaderSize() + (ulong) this.m_bodySource.Size;
    }

    private void MakeNcaHeader(NintendoContentFileSystemMeta meta, ISource fsHeadersHashSource, NintendoContentArchiveSource.BodyEncryptionKey bodyEncryptionKey)
    {
      byte[] array = bodyEncryptionKey.ToArray();
      byte[] dst = new byte[array.Length];
      this.m_bodyEncryptionKeyEncryptor.EncryptBlock(array, 0, array.Length, dst, 0);
      Buffer.BlockCopy((Array) dst, 0, (Array) this.m_fileSystemInfo.encryptedKey, 0, dst.Length);
      Rsa2048PssSha256SignedSource sha256SignedSource = new Rsa2048PssSha256SignedSource((ISource) new AdaptedSource((ISource) new MemorySource(meta.CreateNcaHeader(this.m_fileSystemInfo), 512, (int) ((long) meta.GetHeaderSize() - 512L)), fsHeadersHashSource, 128L, fsHeadersHashSource.Size), this.m_header1Signer, this.m_header2Signer);
      this.m_headerSource = (ISource) new Aes128XtsEncryptedSource((ISource) new ConcatenatedSource(new List<ConcatenatedSource.Element>()
      {
        new ConcatenatedSource.Element(sha256SignedSource.GetSignatureValueSource(0), "headerSign1", 0L),
        new ConcatenatedSource.Element(sha256SignedSource.GetSignatureValueSource(1), "headerSign2", 256L),
        new ConcatenatedSource.Element((ISource) sha256SignedSource, "headerMain", 512L)
      }), this.m_headerEncryptor);
    }

    private ISource NrrSignedSource(ISource source)
    {
      List<Tuple<ISource, long, long>> adaptSourceInfos = new List<Tuple<ISource, long, long>>();
      using (Stream stream = (Stream) new SourceBasedStream(source))
      {
        RomFsFileSystemArchiveReader systemArchiveReader = new RomFsFileSystemArchiveReader(stream);
        foreach (Tuple<string, long> tuple in systemArchiveReader.ListFileInfo(".nrr/"))
        {
          string str = tuple.Item1;
          long size = tuple.Item2;
          if (Regex.IsMatch(str, "^(.nrr/).+(.nrr)$"))
          {
            byte[] numArray1 = systemArchiveReader.ReadFile(str, 0L, size);
            long num1 = size;
            long num2 = systemArchiveReader.GetFileFragmentList(str).Single<Tuple<long, long>>().Item1;
            if ((long) numArray1.Length != num1)
              throw new InvalidOperationException();
            Buffer.BlockCopy((Array) BitConverter.GetBytes(this.m_fileSystemInfo.programId), 0, (Array) numArray1, 816, 8);
            byte[] numArray2 = this.m_nrrSigner.SignBlock(numArray1, 816, (int) (num1 - 816L));
            if (numArray2.Length != 256)
              throw new ArgumentException("Invalid signature size. Confirm NrrSignKey.");
            Buffer.BlockCopy((Array) numArray2, 0, (Array) numArray1, 560, 256);
            byte[] keyModulus = this.m_nrrSigner.GetKeyModulus();
            if (keyModulus.Length != 256)
              throw new ArgumentException("Invalid key size. Confirm NrrSignKey.");
            Buffer.BlockCopy((Array) keyModulus, 0, (Array) numArray1, 48, 256);
            byte[] numArray3 = this.m_nrrCertificateSigner.SignBlock(numArray1, 16, 288);
            if (numArray3.Length != 256)
              throw new ArgumentException("Invalid signature size. Confirm NrrCertificateSignKey.");
            Buffer.BlockCopy((Array) numArray3, 0, (Array) numArray1, 304, 256);
            ISource source1 = (ISource) new MemorySource(numArray1, 0, numArray1.Length);
            adaptSourceInfos.Add(Tuple.Create<ISource, long, long>(source1, num2, num1));
          }
        }
      }
      if (adaptSourceInfos.Count > 0)
        return (ISource) new AdaptedSource(source, adaptSourceInfos);
      return source;
    }

    private ISource AcidResignedSource(ISource source)
    {
      long offset;
      long size;
      byte[] numArray1;
      using (Stream stream = (Stream) new SourceBasedStream(source))
      {
        PartitionFileSystemArchiveReader systemArchiveReader = new PartitionFileSystemArchiveReader(stream);
        List<Tuple<long, long>> fileFragmentList = systemArchiveReader.GetFileFragmentList("main.npdm");
        offset = fileFragmentList.Single<Tuple<long, long>>().Item1;
        size = fileFragmentList.Single<Tuple<long, long>>().Item2;
        numArray1 = systemArchiveReader.ReadFile("main.npdm", 0L, size);
        if ((long) numArray1.Length != size)
          throw new InvalidOperationException();
        byte[] keyModulus = this.m_header2Signer.GetKeyModulus();
        if (keyModulus.Length != 256)
          throw new ArgumentException("Invalid key size. Confirm NcaHeader2SignKey.");
        Buffer.BlockCopy((Array) keyModulus, 0, (Array) numArray1, 384, keyModulus.Length);
        int int32 = BitConverter.ToInt32(numArray1, 644);
        byte[] numArray2 = this.m_acidSigner.SignBlock(numArray1, 384, int32);
        if (numArray2.Length != 256)
          throw new ArgumentException("Invalid signature size. Confirm AcidSignKey.");
        Buffer.BlockCopy((Array) numArray2, 0, (Array) numArray1, 128, numArray2.Length);
      }
      MemorySource memorySource = new MemorySource(numArray1, 0, numArray1.Length);
      return (ISource) new AdaptedSource(source, (ISource) memorySource, offset, size);
    }

    private class BuildDataInfo
    {
      private int m_index;
      private ISource m_dataSource;
      private ISource m_headerSource;
      private long m_currentOffset;
      private NintendoContentFileSystemMeta m_meta;
      private List<ConcatenatedSource.Element> m_dataSourceElements;

      public int Index
      {
        get
        {
          return this.m_index;
        }
      }

      public ISource DataSource
      {
        get
        {
          return this.m_dataSource;
        }
      }

      public ISource HeaderSource
      {
        get
        {
          return this.m_headerSource;
        }
        set
        {
          this.m_headerSource = value;
        }
      }

      public long CurrentOffset
      {
        get
        {
          return this.m_currentOffset;
        }
        set
        {
          this.m_currentOffset = value;
        }
      }

      public NintendoContentFileSystemMeta Meta
      {
        get
        {
          return this.m_meta;
        }
      }

      public List<ConcatenatedSource.Element> DataSourceElements
      {
        get
        {
          return this.m_dataSourceElements;
        }
      }

      public BuildDataInfo(NintendoContentFileSystemMeta meta, ISource dataSource, long offset, int index)
      {
        this.m_index = index;
        this.m_dataSource = dataSource;
        this.m_meta = meta;
        this.m_currentOffset = offset;
        this.m_dataSourceElements = new List<ConcatenatedSource.Element>();
      }
    }

    private struct BodySourceElement
    {
      public ConcatenatedSource.Element HeaderElement;
      public long DataOffset;
      public List<ConcatenatedSource.Element> DataSourceElements;
    }

    private class BodyEncryptionKey
    {
      private const int KeyCount = 4;
      private const int KeyLength = 16;
      private byte[][] m_internalKey;

      public byte[] GetInternalKey(NintendoContentArchiveEncryptionKeyIndex index)
      {
        return this.m_internalKey[(int) index];
      }

      public BodyEncryptionKey(NintendoContentFileSystemInfo fileSystemInfo)
      {
        this.m_internalKey = new byte[4][];
        this.m_internalKey[2] = Encoding.ASCII.GetBytes("ContentKeyDEFGHI");
        if (fileSystemInfo.keyAreaEncryptionKeyIndex == (byte) 0 && !fileSystemInfo.isProdEncryption)
          return;
        new RNGCryptoServiceProvider().GetBytes(this.m_internalKey[2]);
      }

      public byte[] ToArray()
      {
        byte[] numArray = new byte[64];
        for (int index = 0; index < 4; ++index)
          Array.Copy(this.m_internalKey[index] != null ? (Array) this.m_internalKey[index] : (Array) new byte[16], 0, (Array) numArray, index * 16, 16);
        return numArray;
      }
    }
  }
}
