// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Log
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class Log
  {
    private static bool g_isEnabled;

    public static void Enable()
    {
      Log.g_isEnabled = true;
    }

    public static void Warning(string str)
    {
      Console.WriteLine("[Warning] " + str);
    }

    public static void Info(string str)
    {
      if (!Log.g_isEnabled)
        return;
      Console.WriteLine("[Info] " + str);
    }
  }
}
