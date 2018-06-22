// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.TicketUtility
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class TicketUtility
  {
    public static byte[] CreateRightsId(ulong applicationId)
    {
      long num = 0;
      byte[] array1 = ((IEnumerable<byte>) BitConverter.GetBytes(applicationId)).Reverse<byte>().ToArray<byte>();
      byte[] array2 = ((IEnumerable<byte>) BitConverter.GetBytes((ulong) num)).Reverse<byte>().ToArray<byte>();
      byte[] numArray = new byte[16];
      Array.Copy((Array) array1, (Array) numArray, array1.Length);
      Array.Copy((Array) array2, 0, (Array) numArray, array1.Length, array2.Length);
      return numArray;
    }

    public static string CreateRightsIdText(ulong applicationId)
    {
      byte[] rightsId = TicketUtility.CreateRightsId(applicationId);
      string str = "";
      foreach (byte num in rightsId)
        str += num.ToString("x2");
      return str;
    }

    public static bool NeedCreateTicket(string metaType)
    {
      if (!(metaType == "Application") && !(metaType == "Patch"))
        return metaType == "AddOnContent";
      return true;
    }
  }
}
