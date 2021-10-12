using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Attributes.Web.Server.Actions
{
    public class ProcessServerRequest : CodeGenerationRail.CodeGenerationTarget
    {
        public const string TemplatesLocation = "Attributes/Web.Server/Actions";
    }

    public class NotOpenAttribute : Attribute
    {
    }

    public class AllowUnauthorised : Attribute
    {
        
    }
}
