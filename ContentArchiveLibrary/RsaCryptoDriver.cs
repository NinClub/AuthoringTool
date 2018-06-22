// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.RsaCryptoDriver
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Security.Cryptography;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class RsaCryptoDriver
  {
    private int m_keySize = 256;
    public const string SignKeyData = "<RSAKeyValue><Modulus>2PEY7zJyTKdHTLnqswSopKyZCAgEv2hXuEOUK8e5ZkmF5YqbwQCaao3Q787/hshcXelTexkqqMAi0fMiClDyK2UFG57sYbVjo287umM6U/RJL88DzNdQghspTwjeG21HT6i2aiaggz8ar4OPDhc//kQcVpQuSYODA+m2rdXe4y2h2WYgXR9ell1bVQ3UtHdurhtp86ZhDlFiOShjdXa/sNIi75glAgXA12oGLKXYWp16pCFVn/k+vxb2B8K5boeetRy+l/qCfu0w1GY/3tgbSxXZ+y9Q8J0dUkwcTY2uhR7qf4bzC3uHgZgjgGNPL7BizG7SRhNlK9ZEM1m1j7lKqQ==</Modulus><Exponent>AQAB</Exponent><P>+1qkiEeaaQrYKZSqLU9feBdMhTfMeYS1etzGJWrDzqcrYs3866GXPe+Ww3b+PzFNPJtV4twK80O6tiEN3XiYaiW4Km0hCZgadRDs/MHXmWddb5PukWFK8cmWQWhpr4N6ZbhGm+x01yD7uRLmS2O/ysXDG/hzr3fv9rBk7KjJqkE=</P><Q>3POfZG3zjJA456A2FSGrr24qHQ5NVppBH5sP4WeSEk3sxWUxOMSnrUWnQurlvAB9ZkO7+D5HtlhN3FN+RU0V5JBJXDtlDF4tWWUiqyGRytW6whjXU9d9gwijHUJrcsaNvYsFsXGq4IA6yATGRx+nt0OK7Hd0qZUKqLsm0yFo9mk=</Q><DP>NL8z0el8zNhavncVM0b52ODCzR4FiebAktTrvARorOBF6Ykir2wMqhGySLia6DX3aGWMo3vbzGsFLp1HJJffHD9oI3cdPL8vpit0ICKplOatI/IeWWHacV0FbBp2Oz/TGq+OGcCIUHD6gj8mFuIK6ImRxTfhRwxbTiB8PXG6SEE=</DP><DQ>2rMV8Q1YBaj3emU9QvtZ+cIcUzhF2tPCZCtSs7SVhCK3msdHyj31DnAkV/szvDvr455l3xieWOHc55mJIcVkRyF+S5nKskxBrPuLLkKDEXcubVKzSBzC8kFJWvvUaP4ZbCTAVNwC3EZwaG05aUru8lobl2XCBt0seMkOa+rk/wk=</DQ><InverseQ>nBKXk63Q6Ul4dFmUNzQsOIajcGVWw/sy+IiF2MWZ3Irs4s0GMjvhIOSXjRVJveYV47BGuqpubW+75YXsb/M/4rFnReLBZH0nj1tvEvvlnCMU8Lp4fJlkKgPbGPQWm0SUxUo2s3Nqmoi0+QLokoj9zdYksKeuSwE9xljdkVGBsEU=</InverseQ><D>DAW1bekP5kFVbVI2yFezYFfbzbMDD1fxF4owM4pokvtzVwSKy+P0ir/j8qw4IzAmlUI9UPq0r2AhddzZV7TDbOX25eBVZXdLx6Z+Cv7dgEJPDX4VjfQnNySZ8hIx29d/HpIhFMoh9lAIkq4x3vQpJNZBs0cYNxT5jV2V9PV/mfuG2mXpcql3ZcjFKVoZK1EccutJ0Qtziz4uyH7/2P709PaSJ3+g28ElvOxfCy2Z692eXUJ1teMky+nr2QBLEl2jpiWsIIIlUx/GLyfxmXqZ3KXAXmMPeAMqGNnhBjvfspUZMrRl0tD+GMdUXKT22P3bbdja8ppVXD7sF3IJoxoKwQ==</D></RSAKeyValue>";
    public const string EncryptionKeyData = "<RSAKeyValue><Modulus>hfiMQYotlrPzktBsnZCWfxp42Bd6uOwObhBVyMp/GMcYlHUNuhlE3vqTyMtfypsJPC4tErL6C7fA/NQFxCvHn2qstYCgTnLLjV6FY7+ZFokH/joJvN9c85ApM/9ytRjQCOvDmMJMO/bPzLJx3Y7uE4iCeWfBbD1gnH0dQ1LxSLtdyzmqk451dr43R5yrLyK/ynXDUJnUmHLCYlijudPXz+pAAkJJybr+g4dA94dqTVq3bww812yLAGhlMilwaCaRFARYKugBaEGJWIejHeS5v4ucR4imeVoXxOOrBagxHtFVoqIEhfGWgSMERFfMk2YNwZ40RikSzXQZzR/UJjGrxQ==</Modulus><Exponent>AQAB</Exponent><P>uQzSCjV2QouNLHz5L5ROaBqQvErje/q6cprnSHscxZWRAFRQJFotPvdAbvFRXI3HNNROxLH2Xj7v3XOtBF2OqAqgpzn+OQsvxkftXKipWJYM27nsLF84tN9mWxZk04LyBqIv3hCXonWRbF8rqH7Nz75DyBanSYoxmWwAnzyTx5E=</P><Q>uVYpuiLOb6Hn6svMEVArXIVfInkV7i6e7muXmK+lQ1c0spPqDiSjXecizjD1TFjH5F+DyRWS2qekPNgZgPbi8o3xkMimXsR8DdtB/VvXrs+BEg3fhztTa12iO0TEKRMSaOpUNLQHnjZjB5n3X5PWcaK1KNe2/uwV5jwjtFrdzvU=</Q><DP>entj4uHz/qPDs3icrsNpCjrbJeYjoAIaupSRFUZ3isgui5tC2GzfmdepzETp52roOa103Xg1a7gYp+lS0ZrjO5KdN1KJVFR1MLaXA0eXn0ziAeWTzuLP89gSNaQi5GS9sWpUaJVu6FcNBEAR85rKuwBieOOVonVX0wbLeppr7iE=</DP><DQ>NfL74H/jQaGKhdFfDKceiCcWo01F8fhGMTbGgR6X57tJzrW5yvYlS99NRWIA9YFeZn7bOLx77AQijceF3QGA3IQvDisqKqndRpdNZTfH1831T1EUgSPmy3kNEV2aEC7KDBox+slw8j/4oazS0lKReLCZNVNdpGUKluNorUZKDMU=</DQ><InverseQ>QUnrEd/1qRuU8lHkwk+p3uN2142lj72WfPz2PGvG3Kfacn7Sjaqt1xje+xyWrA4gfX7/zXl2Xr09xKubyHRNJ0YhrILoI4ClhIlMwRtFIhLSCs47oz157+f1YslI6IiH/R7abZdHIjkH+H+KqSTSSKfdqdI5pvQit7TG9rZM32s=</InverseQ><D>G8luhdV8GSrf1U6niJLJtDkwYVmVWa+UWp3GvSvK6r+4yGny2+uLzlfYuSf9iU9YvgOx05QNqsqFG6t6OrL954G/qrGwDjVfJMY7EnJV9Uecwc0V4ffOFrKK6T8NcqRf2cnUuuVp3HIXrZRBa7vOg3yn2zh69NFSLYMBw8n7Q6NUQT29eASXnaauHTRe1ndwCOTWf5hyGvL/r4ZeBUCjUZduML0G38H3WMI8jUmuE30eJ5iSR9BVYggXNOvFaEP7b6U/KDq7Nyut9w+Fsd9syZ+FRvdQxIeh1KrLAYX6xnkBLAsv7nH+XYYX5ZFfRHltw4njit0D1Mrqecs0YedTQQ==</D></RSAKeyValue>";
    private RSACryptoServiceProvider m_rsaServiceProvider;

    public RsaCryptoDriver.CryptoMode Mode { get; private set; }

    public int KeySize
    {
      get
      {
        return this.m_keySize;
      }
    }

    public RsaCryptoDriver(RsaCryptoDriver.CryptoMode mode, string keyDataXml)
    {
      this.Mode = mode;
      if (this.Mode != RsaCryptoDriver.CryptoMode.RSA2048)
        throw new ArgumentException();
      this.m_keySize = 256;
      this.m_rsaServiceProvider = new RSACryptoServiceProvider(this.m_keySize * 8);
      this.m_rsaServiceProvider.FromXmlString(keyDataXml);
      this.m_rsaServiceProvider.ToXmlString(true);
    }

    public byte[] EncryptBlock(byte[] src, int srcOffset, int srcSize)
    {
      byte[] rgb = new byte[srcSize];
      Buffer.BlockCopy((Array) src, srcOffset, (Array) rgb, 0, srcSize);
      return this.m_rsaServiceProvider.Encrypt(rgb, false);
    }

    public byte[] DecryptBlock(byte[] src, int srcOffset, int srcSize)
    {
      byte[] rgb = new byte[srcSize];
      Buffer.BlockCopy((Array) src, srcOffset, (Array) rgb, 0, srcSize);
      return this.m_rsaServiceProvider.Decrypt(rgb, false);
    }

    public byte[] SignBlock(byte[] src, int srcOffset, int srcSize)
    {
      return this.m_rsaServiceProvider.SignData(src, srcOffset, srcSize, (object) new SHA256CryptoServiceProvider());
    }

    public bool VerifyBlock(byte[] dataToVerified, byte[] signature)
    {
      return this.m_rsaServiceProvider.VerifyData(dataToVerified, (object) new SHA256CryptoServiceProvider(), signature);
    }

    public enum CryptoMode
    {
      RSA2048,
    }
  }
}
