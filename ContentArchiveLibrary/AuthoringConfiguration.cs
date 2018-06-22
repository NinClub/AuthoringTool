// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.AuthoringConfiguration
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class AuthoringConfiguration
  {
    private KeyConfiguration m_KeyConfig = new KeyConfiguration();
    private string m_KeyConfigFilePath;

    public DebugConfiguration DebugConfig { get; set; }

    public string KeyConfigFilePath
    {
      set
      {
        this.m_KeyConfigFilePath = value;
        this.m_KeyConfig.SetKey(this.m_KeyConfigFilePath);
      }
      get
      {
        return this.m_KeyConfigFilePath;
      }
    }

    public KeyConfiguration GetKeyConfiguration()
    {
      return this.m_KeyConfig;
    }

    public AuthoringConfiguration()
    {
      this.DebugConfig = new DebugConfiguration();
    }
  }
}
