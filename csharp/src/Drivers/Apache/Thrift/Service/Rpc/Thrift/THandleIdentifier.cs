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

  internal partial class THandleIdentifier : TBase
  {
    private short _executionVersion;

    public byte[] Guid { get; set; }

    public byte[] Secret { get; set; }

    public short ExecutionVersion
    {
      get
      {
        return _executionVersion;
      }
      set
      {
        __isset.executionVersion = true;
        this._executionVersion = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool executionVersion;
    }

    public THandleIdentifier()
    {
    }

    public THandleIdentifier(byte[] @guid, byte[] @secret) : this()
    {
      this.Guid = @guid;
      this.Secret = @secret;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_guid = false;
        bool isset_secret = false;
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
              if (field.Type == TType.String)
              {
                Guid = await iprot.ReadBinaryAsync(cancellationToken);
                isset_guid = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Secret = await iprot.ReadBinaryAsync(cancellationToken);
                isset_secret = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3329:
              if (field.Type == TType.I16)
              {
                ExecutionVersion = await iprot.ReadI16Async(cancellationToken);
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
        if (!isset_guid)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_secret)
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
        var tmp304 = new TStruct("THandleIdentifier");
        await oprot.WriteStructBeginAsync(tmp304, cancellationToken);
        var tmp305 = new TField();
        if((Guid != null))
        {
          tmp305.Name = "guid";
          tmp305.Type = TType.String;
          tmp305.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp305, cancellationToken);
          await oprot.WriteBinaryAsync(Guid, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Secret != null))
        {
          tmp305.Name = "secret";
          tmp305.Type = TType.String;
          tmp305.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp305, cancellationToken);
          await oprot.WriteBinaryAsync(Secret, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.executionVersion)
        {
          tmp305.Name = "executionVersion";
          tmp305.Type = TType.I16;
          tmp305.ID = 3329;
          await oprot.WriteFieldBeginAsync(tmp305, cancellationToken);
          await oprot.WriteI16Async(ExecutionVersion, cancellationToken);
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
      if (!(that is THandleIdentifier other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Guid, other.Guid)
        && TCollections.Equals(Secret, other.Secret)
        && ((__isset.executionVersion == other.__isset.executionVersion) && ((!__isset.executionVersion) || (global::System.Object.Equals(ExecutionVersion, other.ExecutionVersion))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Guid != null))
        {
          hashcode = (hashcode * 397) + Guid.GetHashCode();
        }
        if((Secret != null))
        {
          hashcode = (hashcode * 397) + Secret.GetHashCode();
        }
        if(__isset.executionVersion)
        {
          hashcode = (hashcode * 397) + ExecutionVersion.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp306 = new StringBuilder("THandleIdentifier(");
      if((Guid != null))
      {
        tmp306.Append(", Guid: ");
        Guid.ToString(tmp306);
      }
      if((Secret != null))
      {
        tmp306.Append(", Secret: ");
        Secret.ToString(tmp306);
      }
      if(__isset.executionVersion)
      {
        tmp306.Append(", ExecutionVersion: ");
        ExecutionVersion.ToString(tmp306);
      }
      tmp306.Append(')');
      return tmp306.ToString();
    }
  }

}
