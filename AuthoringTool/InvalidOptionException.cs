﻿// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringTool.InvalidOptionException
// Assembly: AuthoringTool, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: BE36B8E3-2CFD-4108-9B3B-250D388E8138
// Assembly location: E:\AuthoringTool\AuthoringTool.exe

using System;

namespace Nintendo.Authoring.AuthoringTool
{
  public class InvalidOptionException : Exception
  {
    public InvalidOptionException()
    {
    }

    public InvalidOptionException(string message)
      : base(message)
    {
    }

    public InvalidOptionException(Exception innerException)
      : base(innerException.Message, innerException)
    {
    }
  }
}
