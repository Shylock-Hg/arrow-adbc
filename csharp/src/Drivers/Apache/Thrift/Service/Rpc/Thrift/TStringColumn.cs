/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.21.0)
 * BUT THIS FILE HAS BEEN HAND EDITED TO SUPPORT ARROW AND DISABLE NULLABLE SO REGENERATE AT YOUR OWN RISK
 * </auto-generated>
 */
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Apache.Arrow;
using Apache.Arrow.Adbc.Drivers.Apache;
using Apache.Arrow.Adbc.Drivers.Apache.Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;

#nullable disable

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Apache.Hive.Service.Rpc.Thrift
{

  public partial class TStringColumn : TBase
  {

    public StringArray Values { get; set; }

    public TStringColumn()
    {
    }

    public TStringColumn(StringArray values) : this()
    {
      this.Values = values;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_values = false;
        bool isset_nulls = false;
        TField field;

        ArrowBuffer.Builder<byte> values = null;
        byte[] nulls = null;
        byte[] offsetBuffer = null;
        Stream transport = ((IPeekableTransport)iprot.Transport).Input;
        int length = -1;
        byte[] preAllocatedBuffer = new byte[65536];

        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.List)
              {
                {
                  var _list187 = await iprot.ReadListBeginAsync(cancellationToken);
                  length = _list187.Count;

                  values = new ArrowBuffer.Builder<byte>();
                  int offset = 0;
                  offsetBuffer = new byte[(length + 1) * 4];
                  var memory = offsetBuffer.AsMemory();

                  for(int _i188 = 0; _i188 < length; ++_i188)
                  {
                    StreamExtensions.WriteInt32LittleEndian(offset, memory.Span, _i188 * 4);

                    var size = await iprot.ReadI32Async(cancellationToken);
                    offset += size;

                    iprot.Transport.CheckReadBytesAvailable(size);

                    byte[] tmp;
                    if (size <= preAllocatedBuffer.Length)
                    {
                      tmp = preAllocatedBuffer;
                    }
                    else
                    {
                      tmp = new byte[size];
                    }

                    await transport.ReadExactlyAsync(tmp.AsMemory(0, size), cancellationToken);
                    values.Append(tmp.AsMemory(0, size).Span);
                  }
                  StreamExtensions.WriteInt32LittleEndian(offset, memory.Span, length * 4);

                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_values = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                nulls = await iprot.ReadBinaryAsync(cancellationToken);
                isset_nulls = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default:
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_values)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_nulls)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        ArrowBuffer validityBitmapBuffer = BitmapUtilities.GetValidityBitmapBuffer(ref nulls, length, out int nullCount);
        Values = new StringArray(length, new ArrowBuffer(offsetBuffer), values.Build(), validityBitmapBuffer, nullCount);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp190 = new TStruct("TStringColumn");
        await oprot.WriteStructBeginAsync(tmp190, cancellationToken);
        var tmp191 = new TField();
        if ((Values != null))
        {
          tmp191.Name = "values";
          tmp191.Type = TType.List;
          tmp191.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp191, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.String, Values.Length), cancellationToken);
          for (int i = 0; i < Values.Length; i++)
          {
            // TODO: It would be nice to write the binary value instead but TProtocol doesn't support Spans
            string _iter192 = Values.GetString(i);
            await oprot.WriteStringAsync(_iter192, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);

          tmp191.Name = "nulls";
          tmp191.Type = TType.String;
          tmp191.ID = 2;
          byte[] nulls = new byte[Values.NullBitmapBuffer.Span.Length];
          Values.NullBitmapBuffer.Span.CopyTo(nulls);
          await oprot.WriteFieldBeginAsync(tmp191, cancellationToken);
          await oprot.WriteBinaryAsync(nulls, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is TStringColumn other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Values, other.Values);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if ((Values != null))
        {
          for (int i = 0; i < Values.Length; i++)
          {
            string thisValue = Values.GetString(i);
            hashcode = (hashcode * 397) + (thisValue?.GetHashCode() ?? 0);
          }
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp193 = new StringBuilder("TStringColumn(");
      if ((Values != null))
      {
        tmp193.Append(", Values: ");
        Values.ToString(tmp193);
      }
      tmp193.Append(')');
      return tmp193.ToString();
    }
  }

}
