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

  internal partial class TRenewDelegationTokenResp : TBase
  {

    public global::Apache.Hive.Service.Rpc.Thrift.TStatus Status { get; set; }

    public TRenewDelegationTokenResp()
    {
    }

    public TRenewDelegationTokenResp(global::Apache.Hive.Service.Rpc.Thrift.TStatus @status) : this()
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
        var tmp587 = new TStruct("TRenewDelegationTokenResp");
        await oprot.WriteStructBeginAsync(tmp587, cancellationToken);
        var tmp588 = new TField();
        if((Status != null))
        {
          tmp588.Name = "status";
          tmp588.Type = TType.Struct;
          tmp588.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp588, cancellationToken);
          await Status.WriteAsync(oprot, cancellationToken);
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
      if (!(that is TRenewDelegationTokenResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(Status, other.Status);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Status != null))
        {
          hashcode = (hashcode * 397) + Status.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp589 = new StringBuilder("TRenewDelegationTokenResp(");
      if((Status != null))
      {
        tmp589.Append(", Status: ");
        Status.ToString(tmp589);
      }
      tmp589.Append(')');
      return tmp589.ToString();
    }
  }

}
