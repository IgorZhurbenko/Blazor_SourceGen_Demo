using CodeGenerationRail;
using SourceGeneration.Attributes.Data.Entity;
using System;

namespace CodeGenerationRail {  }

namespace SourceGeneration.Attributes.Data
{
    public class EntityAttribute : System.Attribute
    {
        
    }

    [System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field)]
    public class ExcludeFromModels : System.Attribute
    {
        public readonly string[] Models;

        public ExcludeFromModels(params string[] models)
        {
            Models = models;
        }
    }

    
}
