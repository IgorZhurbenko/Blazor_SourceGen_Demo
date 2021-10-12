using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using SourceGeneration.Transport;

namespace SourceGeneration.Attributes.Web.Server.Actions.Models
{
    public class ProtoMethodImplementation
    {
        public string Name;
        public string ParameterSignature;
        public string ReturnTypeSignature;
        public CommunicationMethod From;
        public ProtoMethod ProtoMethod;
    }

    public class ProtoMethodInvocation
    {
        public string Name;
        public TypePrescription Parameter;
        public string ReturnType;
        public CommunicationMethod From;
        public ProtoMethod ProtoMethod;
    }


    public class CommunicationMethod
    {
        public IMethodSymbol Symbol;
        public ushort ID;
        public string DistinguishableName;
        public bool ParameterIsWebRequest;
        public INamedTypeSymbol EffectiveParameter;
        public bool AnyParameter;
        public TypePrescription PrescribedParameterType;
        public TypePrescription PrescribedReturnType;
        public bool ParameterIsEmptyForProtoCommunication;
    }

    public class CommunicationMethods
    {
        public List<CommunicationMethod> Items;
    }
}
