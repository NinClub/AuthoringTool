// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.SourceSinkDriver
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System;
using System.Collections.Generic;

namespace Nintendo.Authoring.AuthoringLibrary
{
  public class SourceSinkDriver
  {
    private List<Connection> m_connectionList;

    public SourceSinkDriver()
    {
      this.m_connectionList = new List<Connection>();
    }

    public void Add(IConnector connector)
    {
      foreach (Connection connection in connector.ConnectionList)
        this.m_connectionList.Add(connection);
    }

    public void Add(ISource source, ISink sink)
    {
      this.m_connectionList.Add(new Connection(source, sink));
    }

    public void Run()
    {
      SourceStatus sourceStatus = new SourceStatus();
      bool flag1 = false;
      while (!flag1)
      {
        bool flag2 = false;
        foreach (Connection connection in this.m_connectionList)
        {
          foreach (Range duplicatedDeleted in (List<Range>) connection.Source.QueryStatus().AvailableRangeList.GetDuplicatedDeletedList(connection.Sink.QueryStatus().FilledRangeList))
          {
            long num1 = 0;
            int length = 8388608;
            byte[] array1 = new byte[length];
            long num2 = 0;
            while (num1 < duplicatedDeleted.Size)
            {
              int size = (int) Math.Min(duplicatedDeleted.Size - num1 - num2, (long) length);
              ByteData data1 = connection.Source.PullData(duplicatedDeleted.Offset + num1 + num2, size);
              ArraySegment<byte> buffer;
              if (num2 + (long) data1.Buffer.Count <= (long) length)
              {
                buffer = data1.Buffer;
                if (buffer.Count != 0 || num2 == 0L)
                  goto label_9;
              }
              num1 += (long) connection.Sink.PushData(new ByteData(new ArraySegment<byte>(array1, 0, (int) num2)), duplicatedDeleted.Offset + num1);
              num2 = 0L;
              buffer = data1.Buffer;
              if (buffer.Count == 0)
                continue;
label_9:
              buffer = data1.Buffer;
              if (buffer.Count == size)
              {
                if (0L < num2)
                {
                  buffer = data1.Buffer;
                  byte[] array2 = buffer.Array;
                  int srcOffset = 0;
                  byte[] numArray = array1;
                  int dstOffset = (int) num2;
                  buffer = data1.Buffer;
                  int count1 = buffer.Count;
                  Buffer.BlockCopy((Array) array2, srcOffset, (Array) numArray, dstOffset, count1);
                  long num3 = num1;
                  ISink sink = connection.Sink;
                  byte[] array3 = array1;
                  int offset1 = 0;
                  int num4 = (int) num2;
                  buffer = data1.Buffer;
                  int count2 = buffer.Count;
                  int count3 = num4 + count2;
                  ByteData data2 = new ByteData(new ArraySegment<byte>(array3, offset1, count3));
                  long offset2 = duplicatedDeleted.Offset + num1;
                  long num5 = (long) sink.PushData(data2, offset2);
                  num1 = num3 + num5;
                  num2 = 0L;
                }
                else
                  num1 += (long) connection.Sink.PushData(data1, duplicatedDeleted.Offset + num1);
              }
              else
              {
                buffer = data1.Buffer;
                byte[] array2 = buffer.Array;
                int srcOffset = 0;
                byte[] numArray = array1;
                int dstOffset = (int) num2;
                buffer = data1.Buffer;
                int count1 = buffer.Count;
                Buffer.BlockCopy((Array) array2, srcOffset, (Array) numArray, dstOffset, count1);
                long num3 = num2;
                buffer = data1.Buffer;
                long count2 = (long) buffer.Count;
                num2 = num3 + count2;
              }
            }
            if (num1 > 0L)
              flag2 = true;
          }
        }
        flag1 = true;
        foreach (Connection connection in this.m_connectionList)
        {
          if (!connection.Sink.QueryStatus().IsFilled)
          {
            flag1 = false;
            break;
          }
        }
        if (!flag1 && !flag2)
          throw new ApplicationException("Failed to resolve dependencies for archiving. Please contact to NintendoSDK support.");
      }
    }
  }
}
