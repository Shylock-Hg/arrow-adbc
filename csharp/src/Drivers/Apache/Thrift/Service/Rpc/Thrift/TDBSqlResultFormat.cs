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

  public partial class TDBSqlResultFormat : TBase
  {
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlArrowFormat _arrowFormat;
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCsvFormat _csvFormat;
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlJsonArrayFormat _jsonArrayFormat;

    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlArrowFormat ArrowFormat
    {
      get
      {
        return _arrowFormat;
      }
      set
      {
        __isset.arrowFormat = true;
        this._arrowFormat = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCsvFormat CsvFormat
    {
      get
      {
        return _csvFormat;
      }
      set
      {
        __isset.csvFormat = true;
        this._csvFormat = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlJsonArrayFormat JsonArrayFormat
    {
      get
      {
        return _jsonArrayFormat;
      }
      set
      {
        __isset.jsonArrayFormat = true;
        this._jsonArrayFormat = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool arrowFormat;
      public bool csvFormat;
      public bool jsonArrayFormat;
    }

    public TDBSqlResultFormat()
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
              if (field.Type == TType.Struct)
              {
                ArrowFormat = new global::Apache.Hive.Service.Rpc.Thrift.TDBSqlArrowFormat();
                await ArrowFormat.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                CsvFormat = new global::Apache.Hive.Service.Rpc.Thrift.TDBSqlCsvFormat();
                await CsvFormat.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                JsonArrayFormat = new global::Apache.Hive.Service.Rpc.Thrift.TDBSqlJsonArrayFormat();
                await JsonArrayFormat.ReadAsync(iprot, cancellationToken);
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
        var tmp191 = new TStruct("TDBSqlResultFormat");
        await oprot.WriteStructBeginAsync(tmp191, cancellationToken);
        var tmp192 = new TField();
        if((ArrowFormat != null) && __isset.arrowFormat)
        {
          tmp192.Name = "arrowFormat";
          tmp192.Type = TType.Struct;
          tmp192.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp192, cancellationToken);
          await ArrowFormat.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((CsvFormat != null) && __isset.csvFormat)
        {
          tmp192.Name = "csvFormat";
          tmp192.Type = TType.Struct;
          tmp192.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp192, cancellationToken);
          await CsvFormat.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((JsonArrayFormat != null) && __isset.jsonArrayFormat)
        {
          tmp192.Name = "jsonArrayFormat";
          tmp192.Type = TType.Struct;
          tmp192.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp192, cancellationToken);
          await JsonArrayFormat.WriteAsync(oprot, cancellationToken);
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
      if (!(that is TDBSqlResultFormat other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.arrowFormat == other.__isset.arrowFormat) && ((!__isset.arrowFormat) || (global::System.Object.Equals(ArrowFormat, other.ArrowFormat))))
        && ((__isset.csvFormat == other.__isset.csvFormat) && ((!__isset.csvFormat) || (global::System.Object.Equals(CsvFormat, other.CsvFormat))))
        && ((__isset.jsonArrayFormat == other.__isset.jsonArrayFormat) && ((!__isset.jsonArrayFormat) || (global::System.Object.Equals(JsonArrayFormat, other.JsonArrayFormat))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((ArrowFormat != null) && __isset.arrowFormat)
        {
          hashcode = (hashcode * 397) + ArrowFormat.GetHashCode();
        }
        if((CsvFormat != null) && __isset.csvFormat)
        {
          hashcode = (hashcode * 397) + CsvFormat.GetHashCode();
        }
        if((JsonArrayFormat != null) && __isset.jsonArrayFormat)
        {
          hashcode = (hashcode * 397) + JsonArrayFormat.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp193 = new StringBuilder("TDBSqlResultFormat(");
      int tmp194 = 0;
      if((ArrowFormat != null) && __isset.arrowFormat)
      {
        if(0 < tmp194++) { tmp193.Append(", "); }
        tmp193.Append("ArrowFormat: ");
        ArrowFormat.ToString(tmp193);
      }
      if((CsvFormat != null) && __isset.csvFormat)
      {
        if(0 < tmp194++) { tmp193.Append(", "); }
        tmp193.Append("CsvFormat: ");
        CsvFormat.ToString(tmp193);
      }
      if((JsonArrayFormat != null) && __isset.jsonArrayFormat)
      {
        if(0 < tmp194++) { tmp193.Append(", "); }
        tmp193.Append("JsonArrayFormat: ");
        JsonArrayFormat.ToString(tmp193);
      }
      tmp193.Append(')');
      return tmp193.ToString();
    }
  }

}
