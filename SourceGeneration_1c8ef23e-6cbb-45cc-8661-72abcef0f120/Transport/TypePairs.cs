using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Transport
{
    public class TypePair
    {
        public string ProtobufType;
        public string DotNetType;
        public string ProtoDotnetAnalogue;
        public Func<string, string> NetToProto;
        public Func<string, string> ProtoToNet;
        public string DefaultAcceptableValue;
        public string DotnetShortName;
    }

    public static class TypesConversion
    {
        public static readonly IReadOnlyList<TypePair> TypePairs = new List<TypePair>
        {
            new TypePair { DotNetType = "System.DateTime", ProtobufType="google.protobuf.Timestamp", ProtoDotnetAnalogue = "Google.Protobuf.WellKnownTypes.Timestamp" },
            new TypePair { DotNetType = "System.String", ProtobufType="string", ProtoDotnetAnalogue = "System.String", DefaultAcceptableValue = "\"\"", DotnetShortName = "string" },
            new TypePair { DotNetType = "System.Int32", ProtobufType="int32", ProtoDotnetAnalogue = "System.Int32" , DotnetShortName = "int"},
            new TypePair { DotNetType = "System.Int64", ProtobufType="int64", ProtoDotnetAnalogue = "System.Int64"  , DotnetShortName = "long"},
            new TypePair { DotNetType = "System.UInt32", ProtobufType="uint32", ProtoDotnetAnalogue = "System.UInt32", DotnetShortName = "uint"  },
            new TypePair { DotNetType = "System.UInt64", ProtobufType="uint64", ProtoDotnetAnalogue = "System.UInt64"  , DotnetShortName = "ulong"},
            new TypePair { DotNetType = "System.Boolean", ProtobufType="bool", ProtoDotnetAnalogue = "System.Boolean", DotnetShortName = "bool"  },
            new TypePair { DotNetType = "System.Single", ProtobufType="float", ProtoDotnetAnalogue = "System.Single", DotnetShortName = "float" },
            new TypePair { DotNetType = "System.Double", ProtobufType="double", ProtoDotnetAnalogue = "System.Double", DotnetShortName = "double" }
        };

        public static readonly IReadOnlyList<TypePair> SpecialGoogleTypes = new List<TypePair>
        { new TypePair { DotNetType = "System.DateTime", ProtobufType = "google.protobuf.Timestamp", ProtoDotnetAnalogue = "Google.Protobuf.WellKnownTypes.Timestamp", NetToProto = dt => $"Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime({dt}.ToUniversalTime())", ProtoToNet = ts => $"{ts}.ToDateTime().ToLocalTime()" } };

        public static string ToProtoType(string dotnetTypeFullSignature)
        {
            return TypePairs.FirstOrDefault(tp => tp.DotNetType.EndsWith(dotnetTypeFullSignature))?.ProtobufType;   
        }
    }
}
