// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.KeyConfiguration
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class KeyConfiguration
  {
    private List<Tuple<int, AesKey>> m_KeyAreaEncryptionKeyList;
    private RsaKey m_NcaHeader1SignKey;
    private RsaKey m_AcidSignKey;
    private RsaKey m_NrrCertificateSignKey;
    private AesKey m_ProdKeyAreaEncryptionKey;
    private AesKey m_ProdNcaHeaderEncryptionKek;
    private RsaKey m_ProdXciHeaderSignKey;
    private AesKey m_ProdXciInitialDataEncryptionKey;
    private AesKey m_ProdTitleKeyGenarateKey;
    private AesKey m_ProdETicketCommonKey;
    private RsaKey m_ProdETicketSignKey;

    public KeyConfiguration()
    {
      this.m_KeyAreaEncryptionKeyList = new List<Tuple<int, AesKey>>();
      this.m_KeyAreaEncryptionKeyList.Add(Tuple.Create<int, AesKey>(0, new AesKey(new byte[16]
      {
        (byte) 58,
        (byte) 124,
        (byte) 62,
        (byte) 56,
        (byte) 74,
        (byte) 143,
        (byte) 34,
        byte.MaxValue,
        (byte) 75,
        (byte) 33,
        (byte) 87,
        (byte) 25,
        (byte) 183,
        (byte) 129,
        (byte) 173,
        (byte) 12
      })));
      this.m_NcaHeader1SignKey = (RsaKey) null;
      this.m_AcidSignKey = (RsaKey) null;
      this.m_ProdKeyAreaEncryptionKey = (AesKey) null;
      this.m_ProdNcaHeaderEncryptionKek = (AesKey) null;
      this.m_NrrCertificateSignKey = (RsaKey) null;
    }

    private static Tuple<AesKey, AesKey> LoadAesXtsKeyConfig(XElement xml, string keyName)
    {
      XElement xelement;
      try
      {
        xelement = xml.Elements((XName) keyName).Single<XElement>();
      }
      catch (InvalidOperationException ex)
      {
        return (Tuple<AesKey, AesKey>) null;
      }
      return Tuple.Create<AesKey, AesKey>(new AesKey(Convert.FromBase64String(xelement.Elements((XName) "Key1").Single<XElement>().Value)), new AesKey(Convert.FromBase64String(xelement.Elements((XName) "Key2").Single<XElement>().Value)));
    }

    private static AesKey LoadAesKeyConfig(XElement xml, string keyName)
    {
      XElement xelement;
      try
      {
        xelement = xml.Elements((XName) keyName).Single<XElement>();
      }
      catch (InvalidOperationException ex)
      {
        return (AesKey) null;
      }
      return new AesKey(Convert.FromBase64String(xelement.Elements((XName) "Key").Single<XElement>().Value));
    }

    private static RsaKey LoadRsaKeyConfig(XElement xml, string keyName)
    {
      XElement xelement;
      try
      {
        xelement = xml.Elements((XName) keyName).Single<XElement>();
      }
      catch (InvalidOperationException ex)
      {
        return (RsaKey) null;
      }
      return new RsaKey(Convert.FromBase64String(xelement.Elements((XName) "Modulus").Single<XElement>().Value), Convert.FromBase64String(xelement.Elements((XName) "PublicExponent").Single<XElement>().Value), Convert.FromBase64String(xelement.Elements((XName) "PrivateExponent").Single<XElement>().Value));
    }

    public void SetKey(string keyConfigFilePath)
    {
      XElement xml = XElement.Load(keyConfigFilePath);
      try
      {
        foreach (XElement element in xml.Elements((XName) "KeyAreaEncryptionKeys").Elements<XElement>((XName) "Key"))
          this.m_KeyAreaEncryptionKeyList.Add(Tuple.Create<int, AesKey>(Convert.ToInt32(element.Attribute((XName) "index").Value), new AesKey(Convert.FromBase64String(element.Value))));
        this.m_ProdKeyAreaEncryptionKey = KeyConfiguration.LoadAesKeyConfig(xml, "ProdKeyAreaEncryptionKey");
        this.m_ProdNcaHeaderEncryptionKek = KeyConfiguration.LoadAesKeyConfig(xml, "ProdNcaHeaderEncryptionKek");
        this.m_NcaHeader1SignKey = KeyConfiguration.LoadRsaKeyConfig(xml, "NcaHeader1SignKey");
        this.m_AcidSignKey = KeyConfiguration.LoadRsaKeyConfig(xml, "NcaAcidSignKey");
        this.m_NrrCertificateSignKey = KeyConfiguration.LoadRsaKeyConfig(xml, "NcaNrrCertificateSignKey");
        this.m_ProdXciHeaderSignKey = KeyConfiguration.LoadRsaKeyConfig(xml, "ProdXciHeaderSignKey");
        this.m_ProdXciInitialDataEncryptionKey = KeyConfiguration.LoadAesKeyConfig(xml, "ProdXciInitialDataEncryptionKey");
        this.m_ProdTitleKeyGenarateKey = KeyConfiguration.LoadAesKeyConfig(xml, "ProdTitleKeyGenarateKey");
        this.m_ProdETicketCommonKey = KeyConfiguration.LoadAesKeyConfig(xml, "ProdETicketCommonKey");
        this.m_ProdETicketSignKey = KeyConfiguration.LoadRsaKeyConfig(xml, "ProdETicketSignKey");
      }
      catch
      {
        throw new ArgumentException(string.Format("Failed to load key configuration from {0}.", (object) keyConfigFilePath));
      }
    }

    public byte[][] GetKeyAreaEncryptionKeys()
    {
      int length = 2;
      byte[][] numArray = new byte[length][];
      for (uint index = 0; (long) index < (long) length; ++index)
      {
        try
        {
          byte[] key = this.GetKeyAreaEncryptionKey(index + 1U).Key;
          numArray[(int) index] = key;
        }
        catch
        {
          numArray[(int) index] = (byte[]) null;
        }
      }
      return numArray;
    }

    public AesKey GetKeyAreaEncryptionKey(uint keyIndex)
    {
      foreach (Tuple<int, AesKey> areaEncryptionKey in this.m_KeyAreaEncryptionKeyList)
      {
        if ((long) areaEncryptionKey.Item1 == (long) keyIndex)
          return areaEncryptionKey.Item2;
      }
      throw new ArgumentException(string.Format("A key config file is required for key index {0}. Use --keyconfig option.", (object) keyIndex));
    }

    public AesKey GetProdKeyAreaEncryptionKey()
    {
      return this.m_ProdKeyAreaEncryptionKey;
    }

    public RsaKey GetNcaHeader1SignKey()
    {
      return this.m_NcaHeader1SignKey;
    }

    public RsaKey GetAcidSignKey()
    {
      return this.m_AcidSignKey;
    }

    public AesKey GetProdNcaHeaderEncryptionKek()
    {
      return this.m_ProdNcaHeaderEncryptionKek;
    }

    public RsaKey GetNrrCertificateSignKey()
    {
      return this.m_NrrCertificateSignKey;
    }

    public RsaKey GetProdXciHeaderSignKey()
    {
      return this.m_ProdXciHeaderSignKey;
    }

    public AesKey GetProdXciInitialDataEncryptionKey()
    {
      return this.m_ProdXciInitialDataEncryptionKey;
    }

    public AesKey GetProdTitleKeyGenarateKey()
    {
      return this.m_ProdTitleKeyGenarateKey;
    }

    public AesKey GetProdETicketCommonKey()
    {
      return this.m_ProdETicketCommonKey;
    }

    public RsaKey GetProdETicketSignKey()
    {
      return this.m_ProdETicketSignKey;
    }

    public AesKey GetRandomAesKey()
    {
      RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider();
      byte[] key = new byte[16];
      byte[] data = key;
      cryptoServiceProvider.GetBytes(data);
      return new AesKey(key);
    }

    public RsaKey GetRandomRsaKey()
    {
      RSAParameters rsaParameters = new RSACryptoServiceProvider(2048).ExportParameters(true);
      return new RsaKey(rsaParameters.Modulus, rsaParameters.Exponent, rsaParameters.D);
    }
  }
}
