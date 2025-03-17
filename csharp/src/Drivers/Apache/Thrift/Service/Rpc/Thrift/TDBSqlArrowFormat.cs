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

  public partial class TDBSqlArrowFormat : TBase
  {
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlArrowLayout _arrowLayout;
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCompressionCodec _compressionCodec;

    /// <summary>
    ///
    /// <seealso cref="global::Apache.Hive.Service.Rpc.Thrift.TDBSqlArrowLayout"/>
    /// </summary>
    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlArrowLayout ArrowLayout
    {
      get
      {
        return _arrowLayout;
      }
      set
      {
        __isset.arrowLayout = true;
        this._arrowLayout = value;
      }
    }

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
      public bool arrowLayout;
      public bool compressionCodec;
    }

    public TDBSqlArrowFormat()
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
                ArrowLayout = (global::Apache.Hive.Service.Rpc.Thrift.TDBSqlArrowLayout)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
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
        var tmp187 = new TStruct("TDBSqlArrowFormat");
        await oprot.WriteStructBeginAsync(tmp187, cancellationToken);
        var tmp188 = new TField();
        if(__isset.arrowLayout)
        {
          tmp188.Name = "arrowLayout";
          tmp188.Type = TType.I32;
          tmp188.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp188, cancellationToken);
          await oprot.WriteI32Async((int)ArrowLayout, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.compressionCodec)
        {
          tmp188.Name = "compressionCodec";
          tmp188.Type = TType.I32;
          tmp188.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp188, cancellationToken);
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
      if (!(that is TDBSqlArrowFormat other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.arrowLayout == other.__isset.arrowLayout) && ((!__isset.arrowLayout) || (global::System.Object.Equals(ArrowLayout, other.ArrowLayout))))
        && ((__isset.compressionCodec == other.__isset.compressionCodec) && ((!__isset.compressionCodec) || (global::System.Object.Equals(CompressionCodec, other.CompressionCodec))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.arrowLayout)
        {
          hashcode = (hashcode * 397) + ArrowLayout.GetHashCode();
        }
        if(__isset.compressionCodec)
        {
          hashcode = (hashcode * 397) + CompressionCodec.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp189 = new StringBuilder("TDBSqlArrowFormat(");
      int tmp190 = 0;
      if(__isset.arrowLayout)
      {
        if(0 < tmp190++) { tmp189.Append(", "); }
        tmp189.Append("ArrowLayout: ");
        ArrowLayout.ToString(tmp189);
      }
      if(__isset.compressionCodec)
      {
        if(0 < tmp190++) { tmp189.Append(", "); }
        tmp189.Append("CompressionCodec: ");
        CompressionCodec.ToString(tmp189);
      }
      tmp189.Append(')');
      return tmp189.ToString();
    }
  }

}
