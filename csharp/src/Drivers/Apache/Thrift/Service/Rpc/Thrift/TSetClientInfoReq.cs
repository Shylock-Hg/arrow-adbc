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

  public partial class TSetClientInfoReq : TBase
  {
    private Dictionary<string, string> _configuration;

    public global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle SessionHandle { get; set; }

    public Dictionary<string, string> Configuration
    {
      get
      {
        return _configuration;
      }
      set
      {
        __isset.@configuration = true;
        this._configuration = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool @configuration;
    }

    public TSetClientInfoReq()
    {
    }

    public TSetClientInfoReq(global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle sessionHandle) : this()
    {
      this.SessionHandle = sessionHandle;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_sessionHandle = false;
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
              if (field.Type == TType.Struct)
              {
                SessionHandle = new global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle();
                await SessionHandle.ReadAsync(iprot, cancellationToken);
                isset_sessionHandle = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Map)
              {
                {
                  var _map347 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Configuration = new Dictionary<string, string>(_map347.Count);
                  for(int _i348 = 0; _i348 < _map347.Count; ++_i348)
                  {
                    string _key349;
                    string _val350;
                    _key349 = await iprot.ReadStringAsync(cancellationToken);
                    _val350 = await iprot.ReadStringAsync(cancellationToken);
                    Configuration[_key349] = _val350;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
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
        if (!isset_sessionHandle)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
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
        var tmp351 = new TStruct("TSetClientInfoReq");
        await oprot.WriteStructBeginAsync(tmp351, cancellationToken);
        var tmp352 = new TField();
        if((SessionHandle != null))
        {
          tmp352.Name = "sessionHandle";
          tmp352.Type = TType.Struct;
          tmp352.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp352, cancellationToken);
          await SessionHandle.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Configuration != null) && __isset.@configuration)
        {
          tmp352.Name = "configuration";
          tmp352.Type = TType.Map;
          tmp352.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp352, cancellationToken);
          await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Configuration.Count), cancellationToken);
          foreach (string _iter353 in Configuration.Keys)
          {
            await oprot.WriteStringAsync(_iter353, cancellationToken);
            await oprot.WriteStringAsync(Configuration[_iter353], cancellationToken);
          }
          await oprot.WriteMapEndAsync(cancellationToken);
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
      if (!(that is TSetClientInfoReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(SessionHandle, other.SessionHandle)
        && ((__isset.@configuration == other.__isset.@configuration) && ((!__isset.@configuration) || (TCollections.Equals(Configuration, other.Configuration))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((SessionHandle != null))
        {
          hashcode = (hashcode * 397) + SessionHandle.GetHashCode();
        }
        if((Configuration != null) && __isset.@configuration)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Configuration);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp354 = new StringBuilder("TSetClientInfoReq(");
      if((SessionHandle != null))
      {
        tmp354.Append(", SessionHandle: ");
        SessionHandle.ToString(tmp354);
      }
      if((Configuration != null) && __isset.@configuration)
      {
        tmp354.Append(", Configuration: ");
        Configuration.ToString(tmp354);
      }
      tmp354.Append(')');
      return tmp354.ToString();
    }
  }

}
