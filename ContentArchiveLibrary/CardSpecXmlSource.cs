// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.CardSpecXmlSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.FileSystemMetaLibrary;
using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class CardSpecXmlSource : ISource
  {
    private ISource m_source;

    public long Size { get; set; }

    public CardSpecXmlSource(NintendoSubmissionPackageFileSystemInfo nspInfo, KeyConfiguration config)
    {
      NintendoSubmissionPackageFileSystemInfo uppInfo = nspInfo;
      XciSizeInfo xciSize = ProdEncryptedXciArchive.CalculateXciSize(nspInfo, uppInfo, (NintendoSubmissionPackageFileSystemInfo) null, config);
      int romSize = XciUtils.GetRomSize(xciSize.TotalSize);
      if (romSize == XciInfo.InvalidRomSize)
        Log.Warning("This nsp can't be published as a game card title because its size exceed the maximum size of the game card.");
      if (nspInfo.CardSize == 0 || nspInfo.CardClockRate == 0)
      {
        if (romSize == XciInfo.InvalidRomSize)
        {
          nspInfo.CardSize = XciInfo.InvalidRomSize;
          nspInfo.CardClockRate = XciInfo.InvalidClockRate;
        }
        else
        {
          nspInfo.CardSize = romSize;
          nspInfo.CardClockRate = XciUtils.GetClockRate(nspInfo.CardSize);
        }
      }
      else if (romSize != XciInfo.InvalidRomSize && nspInfo.CardSize < romSize)
        throw new ArgumentException(string.Format("This nsp requires CardSpec/Size = {0}, though it is set as {1}.", (object) romSize, (object) nspInfo.CardSize));
      if (romSize != XciInfo.InvalidRomSize)
        Log.Info(string.Format("CardSize: {0} (GB), UserArea Used: {1}/{2} (bytes)", (object) romSize, (object) (xciSize.TotalSize - (XciInfo.UpdatePartitionLimitSize + 65536L)), (object) (XciUtils.GetAvailableAreaSize(romSize) - (XciInfo.UpdatePartitionLimitSize + 65536L))));
      byte[] bytes = new CardSpecXml(nspInfo.CardSize, nspInfo.CardClockRate).GetBytes();
      this.m_source = (ISource) new MemorySource(bytes, 0, bytes.Length);
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
  }
}
