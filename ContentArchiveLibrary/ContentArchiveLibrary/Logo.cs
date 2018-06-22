// Decompiled with JetBrains decompiler
// Type: ContentArchiveLibrary.Logo
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ContentArchiveLibrary
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  public class Logo
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Logo()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static ResourceManager ResourceManager
    {
      get
      {
        if (Logo.resourceMan == null)
          Logo.resourceMan = new ResourceManager("ContentArchiveLibrary.Logo", typeof (Logo).Assembly);
        return Logo.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static CultureInfo Culture
    {
      get
      {
        return Logo.resourceCulture;
      }
      set
      {
        Logo.resourceCulture = value;
      }
    }

    public static byte[] NintendoLogo
    {
      get
      {
        return (byte[]) Logo.ResourceManager.GetObject(nameof (NintendoLogo), Logo.resourceCulture);
      }
    }

    public static byte[] StartupMovie
    {
      get
      {
        return (byte[]) Logo.ResourceManager.GetObject(nameof (StartupMovie), Logo.resourceCulture);
      }
    }
  }
}
