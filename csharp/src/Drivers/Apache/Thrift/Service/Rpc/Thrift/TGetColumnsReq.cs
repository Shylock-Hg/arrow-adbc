/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.21.0)
 * BUT THIS FILE HAS BEEN HAND EDITED TO DISABLE NULLABLE SO REGENERATE AT YOUR OWN RISK
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

#nullable disable

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

  public partial class TGetColumnsReq : TBase
  {
    private string _catalogName;
    private string _schemaName;
    private string _tableName;
    private string _columnName;
    private global::Apache.Hive.Service.Rpc.Thrift.TSparkGetDirectResults _getDirectResults;
    private bool _runAsync;
    private global::Apache.Hive.Service.Rpc.Thrift.THandleIdentifier _operationId;
    private global::Apache.Hive.Service.Rpc.Thrift.TDBSqlSessionConf _sessionConf;

    public global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle SessionHandle { get; set; }

    public string CatalogName
    {
      get
      {
        return _catalogName;
      }
      set
      {
        __isset.catalogName = true;
        this._catalogName = value;
      }
    }

    public string SchemaName
    {
      get
      {
        return _schemaName;
      }
      set
      {
        __isset.schemaName = true;
        this._schemaName = value;
      }
    }

    public string TableName
    {
      get
      {
        return _tableName;
      }
      set
      {
        __isset.tableName = true;
        this._tableName = value;
      }
    }

    public string ColumnName
    {
      get
      {
        return _columnName;
      }
      set
      {
        __isset.columnName = true;
        this._columnName = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TSparkGetDirectResults GetDirectResults
    {
      get
      {
        return _getDirectResults;
      }
      set
      {
        __isset.getDirectResults = true;
        this._getDirectResults = value;
      }
    }

    public bool RunAsync
    {
      get
      {
        return _runAsync;
      }
      set
      {
        __isset.runAsync = true;
        this._runAsync = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.THandleIdentifier OperationId
    {
      get
      {
        return _operationId;
      }
      set
      {
        __isset.operationId = true;
        this._operationId = value;
      }
    }

    public global::Apache.Hive.Service.Rpc.Thrift.TDBSqlSessionConf SessionConf
    {
      get
      {
        return _sessionConf;
      }
      set
      {
        __isset.sessionConf = true;
        this._sessionConf = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool catalogName;
      public bool schemaName;
      public bool tableName;
      public bool columnName;
      public bool getDirectResults;
      public bool runAsync;
      public bool operationId;
      public bool sessionConf;
    }

    public TGetColumnsReq()
    {
      this._runAsync = false;
      this.__isset.runAsync = true;
    }

    public TGetColumnsReq(global::Apache.Hive.Service.Rpc.Thrift.TSessionHandle sessionHandle) : this()
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
              if (field.Type == TType.String)
              {
                CatalogName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                SchemaName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                TableName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                ColumnName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 1281:
              if (field.Type == TType.Struct)
              {
                GetDirectResults = new global::Apache.Hive.Service.Rpc.Thrift.TSparkGetDirectResults();
                await GetDirectResults.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 1282:
              if (field.Type == TType.Bool)
              {
                RunAsync = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3329:
              if (field.Type == TType.Struct)
              {
                OperationId = new global::Apache.Hive.Service.Rpc.Thrift.THandleIdentifier();
                await OperationId.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3330:
              if (field.Type == TType.Struct)
              {
                SessionConf = new global::Apache.Hive.Service.Rpc.Thrift.TDBSqlSessionConf();
                await SessionConf.ReadAsync(iprot, cancellationToken);
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
        var tmp486 = new TStruct("TGetColumnsReq");
        await oprot.WriteStructBeginAsync(tmp486, cancellationToken);
        var tmp487 = new TField();
        if((SessionHandle != null))
        {
          tmp487.Name = "sessionHandle";
          tmp487.Type = TType.Struct;
          tmp487.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await SessionHandle.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((CatalogName != null) && __isset.catalogName)
        {
          tmp487.Name = "catalogName";
          tmp487.Type = TType.String;
          tmp487.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await oprot.WriteStringAsync(CatalogName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((SchemaName != null) && __isset.schemaName)
        {
          tmp487.Name = "schemaName";
          tmp487.Type = TType.String;
          tmp487.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await oprot.WriteStringAsync(SchemaName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((TableName != null) && __isset.tableName)
        {
          tmp487.Name = "tableName";
          tmp487.Type = TType.String;
          tmp487.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await oprot.WriteStringAsync(TableName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((ColumnName != null) && __isset.columnName)
        {
          tmp487.Name = "columnName";
          tmp487.Type = TType.String;
          tmp487.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await oprot.WriteStringAsync(ColumnName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((GetDirectResults != null) && __isset.getDirectResults)
        {
          tmp487.Name = "getDirectResults";
          tmp487.Type = TType.Struct;
          tmp487.ID = 1281;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await GetDirectResults.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.runAsync)
        {
          tmp487.Name = "runAsync";
          tmp487.Type = TType.Bool;
          tmp487.ID = 1282;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await oprot.WriteBoolAsync(RunAsync, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((OperationId != null) && __isset.operationId)
        {
          tmp487.Name = "operationId";
          tmp487.Type = TType.Struct;
          tmp487.ID = 3329;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await OperationId.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((SessionConf != null) && __isset.sessionConf)
        {
          tmp487.Name = "sessionConf";
          tmp487.Type = TType.Struct;
          tmp487.ID = 3330;
          await oprot.WriteFieldBeginAsync(tmp487, cancellationToken);
          await SessionConf.WriteAsync(oprot, cancellationToken);
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
      if (!(that is TGetColumnsReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(SessionHandle, other.SessionHandle)
        && ((__isset.catalogName == other.__isset.catalogName) && ((!__isset.catalogName) || (global::System.Object.Equals(CatalogName, other.CatalogName))))
        && ((__isset.schemaName == other.__isset.schemaName) && ((!__isset.schemaName) || (global::System.Object.Equals(SchemaName, other.SchemaName))))
        && ((__isset.tableName == other.__isset.tableName) && ((!__isset.tableName) || (global::System.Object.Equals(TableName, other.TableName))))
        && ((__isset.columnName == other.__isset.columnName) && ((!__isset.columnName) || (global::System.Object.Equals(ColumnName, other.ColumnName))))
        && ((__isset.getDirectResults == other.__isset.getDirectResults) && ((!__isset.getDirectResults) || (global::System.Object.Equals(GetDirectResults, other.GetDirectResults))))
        && ((__isset.runAsync == other.__isset.runAsync) && ((!__isset.runAsync) || (global::System.Object.Equals(RunAsync, other.RunAsync))))
        && ((__isset.operationId == other.__isset.operationId) && ((!__isset.operationId) || (global::System.Object.Equals(OperationId, other.OperationId))))
        && ((__isset.sessionConf == other.__isset.sessionConf) && ((!__isset.sessionConf) || (global::System.Object.Equals(SessionConf, other.SessionConf))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((SessionHandle != null))
        {
          hashcode = (hashcode * 397) + SessionHandle.GetHashCode();
        }
        if((CatalogName != null) && __isset.catalogName)
        {
          hashcode = (hashcode * 397) + CatalogName.GetHashCode();
        }
        if((SchemaName != null) && __isset.schemaName)
        {
          hashcode = (hashcode * 397) + SchemaName.GetHashCode();
        }
        if((TableName != null) && __isset.tableName)
        {
          hashcode = (hashcode * 397) + TableName.GetHashCode();
        }
        if((ColumnName != null) && __isset.columnName)
        {
          hashcode = (hashcode * 397) + ColumnName.GetHashCode();
        }
        if((GetDirectResults != null) && __isset.getDirectResults)
        {
          hashcode = (hashcode * 397) + GetDirectResults.GetHashCode();
        }
        if(__isset.runAsync)
        {
          hashcode = (hashcode * 397) + RunAsync.GetHashCode();
        }
        if((OperationId != null) && __isset.operationId)
        {
          hashcode = (hashcode * 397) + OperationId.GetHashCode();
        }
        if((SessionConf != null) && __isset.sessionConf)
        {
          hashcode = (hashcode * 397) + SessionConf.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp488 = new StringBuilder("TGetColumnsReq(");
      if((SessionHandle != null))
      {
        tmp488.Append(", SessionHandle: ");
        SessionHandle.ToString(tmp488);
      }
      if((CatalogName != null) && __isset.catalogName)
      {
        tmp488.Append(", CatalogName: ");
        CatalogName.ToString(tmp488);
      }
      if((SchemaName != null) && __isset.schemaName)
      {
        tmp488.Append(", SchemaName: ");
        SchemaName.ToString(tmp488);
      }
      if((TableName != null) && __isset.tableName)
      {
        tmp488.Append(", TableName: ");
        TableName.ToString(tmp488);
      }
      if((ColumnName != null) && __isset.columnName)
      {
        tmp488.Append(", ColumnName: ");
        ColumnName.ToString(tmp488);
      }
      if((GetDirectResults != null) && __isset.getDirectResults)
      {
        tmp488.Append(", GetDirectResults: ");
        GetDirectResults.ToString(tmp488);
      }
      if(__isset.runAsync)
      {
        tmp488.Append(", RunAsync: ");
        RunAsync.ToString(tmp488);
      }
      if((OperationId != null) && __isset.operationId)
      {
        tmp488.Append(", OperationId: ");
        OperationId.ToString(tmp488);
      }
      if((SessionConf != null) && __isset.sessionConf)
      {
        tmp488.Append(", SessionConf: ");
        SessionConf.ToString(tmp488);
      }
      tmp488.Append(')');
      return tmp488.ToString();
    }
  }

}
