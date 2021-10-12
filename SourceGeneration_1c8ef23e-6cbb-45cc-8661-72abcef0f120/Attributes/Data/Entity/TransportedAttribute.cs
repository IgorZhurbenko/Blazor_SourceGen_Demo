using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Attributes.Data
{
    public class TransportedAttribute : CodeGenerationRail.CodeGenerationTarget
    {
        public const string TemplatesLocation = "Attributes/Data/Entity";
        public const string TargetDbContext = "Data.ApplicationDbContext";
    }
}
