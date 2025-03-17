/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.21.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


// targeting netstandard 2.x
#if(! NETSTANDARD2_0_OR_GREATER && ! NET6_0_OR_GREATER && ! NET472_OR_GREATER)
#error Unexpected target platform. See 'thrift --help' for details.
#endif

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable CS0618   // silence our own deprecation warnings
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Apache.Hive.Service.Rpc.Thrift
{

  public partial class TDBSqlJsonArrayFormat : TBase
  {
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCompressionCodec _compressionCodec;

    /// <summary>
    ///
    /// <seealso cref="global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCompressionCodec"/>
    /// </summary>
    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCompressionCodec CompressionCodec
    {
      get
      {
        return _compressionCodec;
      }
      set
      {
        __isset.compressionCodec = true;
        this._compressionCodec = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool compressionCodec;
    }

    public TDBSqlJsonArrayFormat()
    {
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
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
              if (field.Type == TType.I32)
              {
                CompressionCodec = (global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCompressionCodec)await iprot.ReadI32Async(cancellationToken);
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
        var tmp179 = new TStruct("TDBSqlJsonArrayFormat");
        await oprot.WriteStructBeginAsync(tmp179, cancellationToken);
        var tmp180 = new TField();
        if(__isset.compressionCodec)
        {
          tmp180.Name = "compressionCodec";
          tmp180.Type = TType.I32;
          tmp180.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp180, cancellationToken);
          await oprot.WriteI32Async((int)CompressionCodec, cancellationToken);
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
      if (!(that is TDBSqlJsonArrayFormat other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.compressionCodec == other.__isset.compressionCodec) && ((!__isset.compressionCodec) || (global::System.Object.Equals(CompressionCodec, other.CompressionCodec))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.compressionCodec)
        {
          hashcode = (hashcode * 397) + CompressionCodec.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp181 = new StringBuilder("TDBSqlJsonArrayFormat(");
      int tmp182 = 0;
      if(__isset.compressionCodec)
      {
        if(0 < tmp182++) { tmp181.Append(", "); }
        tmp181.Append("CompressionCodec: ");
        CompressionCodec.ToString(tmp181);
      }
      tmp181.Append(')');
      return tmp181.ToString();
    }
  }

}
