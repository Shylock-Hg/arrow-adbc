/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.21.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;

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
  internal enum TCloudFetchDisabledReason
  {
    ARROW_SUPPORT = 0,
    CLOUD_FETCH_SUPPORT = 1,
    PROTOCOL_VERSION = 2,
    REGION_SUPPORT = 3,
    BLOCKLISTED_OPERATION = 4,
    SMALL_RESULT_SIZE = 5,
    CUSTOMER_STORAGE_SUPPORT = 6,
    UNKNOWN = 7,
    METADATA_OPERATION = 8,
  }
}
