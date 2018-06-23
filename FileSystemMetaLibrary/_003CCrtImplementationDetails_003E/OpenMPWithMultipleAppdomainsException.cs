// Decompiled with JetBrains decompiler
// Type: <CrtImplementationDetails>.OpenMPWithMultipleAppdomainsException
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Runtime.Serialization;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class OpenMPWithMultipleAppdomainsException : System.Exception
  {
    protected OpenMPWithMultipleAppdomainsException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public OpenMPWithMultipleAppdomainsException()
    {
    }
  }
}
