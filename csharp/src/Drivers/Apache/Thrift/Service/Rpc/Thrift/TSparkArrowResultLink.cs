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

  internal partial class TSparkArrowResultLink : TBase
  {
    private Dictionary<string, string> _httpHeaders;

    public string FileLink { get; set; }

    public long ExpiryTime { get; set; }

    public long StartRowOffset { get; set; }

    public long RowCount { get; set; }

    public long BytesNum { get; set; }

    public Dictionary<string, string> HttpHeaders
    {
      get
      {
        return _httpHeaders;
      }
      set
      {
        __isset.httpHeaders = true;
        this._httpHeaders = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool httpHeaders;
    }

    public TSparkArrowResultLink()
    {
    }

    public TSparkArrowResultLink(string fileLink, long expiryTime, long startRowOffset, long rowCount, long bytesNum) : this()
    {
      this.FileLink = fileLink;
      this.ExpiryTime = expiryTime;
      this.StartRowOffset = startRowOffset;
      this.RowCount = rowCount;
      this.BytesNum = bytesNum;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_fileLink = false;
        bool isset_expiryTime = false;
        bool isset_startRowOffset = false;
        bool isset_rowCount = false;
        bool isset_bytesNum = false;
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
                FileLink = await iprot.ReadStringAsync(cancellationToken);
                isset_fileLink = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                ExpiryTime = await iprot.ReadI64Async(cancellationToken);
                isset_expiryTime = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                StartRowOffset = await iprot.ReadI64Async(cancellationToken);
                isset_startRowOffset = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                RowCount = await iprot.ReadI64Async(cancellationToken);
                isset_rowCount = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                BytesNum = await iprot.ReadI64Async(cancellationToken);
                isset_bytesNum = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Map)
              {
                {
                  var _map199 = await iprot.ReadMapBeginAsync(cancellationToken);
                  HttpHeaders = new Dictionary<string, string>(_map199.Count);
                  for(int _i200 = 0; _i200 < _map199.Count; ++_i200)
                  {
                    string _key201;
                    string _val202;
                    _key201 = await iprot.ReadStringAsync(cancellationToken);
                    _val202 = await iprot.ReadStringAsync(cancellationToken);
                    HttpHeaders[_key201] = _val202;
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
        if (!isset_fileLink)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_expiryTime)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_startRowOffset)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_rowCount)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_bytesNum)
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
        var tmp203 = new TStruct("TSparkArrowResultLink");
        await oprot.WriteStructBeginAsync(tmp203, cancellationToken);
        var tmp204 = new TField();
        if((FileLink != null))
        {
          tmp204.Name = "fileLink";
          tmp204.Type = TType.String;
          tmp204.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp204, cancellationToken);
          await oprot.WriteStringAsync(FileLink, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        tmp204.Name = "expiryTime";
        tmp204.Type = TType.I64;
        tmp204.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp204, cancellationToken);
        await oprot.WriteI64Async(ExpiryTime, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp204.Name = "startRowOffset";
        tmp204.Type = TType.I64;
        tmp204.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp204, cancellationToken);
        await oprot.WriteI64Async(StartRowOffset, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp204.Name = "rowCount";
        tmp204.Type = TType.I64;
        tmp204.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp204, cancellationToken);
        await oprot.WriteI64Async(RowCount, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp204.Name = "bytesNum";
        tmp204.Type = TType.I64;
        tmp204.ID = 5;
        await oprot.WriteFieldBeginAsync(tmp204, cancellationToken);
        await oprot.WriteI64Async(BytesNum, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((HttpHeaders != null) && __isset.httpHeaders)
        {
          tmp204.Name = "httpHeaders";
          tmp204.Type = TType.Map;
          tmp204.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp204, cancellationToken);
          await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, HttpHeaders.Count), cancellationToken);
          foreach (string _iter205 in HttpHeaders.Keys)
          {
            await oprot.WriteStringAsync(_iter205, cancellationToken);
            await oprot.WriteStringAsync(HttpHeaders[_iter205], cancellationToken);
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
      if (!(that is TSparkArrowResultLink other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(FileLink, other.FileLink)
        && global::System.Object.Equals(ExpiryTime, other.ExpiryTime)
        && global::System.Object.Equals(StartRowOffset, other.StartRowOffset)
        && global::System.Object.Equals(RowCount, other.RowCount)
        && global::System.Object.Equals(BytesNum, other.BytesNum)
        && ((__isset.httpHeaders == other.__isset.httpHeaders) && ((!__isset.httpHeaders) || (TCollections.Equals(HttpHeaders, other.HttpHeaders))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((FileLink != null))
        {
          hashcode = (hashcode * 397) + FileLink.GetHashCode();
        }
        hashcode = (hashcode * 397) + ExpiryTime.GetHashCode();
        hashcode = (hashcode * 397) + StartRowOffset.GetHashCode();
        hashcode = (hashcode * 397) + RowCount.GetHashCode();
        hashcode = (hashcode * 397) + BytesNum.GetHashCode();
        if((HttpHeaders != null) && __isset.httpHeaders)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(HttpHeaders);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp206 = new StringBuilder("TSparkArrowResultLink(");
      if((FileLink != null))
      {
        tmp206.Append(", FileLink: ");
        FileLink.ToString(tmp206);
      }
      tmp206.Append(", ExpiryTime: ");
      ExpiryTime.ToString(tmp206);
      tmp206.Append(", StartRowOffset: ");
      StartRowOffset.ToString(tmp206);
      tmp206.Append(", RowCount: ");
      RowCount.ToString(tmp206);
      tmp206.Append(", BytesNum: ");
      BytesNum.ToString(tmp206);
      if((HttpHeaders != null) && __isset.httpHeaders)
      {
        tmp206.Append(", HttpHeaders: ");
        HttpHeaders.ToString(tmp206);
      }
      tmp206.Append(')');
      return tmp206.ToString();
    }
  }

}
