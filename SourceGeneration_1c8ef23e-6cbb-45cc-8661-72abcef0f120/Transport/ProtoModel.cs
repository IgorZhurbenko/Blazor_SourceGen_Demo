using SourceGeneration.Attributes.Data.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SourceGeneration.Transport
{
    public abstract class ProtoModel
    {
        public List<ProtoProperty> Properties = new List<ProtoProperty>();
        public string Name;
        public abstract string BaseFullSignature { get; }
        public string InterfaceConversionString => $"ToProto";

        public bool IsCollectionDubler;
        public bool IsPrimitive;
        public abstract Derived Base { get; }
    }

    public class ProtoModel<T> : ProtoModel
        where T : Derived
    {
        public T From;
        public override string BaseFullSignature => From?.FullSignature;

        public override Derived Base => From;
    }

    public class ProtoProperty
    {
        public string Name;
        public string ProtoType;
        public bool IsRepeated;
        public bool IsMessage;
        public ushort Order = 1;
        public Member From;

        public string DeclarationString
        {
            get
            {
                return $"{(IsRepeated ? "repeated" : "")} {ProtoType} {Name} = {Order};";
            }
        }
    }

    public class CreatedProtoModels
    {
        public List<ProtoModel> Items;
    }

    public static class Extesions
    {

    }
}
