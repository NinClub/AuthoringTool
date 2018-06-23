// Decompiled with JetBrains decompiler
// Type: <CrtImplementationDetails>.Exception
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.Serialization;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class Exception : System.Exception
  {
    protected Exception(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public Exception(string message, System.Exception innerException)
      : base(message, innerException)
    {
    }

    public Exception(string message)
      : base(message)
    {
    }
  }
}
