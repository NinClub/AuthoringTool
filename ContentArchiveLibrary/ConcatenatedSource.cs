// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ConcatenatedSource
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class ConcatenatedSource : ISource
  {
    private ConcatenatedSource.Element GetElement(long offset)
    {
      long num = 0;
      foreach (ConcatenatedSource.Element element in this.Elements)
      {
        num += element.Source.Size;
        if (num > offset)
          return element;
      }
      return this.Elements.Last<ConcatenatedSource.Element>();
    }

    public long Size { get; private set; }

    public List<ConcatenatedSource.Element> Elements { get; private set; }

    public ConcatenatedSource(List<ConcatenatedSource.Element> elements)
    {
      this.Elements = new List<ConcatenatedSource.Element>();
      foreach (ConcatenatedSource.Element element in elements)
        this.Elements.Add(element);
      this.Elements.Sort((IComparer<ConcatenatedSource.Element>) new ConcatenatedSource.ElementOffsetComparer());
      for (int index = 0; index < this.Elements.Count - 1; ++index)
      {
        long size = this.Elements[index + 1].Offset - (this.Elements[index].Offset + this.Elements[index].Source.Size);
        if (size < 0L)
          throw new ArgumentException("entries layout overlaps. please check .adf file.");
        if (size > 0L)
        {
          ConcatenatedSource.Element element = new ConcatenatedSource.Element((ISource) new PaddingSource(size), string.Empty, this.Elements[index].Offset + this.Elements[index].Source.Size);
          this.Elements.Insert(index + 1, element);
        }
      }
      this.Size = this.Elements.Last<ConcatenatedSource.Element>().Offset + this.Elements.Last<ConcatenatedSource.Element>().Source.Size;
    }

    public ByteData PullData(long offset, int size)
    {
      int count1 = 0;
      byte[] array1 = new byte[size];
      long offset1 = offset;
      while (count1 != size)
      {
        ConcatenatedSource.Element element = this.GetElement(offset1);
        ByteData byteData = element.Source.PullData(offset1 - element.Offset, size - count1);
        ArraySegment<byte> buffer = byteData.Buffer;
        if (buffer.Count != 0)
        {
          buffer = byteData.Buffer;
          byte[] array2 = buffer.Array;
          buffer = byteData.Buffer;
          int offset2 = buffer.Offset;
          byte[] numArray = array1;
          int dstOffset = count1;
          buffer = byteData.Buffer;
          int count2 = buffer.Count;
          Buffer.BlockCopy((Array) array2, offset2, (Array) numArray, dstOffset, count2);
          int num1 = count1;
          buffer = byteData.Buffer;
          int count3 = buffer.Count;
          count1 = num1 + count3;
          long num2 = offset1;
          buffer = byteData.Buffer;
          long count4 = (long) buffer.Count;
          offset1 = num2 + count4;
        }
        else
          break;
      }
      return new ByteData(new ArraySegment<byte>(array1, 0, count1));
    }

    public SourceStatus QueryStatus()
    {
      SourceStatus sourceStatus = new SourceStatus();
      foreach (ConcatenatedSource.Element element in this.Elements)
      {
        foreach (Range availableRange in (List<Range>) element.Source.QueryStatus().AvailableRangeList)
          sourceStatus.AvailableRangeList.MergingAdd(new Range(availableRange.Offset + element.Offset, availableRange.Size));
      }
      return sourceStatus;
    }

    public class Element
    {
      public ISource Source { get; private set; }

      public string Signature { get; private set; }

      public long Offset { get; private set; }

      public Element(ISource source, string signature, long offset)
      {
        this.Source = source;
        this.Signature = signature;
        this.Offset = offset;
      }
    }

    private class ElementOffsetComparer : IComparer<ConcatenatedSource.Element>
    {
      public int Compare(ConcatenatedSource.Element s1, ConcatenatedSource.Element s2)
      {
        if (s1.Offset > s2.Offset)
          return 1;
        if (s1.Offset < s2.Offset)
          return -1;
        if (s1.Source.Size > s2.Source.Size)
          return 1;
        return s1.Source.Size < s2.Source.Size ? -1 : 0;
      }
    }
  }
}
