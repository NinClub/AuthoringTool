// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.TicketCertificateSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.ETicketLibrary;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class TicketCertificateSource : ISource
  {
    private ISource CertificateBufferSource;

    public TicketCertificateSource(bool isProdEncryption, KeyConfiguration keyConfiguration)
    {
      int certificateSize = Certificate.GetCertificateSize();
      byte[] buffer = new byte[certificateSize];
      if (isProdEncryption)
      {
        if (keyConfiguration.GetProdETicketSignKey() != null)
          Certificate.GetCertificate_XS00000020(buffer);
        else
          Certificate.GetCertificate_XS00000021(buffer);
      }
      else
        Certificate.GetCertificate_XS00000020(buffer);
      this.CertificateBufferSource = (ISource) new MemorySource(buffer, 0, certificateSize);
    }

    public long Size
    {
      get
      {
        return this.CertificateBufferSource.Size;
      }
    }

    public ByteData PullData(long offset, int size)
    {
      return this.CertificateBufferSource.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.CertificateBufferSource.QueryStatus();
    }
  }
}
