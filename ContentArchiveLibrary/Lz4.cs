// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.Lz4
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Runtime.InteropServices;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public static class Lz4
  {
    public static int LZ4_compress_default(byte[] source, byte[] dest, int sourceSize, int maxDestSize)
    {
      using (new Lz4.ScopedGCHandle((object) source, GCHandleType.Pinned))
      {
        using (new Lz4.ScopedGCHandle((object) dest, GCHandleType.Pinned))
          return Lz4.LZ4_compress_default(Marshal.UnsafeAddrOfPinnedArrayElement<byte>(source, 0), Marshal.UnsafeAddrOfPinnedArrayElement<byte>(dest, 0), sourceSize, maxDestSize);
      }
    }

    public static int LZ4_decompress_safe(byte[] source, int sourceOffset, byte[] dest, int destOffset, int compressedSize, int maxDecompressedSize)
    {
      using (new Lz4.ScopedGCHandle((object) source, GCHandleType.Pinned))
      {
        using (new Lz4.ScopedGCHandle((object) dest, GCHandleType.Pinned))
          return Lz4.LZ4_decompress_safe(Marshal.UnsafeAddrOfPinnedArrayElement<byte>(source, sourceOffset), Marshal.UnsafeAddrOfPinnedArrayElement<byte>(dest, destOffset), compressedSize, maxDecompressedSize);
      }
    }

    [DllImport("Lz4Library.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int LZ4_compress_default(IntPtr source, IntPtr dest, int sourceSize, int maxDestSize);

    [DllImport("Lz4Library.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int LZ4_decompress_safe(IntPtr source, IntPtr dest, int compressedSize, int maxDecompressedSize);

    [DllImport("Lz4Library.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LZ4_compressBound(int inputSize);

    private class ScopedGCHandle : IDisposable
    {
      private bool disposed;
      private GCHandle gchandle;

      public ScopedGCHandle(object value)
      {
        this.gchandle = GCHandle.Alloc(value);
      }

      public ScopedGCHandle(object value, GCHandleType type)
      {
        this.gchandle = GCHandle.Alloc(value, type);
      }

      ~ScopedGCHandle()
      {
        this.Dispose(false);
      }

      public static implicit operator IntPtr(Lz4.ScopedGCHandle scopedGCHandle)
      {
        return (IntPtr) scopedGCHandle;
      }

      public void Dispose()
      {
        this.Dispose(true);
        GC.SuppressFinalize((object) this);
      }

      protected virtual void Dispose(bool disposing)
      {
        if (this.disposed)
          return;
        int num = disposing ? 1 : 0;
        this.gchandle.Free();
        this.disposed = true;
      }
    }
  }
}
