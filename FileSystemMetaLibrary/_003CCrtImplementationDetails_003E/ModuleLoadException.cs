// Decompiled with JetBrains decompiler
// Type: <CrtImplementationDetails>.ModuleLoadException
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.Serialization;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class ModuleLoadException : System.Exception
  {
    public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";

    protected ModuleLoadException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public ModuleLoadException(string message, System.Exception innerException)
      : base(message, innerException)
    {
    }

    public ModuleLoadException(string message)
      : base(message)
    {
    }
  }
}
