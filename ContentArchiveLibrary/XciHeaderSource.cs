// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.XciHeaderSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using Nintendo.Authoring.FileSystemMetaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  internal class XciHeaderSource : ISource
  {
    private ISource m_rootPartitionFsHeaderHashSource;
    private XciInfo m_xciInfo;
    private XciMeta m_xciMeta;
    private ICbcModeEncryptor m_headerEncryptor;
    private ISigner m_headerSigner;

    public long Size { get; private set; }

    public XciHeaderSource(ref XciInfo xciInfo, XciMeta xciMeta, ISource rootPartitionFsHeaderHashSource, ICbcModeEncryptor headerEncryptor, ISigner headerSigner)
    {
      this.m_xciInfo = xciInfo;
      this.m_xciMeta = xciMeta;
      this.m_rootPartitionFsHeaderHashSource = rootPartitionFsHeaderHashSource;
      this.m_headerEncryptor = headerEncryptor;
      this.m_headerSigner = headerSigner;
      this.Size = (long) (XciInfo.PageSize * XciInfo.CardHeaderPageCount);
    }

    public ByteData PullData(long offset, int size)
    {
      ByteData byteData = this.m_rootPartitionFsHeaderHashSource.PullData(0L, 32);
      this.m_xciInfo.partitionFsHeaderHash = new byte[32];
      ArraySegment<byte> buffer = byteData.Buffer;
      byte[] array1 = buffer.Array;
      buffer = byteData.Buffer;
      int offset1 = buffer.Offset;
      byte[] partitionFsHeaderHash = this.m_xciInfo.partitionFsHeaderHash;
      int dstOffset = 0;
      buffer = byteData.Buffer;
      int count = buffer.Count;
      Buffer.BlockCopy((Array) array1, offset1, (Array) partitionFsHeaderHash, dstOffset, count);
      byte[] header = this.m_xciMeta.CreateHeader(this.m_xciInfo);
      this.m_headerEncryptor.EncryptBlock(this.m_xciInfo.iv, header, XciMeta.GetEncryptionTargetOffset(), XciMeta.GetEncryptionTargetSize(), header, XciMeta.GetEncryptionTargetOffset());
      byte[] array2 = ((IEnumerable<byte>) this.m_headerSigner.SignBlock(header, 0, header.Length)).Concat<byte>((IEnumerable<byte>) header).ToArray<byte>();
      return new ByteData(new ArraySegment<byte>(array2, 0, array2.Length));
    }

    public SourceStatus QueryStatus()
    {
      RangeList availableRangeList = this.m_rootPartitionFsHeaderHashSource.QueryStatus().AvailableRangeList;
      if (availableRangeList.Count == 0 || availableRangeList[0].Size != this.m_rootPartitionFsHeaderHashSource.Size)
        return new SourceStatus();
      SourceStatus sourceStatus = new SourceStatus();
      sourceStatus.AvailableRangeList.MergingAdd(new Range(0L, this.Size));
      return sourceStatus;
    }
  }
}
