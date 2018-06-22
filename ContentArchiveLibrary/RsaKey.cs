// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.RsaKey
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class RsaKey
  {
    public byte[] KeyPublicExponent;
    public byte[] KeyPrivateExponent;

    public byte[] KeyModulus { get; private set; }

    public RsaKey(byte[] keyModulus, byte[] keyPublicExponent, byte[] keyPrivateExponent)
    {
      this.KeyModulus = keyModulus;
      this.KeyPublicExponent = keyPublicExponent;
      this.KeyPrivateExponent = keyPrivateExponent;
    }
  }
}
