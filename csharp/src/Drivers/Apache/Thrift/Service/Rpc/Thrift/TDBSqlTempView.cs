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

  internal partial class TDBSqlTempView : TBase
  {
    private string _name;
    private string _sqlStatement;
    private Dictionary<string, string> _properties;
    private string _viewSchema;

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.@name = true;
        this._name = value;
      }
    }

    public string SqlStatement
    {
      get
      {
        return _sqlStatement;
      }
      set
      {
        __isset.sqlStatement = true;
        this._sqlStatement = value;
      }
    }

    public Dictionary<string, string> Properties
    {
      get
      {
        return _properties;
      }
      set
      {
        __isset.@properties = true;
        this._properties = value;
      }
    }

    public string ViewSchema
    {
      get
      {
        return _viewSchema;
      }
      set
      {
        __isset.viewSchema = true;
        this._viewSchema = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool @name;
      public bool sqlStatement;
      public bool @properties;
      public bool viewSchema;
    }

    public TDBSqlTempView()
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
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                SqlStatement = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Map)
              {
                {
                  var _map241 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Properties = new Dictionary<string, string>(_map241.Count);
                  for(int _i242 = 0; _i242 < _map241.Count; ++_i242)
                  {
                    string _key243;
                    string _val244;
                    _key243 = await iprot.ReadStringAsync(cancellationToken);
                    _val244 = await iprot.ReadStringAsync(cancellationToken);
                    Properties[_key243] = _val244;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                ViewSchema = await iprot.ReadStringAsync(cancellationToken);
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
        var tmp245 = new TStruct("TDBSqlTempView");
        await oprot.WriteStructBeginAsync(tmp245, cancellationToken);
        var tmp246 = new TField();
        if((Name != null) && __isset.@name)
        {
          tmp246.Name = "name";
          tmp246.Type = TType.String;
          tmp246.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp246, cancellationToken);
          await oprot.WriteStringAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((SqlStatement != null) && __isset.sqlStatement)
        {
          tmp246.Name = "sqlStatement";
          tmp246.Type = TType.String;
          tmp246.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp246, cancellationToken);
          await oprot.WriteStringAsync(SqlStatement, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Properties != null) && __isset.@properties)
        {
          tmp246.Name = "properties";
          tmp246.Type = TType.Map;
          tmp246.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp246, cancellationToken);
          await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Properties.Count), cancellationToken);
          foreach (string _iter247 in Properties.Keys)
          {
            await oprot.WriteStringAsync(_iter247, cancellationToken);
            await oprot.WriteStringAsync(Properties[_iter247], cancellationToken);
          }
          await oprot.WriteMapEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((ViewSchema != null) && __isset.viewSchema)
        {
          tmp246.Name = "viewSchema";
          tmp246.Type = TType.String;
          tmp246.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp246, cancellationToken);
          await oprot.WriteStringAsync(ViewSchema, cancellationToken);
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
      if (!(that is TDBSqlTempView other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.@name == other.__isset.@name) && ((!__isset.@name) || (global::System.Object.Equals(Name, other.Name))))
        && ((__isset.sqlStatement == other.__isset.sqlStatement) && ((!__isset.sqlStatement) || (global::System.Object.Equals(SqlStatement, other.SqlStatement))))
        && ((__isset.@properties == other.__isset.@properties) && ((!__isset.@properties) || (TCollections.Equals(Properties, other.Properties))))
        && ((__isset.viewSchema == other.__isset.viewSchema) && ((!__isset.viewSchema) || (global::System.Object.Equals(ViewSchema, other.ViewSchema))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Name != null) && __isset.@name)
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if((SqlStatement != null) && __isset.sqlStatement)
        {
          hashcode = (hashcode * 397) + SqlStatement.GetHashCode();
        }
        if((Properties != null) && __isset.@properties)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Properties);
        }
        if((ViewSchema != null) && __isset.viewSchema)
        {
          hashcode = (hashcode * 397) + ViewSchema.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp248 = new StringBuilder("TDBSqlTempView(");
      int tmp249 = 0;
      if((Name != null) && __isset.@name)
      {
        if(0 < tmp249++) { tmp248.Append(", "); }
        tmp248.Append("Name: ");
        Name.ToString(tmp248);
      }
      if((SqlStatement != null) && __isset.sqlStatement)
      {
        if(0 < tmp249++) { tmp248.Append(", "); }
        tmp248.Append("SqlStatement: ");
        SqlStatement.ToString(tmp248);
      }
      if((Properties != null) && __isset.@properties)
      {
        if(0 < tmp249++) { tmp248.Append(", "); }
        tmp248.Append("Properties: ");
        Properties.ToString(tmp248);
      }
      if((ViewSchema != null) && __isset.viewSchema)
      {
        if(0 < tmp249++) { tmp248.Append(", "); }
        tmp248.Append("ViewSchema: ");
        ViewSchema.ToString(tmp248);
      }
      tmp248.Append(')');
      return tmp248.ToString();
    }
  }

}
