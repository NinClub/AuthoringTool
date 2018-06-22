// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.TicketSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class TicketSource : ISource
  {
    private ISource TicketBufferSource;

    public TicketSource(byte[] ticket, int ticketLength)
    {
      this.TicketBufferSource = (ISource) new MemorySource(ticket, 0, ticketLength);
    }

    public long Size
    {
      get
      {
        return this.TicketBufferSource.Size;
      }
    }

    public ByteData PullData(long offset, int size)
    {
      return this.TicketBufferSource.PullData(offset, size);
    }

    public SourceStatus QueryStatus()
    {
      return this.TicketBufferSource.QueryStatus();
    }
  }
}
