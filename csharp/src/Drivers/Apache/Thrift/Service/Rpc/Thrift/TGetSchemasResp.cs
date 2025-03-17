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

  public partial class TGetSchemasResp : TBase
  {
    private global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle _operationHandle;
    private global::Apache.Hive.Service.Rpc.Thrift.TSparkDirectResults _directResults;

    public global::Apache.Hive.Service.Rpc.Thrift.TStatus Status { get; set; }

    public global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle OperationHandle
    {
      get
      {
        return _operationHandle;
      }
      set
      {
        __isset.operationHandle = true;
        this._operationHandle = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TSparkDirectResults DirectResults
    {
      get
      {
        return _directResults;
      }
      set
      {
        __isset.directResults = true;
        this._directResults = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool operationHandle;
      public bool directResults;
    }

    public TGetSchemasResp()
    {
    }

    public TGetSchemasResp(global::Apache.Hive.Service.Rpc.Thrift.TStatus @status) : this()
    {
      this.Status = @status;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_status = false;
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
                Status = new global::Apache.Hive.Service.Rpc.Thrift.TStatus();
                await Status.ReadAsync(iprot, cancellationToken);
                isset_status = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                OperationHandle = new global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle();
                await OperationHandle.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 1281:
              if (field.Type == TType.Struct)
              {
                DirectResults = new global::Apache.Hive.Service.Rpc.Thrift.TSparkDirectResults();
                await DirectResults.ReadAsync(iprot, cancellationToken);
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
        if (!isset_status)
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
        var tmp462 = new TStruct("TGetSchemasResp");
        await oprot.WriteStructBeginAsync(tmp462, cancellationToken);
        var tmp463 = new TField();
        if((Status != null))
        {
          tmp463.Name = "status";
          tmp463.Type = TType.Struct;
          tmp463.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp463, cancellationToken);
          await Status.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((OperationHandle != null) && __isset.operationHandle)
        {
          tmp463.Name = "operationHandle";
          tmp463.Type = TType.Struct;
          tmp463.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp463, cancellationToken);
          await OperationHandle.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((DirectResults != null) && __isset.directResults)
        {
          tmp463.Name = "directResults";
          tmp463.Type = TType.Struct;
          tmp463.ID = 1281;
          await oprot.WriteFieldBeginAsync(tmp463, cancellationToken);
          await DirectResults.WriteAsync(oprot, cancellationToken);
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
      if (!(that is TGetSchemasResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(Status, other.Status)
        && ((__isset.operationHandle == other.__isset.operationHandle) && ((!__isset.operationHandle) || (global::System.Object.Equals(OperationHandle, other.OperationHandle))))
        && ((__isset.directResults == other.__isset.directResults) && ((!__isset.directResults) || (global::System.Object.Equals(DirectResults, other.DirectResults))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Status != null))
        {
          hashcode = (hashcode * 397) + Status.GetHashCode();
        }
        if((OperationHandle != null) && __isset.operationHandle)
        {
          hashcode = (hashcode * 397) + OperationHandle.GetHashCode();
        }
        if((DirectResults != null) && __isset.directResults)
        {
          hashcode = (hashcode * 397) + DirectResults.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp464 = new StringBuilder("TGetSchemasResp(");
      if((Status != null))
      {
        tmp464.Append(", Status: ");
        Status.ToString(tmp464);
      }
      if((OperationHandle != null) && __isset.operationHandle)
      {
        tmp464.Append(", OperationHandle: ");
        OperationHandle.ToString(tmp464);
      }
      if((DirectResults != null) && __isset.directResults)
      {
        tmp464.Append(", DirectResults: ");
        DirectResults.ToString(tmp464);
      }
      tmp464.Append(')');
      return tmp464.ToString();
    }
  }

}
