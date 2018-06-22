// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Ticket
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using Nintendo.Authoring.CryptoLibrary;
using Nintendo.Authoring.ETicketLibrary;
using System.Text;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Ticket
  {
    private const int MaxTicketLength = 1024;
    private int m_TicketDataLength;
    private byte[] m_TicketData;

    public Ticket()
    {
      this.m_TicketData = new byte[1024];
    }

    public int Length
    {
      get
      {
        return this.m_TicketDataLength;
      }
    }

    public byte[] Data
    {
      get
      {
        return this.m_TicketData;
      }
    }

    public byte[] PublishTicket(ulong titleId, bool isProdEncryption, KeyConfiguration keyConfiguration)
    {
      AesKey externalContentKey = ExternalContentKeyGenerator.GetNcaExternalContentKey(!isProdEncryption ? (IHashCalculator) new HmacSha256HashCryptoDriver(HmacSha256KeyIndex.TitleKeyGenarateKey) : (keyConfiguration.GetProdTitleKeyGenarateKey() == null ? (IHashCalculator) new HsmHmacSha256HashCryptoDriver(HmacSha256KeyIndex.TitleKeyGenarateKey) : (IHashCalculator) new HmacSha256HashCryptoDriver(keyConfiguration.GetProdTitleKeyGenarateKey().Key)), titleId);
      Ticket.EncryptTitleKey(!isProdEncryption ? (ICbcModeEncryptor) new Aes128CbcCryptoDriver(Aes128KeyIndex.ETicketCommonKey) : (keyConfiguration.GetProdETicketCommonKey() == null ? (ICbcModeEncryptor) new HsmAes128CbcCryptoDriver(Aes128KeyIndex.ETicketCommonKey) : (ICbcModeEncryptor) new Aes128CbcCryptoDriver(keyConfiguration.GetProdETicketCommonKey().Key)), titleId, externalContentKey);
      ulong deviceId = 0;
      ulong ticketId = 0;
      byte[] rightsId = TicketUtility.CreateRightsId(titleId);
      this.m_TicketDataLength = !isProdEncryption ? (int) TicketPublication.PublishTicket(this.m_TicketData, (uint) this.m_TicketData.Length, externalContentKey.Key, deviceId, ticketId, rightsId, Encoding.ASCII.GetBytes("Root-CA00000004-XS00000020")) : (keyConfiguration.GetProdETicketSignKey() == null ? (int) TicketPublication.PublishTicket(this.m_TicketData, (uint) this.m_TicketData.Length, externalContentKey.Key, deviceId, ticketId, rightsId, Encoding.ASCII.GetBytes("Root-CA00000004-XS00000021")) : (int) TicketPublication.PublishTicket(this.m_TicketData, (uint) this.m_TicketData.Length, externalContentKey.Key, deviceId, ticketId, rightsId, Encoding.ASCII.GetBytes("Root-CA00000004-XS00000020")));
      if (isProdEncryption)
      {
        if (keyConfiguration.GetProdETicketSignKey() != null)
        {
          RsaKey prodEticketSignKey = keyConfiguration.GetProdETicketSignKey();
          this.SignTicket((ISigner) new Rsa2048Pkcs1Sha256SignCryptoDriver(prodEticketSignKey.KeyModulus, prodEticketSignKey.KeyPublicExponent, prodEticketSignKey.KeyPrivateExponent));
        }
        else
          this.SignTicket((ISigner) new HsmRsa2048Pkcs1Sha256SignCryptoDriver(Rsa2048Pkcs1Sha256KeyIndex.ETicket));
      }
      else
      {
        byte[] numArray1 = new byte[Sign.GetModulusSize()];
        Sign.GetModulus_XS00000020(numArray1);
        byte[] numArray2 = new byte[Sign.GetPrivateExponentSize()];
        Sign.GetPrivateExponent_XS00000020(numArray2);
        this.SignTicket((ISigner) new Rsa2048Pkcs1Sha256SignCryptoDriver(numArray1, (byte[]) null, numArray2));
      }
      return this.m_TicketData;
    }

    private void SignTicket(ISigner signer)
    {
      byte[] numArray = new byte[1024];
      int ticketDataForSign = TicketPublication.GetTicketDataForSign(numArray, 1024U, this.m_TicketData, (uint) this.m_TicketDataLength);
      byte[] signatureBuffer = signer.SignBlock(numArray, 0, ticketDataForSign);
      TicketPublication.SignTicket(this.m_TicketData, (uint) this.m_TicketDataLength, signatureBuffer, signatureBuffer.Length);
    }

    public static AesKey EncryptTitleKey(ICbcModeEncryptor encryptor, ulong titleId, AesKey key)
    {
      byte[] numArray = new byte[key.Key.Length];
      byte[] rightsId = TicketUtility.CreateRightsId(titleId);
      encryptor.EncryptBlock(rightsId, key.Key, 0, key.Key.Length, numArray, 0);
      return new AesKey(numArray);
    }
  }
}
