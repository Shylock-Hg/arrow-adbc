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

  public partial class TCloseOperationReq : TBase
  {
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCloseOperationReason _closeReason;

    public global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle OperationHandle { get; set; }

    /// <summary>
    ///
    /// <seealso cref="global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCloseOperationReason"/>
    /// </summary>
    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCloseOperationReason CloseReason
    {
      get
      {
        return _closeReason;
      }
      set
      {
        __isset.closeReason = true;
        this._closeReason = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool closeReason;
    }

    public TCloseOperationReq()
    {
      this._closeReason = global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCloseOperationReason.NONE;
      this.__isset.closeReason = true;
    }

    public TCloseOperationReq(global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle operationHandle) : this()
    {
      this.OperationHandle = operationHandle;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_operationHandle = false;
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
                OperationHandle = new global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle();
                await OperationHandle.ReadAsync(iprot, cancellationToken);
                isset_operationHandle = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3329:
              if (field.Type == TType.I32)
              {
                CloseReason = (global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCloseOperationReason)await iprot.ReadI32Async(cancellationToken);
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
        if (!isset_operationHandle)
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
        var tmp539 = new TStruct("TCloseOperationReq");
        await oprot.WriteStructBeginAsync(tmp539, cancellationToken);
        var tmp540 = new TField();
        if((OperationHandle != null))
        {
          tmp540.Name = "operationHandle";
          tmp540.Type = TType.Struct;
          tmp540.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp540, cancellationToken);
          await OperationHandle.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.closeReason)
        {
          tmp540.Name = "closeReason";
          tmp540.Type = TType.I32;
          tmp540.ID = 3329;
          await oprot.WriteFieldBeginAsync(tmp540, cancellationToken);
          await oprot.WriteI32Async((int)CloseReason, cancellationToken);
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
      if (!(that is TCloseOperationReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(OperationHandle, other.OperationHandle)
        && ((__isset.closeReason == other.__isset.closeReason) && ((!__isset.closeReason) || (global::System.Object.Equals(CloseReason, other.CloseReason))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((OperationHandle != null))
        {
          hashcode = (hashcode * 397) + OperationHandle.GetHashCode();
        }
        if(__isset.closeReason)
        {
          hashcode = (hashcode * 397) + CloseReason.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp541 = new StringBuilder("TCloseOperationReq(");
      if((OperationHandle != null))
      {
        tmp541.Append(", OperationHandle: ");
        OperationHandle.ToString(tmp541);
      }
      if(__isset.closeReason)
      {
        tmp541.Append(", CloseReason: ");
        CloseReason.ToString(tmp541);
      }
      tmp541.Append(')');
      return tmp541.ToString();
    }
  }

}
