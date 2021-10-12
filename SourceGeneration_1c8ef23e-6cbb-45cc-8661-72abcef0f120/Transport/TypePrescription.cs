using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Transport
{
    public class TypePrescription   
    {
        public string PureDotnetType;
        public string ProtoMessageType;
        public bool NeedsConversionFromProtoToNet;
        public bool NeedsConversionFromNetToProto;
        public string UsableTypeForInvoker;
        public bool IsPrimitive;
        public string ProtoDotNetAnalogue;
    }

    public class TypePrescriptions
    {
        public List<TypePrescription> Items;
    }
}
