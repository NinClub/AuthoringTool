// Decompiled with JetBrains decompiler
// Type: msclr.interop.marshal_context
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace msclr.interop
{
  internal class marshal_context : IDisposable
  {
    internal readonly LinkedList<object> _clean_up_list = new LinkedList<object>();

    private void \u007Emarshal_context()
    {
      LinkedList<object>.Enumerator enumerator = this._clean_up_list.GetEnumerator();
      if (!enumerator.MoveNext())
        return;
      do
      {
        (enumerator.Current as IDisposable)?.Dispose();
      }
      while (enumerator.MoveNext());
    }

    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u007Emarshal_context();
      }
      else
      {
        // ISSUE: explicit finalizer call
        this.Finalize();
      }
    }

    public virtual void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }
  }
}
