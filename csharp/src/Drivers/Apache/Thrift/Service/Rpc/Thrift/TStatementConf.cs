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

  internal partial class TStatementConf : TBase
  {
    private bool _sessionless;
    private global::Apache.Hive.Service.Rpc.Thrift.TNamespace _initialNamespace;
    private global::Apache.Hive.Service.Rpc.Thrift.TProtocolVersion _client_protocol;
    private long _client_protocol_i64;

    public bool Sessionless
    {
      get
      {
        return _sessionless;
      }
      set
      {
        __isset.@sessionless = true;
        this._sessionless = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TNamespace InitialNamespace
    {
      get
      {
        return _initialNamespace;
      }
      set
      {
        __isset.initialNamespace = true;
        this._initialNamespace = value;
      }
    }

    /// <summary>
    ///
    /// <seealso cref="global::Apache.Hive.Service.Rpc.Thrift.TProtocolVersion"/>
    /// </summary>
    public global::Apache.Hive.Service.Rpc.Thrift.TProtocolVersion Client_protocol
    {
      get
      {
        return _client_protocol;
      }
      set
      {
        __isset.client_protocol = true;
        this._client_protocol = value;
      }
    }

    public long Client_protocol_i64
    {
      get
      {
        return _client_protocol_i64;
      }
      set
      {
        __isset.client_protocol_i64 = true;
        this._client_protocol_i64 = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool @sessionless;
      public bool initialNamespace;
      public bool client_protocol;
      public bool client_protocol_i64;
    }

    public TStatementConf()
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
              if (field.Type == TType.Bool)
              {
                Sessionless = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                InitialNamespace = new global::Apache.Hive.Service.Rpc.Thrift.TNamespace();
                await InitialNamespace.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Client_protocol = (global::Apache.Hive.Service.Rpc.Thrift.TProtocolVersion)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Client_protocol_i64 = await iprot.ReadI64Async(cancellationToken);
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
        var tmp425 = new TStruct("TStatementConf");
        await oprot.WriteStructBeginAsync(tmp425, cancellationToken);
        var tmp426 = new TField();
        if(__isset.@sessionless)
        {
          tmp426.Name = "sessionless";
          tmp426.Type = TType.Bool;
          tmp426.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp426, cancellationToken);
          await oprot.WriteBoolAsync(Sessionless, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((InitialNamespace != null) && __isset.initialNamespace)
        {
          tmp426.Name = "initialNamespace";
          tmp426.Type = TType.Struct;
          tmp426.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp426, cancellationToken);
          await InitialNamespace.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.client_protocol)
        {
          tmp426.Name = "client_protocol";
          tmp426.Type = TType.I32;
          tmp426.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp426, cancellationToken);
          await oprot.WriteI32Async((int)Client_protocol, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.client_protocol_i64)
        {
          tmp426.Name = "client_protocol_i64";
          tmp426.Type = TType.I64;
          tmp426.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp426, cancellationToken);
          await oprot.WriteI64Async(Client_protocol_i64, cancellationToken);
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
      if (!(that is TStatementConf other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.@sessionless == other.__isset.@sessionless) && ((!__isset.@sessionless) || (global::System.Object.Equals(Sessionless, other.Sessionless))))
        && ((__isset.initialNamespace == other.__isset.initialNamespace) && ((!__isset.initialNamespace) || (global::System.Object.Equals(InitialNamespace, other.InitialNamespace))))
        && ((__isset.client_protocol == other.__isset.client_protocol) && ((!__isset.client_protocol) || (global::System.Object.Equals(Client_protocol, other.Client_protocol))))
        && ((__isset.client_protocol_i64 == other.__isset.client_protocol_i64) && ((!__isset.client_protocol_i64) || (global::System.Object.Equals(Client_protocol_i64, other.Client_protocol_i64))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.@sessionless)
        {
          hashcode = (hashcode * 397) + Sessionless.GetHashCode();
        }
        if((InitialNamespace != null) && __isset.initialNamespace)
        {
          hashcode = (hashcode * 397) + InitialNamespace.GetHashCode();
        }
        if(__isset.client_protocol)
        {
          hashcode = (hashcode * 397) + Client_protocol.GetHashCode();
        }
        if(__isset.client_protocol_i64)
        {
          hashcode = (hashcode * 397) + Client_protocol_i64.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp427 = new StringBuilder("TStatementConf(");
      int tmp428 = 0;
      if(__isset.@sessionless)
      {
        if(0 < tmp428++) { tmp427.Append(", "); }
        tmp427.Append("Sessionless: ");
        Sessionless.ToString(tmp427);
      }
      if((InitialNamespace != null) && __isset.initialNamespace)
      {
        if(0 < tmp428++) { tmp427.Append(", "); }
        tmp427.Append("InitialNamespace: ");
        InitialNamespace.ToString(tmp427);
      }
      if(__isset.client_protocol)
      {
        if(0 < tmp428++) { tmp427.Append(", "); }
        tmp427.Append("Client_protocol: ");
        Client_protocol.ToString(tmp427);
      }
      if(__isset.client_protocol_i64)
      {
        if(0 < tmp428++) { tmp427.Append(", "); }
        tmp427.Append("Client_protocol_i64: ");
        Client_protocol_i64.ToString(tmp427);
      }
      tmp427.Append(')');
      return tmp427.ToString();
    }
  }

}
