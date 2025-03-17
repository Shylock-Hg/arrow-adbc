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

  public partial class TSparkArrowTypes : TBase
  {
    private bool _timestampAsArrow;
    private bool _decimalAsArrow;
    private bool _complexTypesAsArrow;
    private bool _intervalTypesAsArrow;
    private bool _nullTypeAsArrow;

    public bool TimestampAsArrow
    {
      get
      {
        return _timestampAsArrow;
      }
      set
      {
        __isset.timestampAsArrow = true;
        this._timestampAsArrow = value;
      }
    }

    public bool DecimalAsArrow
    {
      get
      {
        return _decimalAsArrow;
      }
      set
      {
        __isset.decimalAsArrow = true;
        this._decimalAsArrow = value;
      }
    }

    public bool ComplexTypesAsArrow
    {
      get
      {
        return _complexTypesAsArrow;
      }
      set
      {
        __isset.complexTypesAsArrow = true;
        this._complexTypesAsArrow = value;
      }
    }

    public bool IntervalTypesAsArrow
    {
      get
      {
        return _intervalTypesAsArrow;
      }
      set
      {
        __isset.intervalTypesAsArrow = true;
        this._intervalTypesAsArrow = value;
      }
    }

    public bool NullTypeAsArrow
    {
      get
      {
        return _nullTypeAsArrow;
      }
      set
      {
        __isset.nullTypeAsArrow = true;
        this._nullTypeAsArrow = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool timestampAsArrow;
      public bool decimalAsArrow;
      public bool complexTypesAsArrow;
      public bool intervalTypesAsArrow;
      public bool nullTypeAsArrow;
    }

    public TSparkArrowTypes()
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
                TimestampAsArrow = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Bool)
              {
                DecimalAsArrow = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                ComplexTypesAsArrow = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Bool)
              {
                IntervalTypesAsArrow = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Bool)
              {
                NullTypeAsArrow = await iprot.ReadBoolAsync(cancellationToken);
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
        var tmp375 = new TStruct("TSparkArrowTypes");
        await oprot.WriteStructBeginAsync(tmp375, cancellationToken);
        var tmp376 = new TField();
        if(__isset.timestampAsArrow)
        {
          tmp376.Name = "timestampAsArrow";
          tmp376.Type = TType.Bool;
          tmp376.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
          await oprot.WriteBoolAsync(TimestampAsArrow, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.decimalAsArrow)
        {
          tmp376.Name = "decimalAsArrow";
          tmp376.Type = TType.Bool;
          tmp376.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
          await oprot.WriteBoolAsync(DecimalAsArrow, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.complexTypesAsArrow)
        {
          tmp376.Name = "complexTypesAsArrow";
          tmp376.Type = TType.Bool;
          tmp376.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
          await oprot.WriteBoolAsync(ComplexTypesAsArrow, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.intervalTypesAsArrow)
        {
          tmp376.Name = "intervalTypesAsArrow";
          tmp376.Type = TType.Bool;
          tmp376.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
          await oprot.WriteBoolAsync(IntervalTypesAsArrow, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.nullTypeAsArrow)
        {
          tmp376.Name = "nullTypeAsArrow";
          tmp376.Type = TType.Bool;
          tmp376.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp376, cancellationToken);
          await oprot.WriteBoolAsync(NullTypeAsArrow, cancellationToken);
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
      if (!(that is TSparkArrowTypes other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.timestampAsArrow == other.__isset.timestampAsArrow) && ((!__isset.timestampAsArrow) || (global::System.Object.Equals(TimestampAsArrow, other.TimestampAsArrow))))
        && ((__isset.decimalAsArrow == other.__isset.decimalAsArrow) && ((!__isset.decimalAsArrow) || (global::System.Object.Equals(DecimalAsArrow, other.DecimalAsArrow))))
        && ((__isset.complexTypesAsArrow == other.__isset.complexTypesAsArrow) && ((!__isset.complexTypesAsArrow) || (global::System.Object.Equals(ComplexTypesAsArrow, other.ComplexTypesAsArrow))))
        && ((__isset.intervalTypesAsArrow == other.__isset.intervalTypesAsArrow) && ((!__isset.intervalTypesAsArrow) || (global::System.Object.Equals(IntervalTypesAsArrow, other.IntervalTypesAsArrow))))
        && ((__isset.nullTypeAsArrow == other.__isset.nullTypeAsArrow) && ((!__isset.nullTypeAsArrow) || (global::System.Object.Equals(NullTypeAsArrow, other.NullTypeAsArrow))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.timestampAsArrow)
        {
          hashcode = (hashcode * 397) + TimestampAsArrow.GetHashCode();
        }
        if(__isset.decimalAsArrow)
        {
          hashcode = (hashcode * 397) + DecimalAsArrow.GetHashCode();
        }
        if(__isset.complexTypesAsArrow)
        {
          hashcode = (hashcode * 397) + ComplexTypesAsArrow.GetHashCode();
        }
        if(__isset.intervalTypesAsArrow)
        {
          hashcode = (hashcode * 397) + IntervalTypesAsArrow.GetHashCode();
        }
        if(__isset.nullTypeAsArrow)
        {
          hashcode = (hashcode * 397) + NullTypeAsArrow.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp377 = new StringBuilder("TSparkArrowTypes(");
      int tmp378 = 0;
      if(__isset.timestampAsArrow)
      {
        if(0 < tmp378++) { tmp377.Append(", "); }
        tmp377.Append("TimestampAsArrow: ");
        TimestampAsArrow.ToString(tmp377);
      }
      if(__isset.decimalAsArrow)
      {
        if(0 < tmp378++) { tmp377.Append(", "); }
        tmp377.Append("DecimalAsArrow: ");
        DecimalAsArrow.ToString(tmp377);
      }
      if(__isset.complexTypesAsArrow)
      {
        if(0 < tmp378++) { tmp377.Append(", "); }
        tmp377.Append("ComplexTypesAsArrow: ");
        ComplexTypesAsArrow.ToString(tmp377);
      }
      if(__isset.intervalTypesAsArrow)
      {
        if(0 < tmp378++) { tmp377.Append(", "); }
        tmp377.Append("IntervalTypesAsArrow: ");
        IntervalTypesAsArrow.ToString(tmp377);
      }
      if(__isset.nullTypeAsArrow)
      {
        if(0 < tmp378++) { tmp377.Append(", "); }
        tmp377.Append("NullTypeAsArrow: ");
        NullTypeAsArrow.ToString(tmp377);
      }
      tmp377.Append(')');
      return tmp377.ToString();
    }
  }

}
