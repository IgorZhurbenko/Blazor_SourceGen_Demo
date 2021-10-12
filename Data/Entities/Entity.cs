using SourceGeneration.Attributes.Data;
using System;
using System.Linq.Expressions;

namespace Data.Entities
{
    [Entity]
    public abstract partial class Entity : Transported
    {
        public uint ID { get; set; }
        public virtual void BeforeSave()
        { 
        }

    }
}