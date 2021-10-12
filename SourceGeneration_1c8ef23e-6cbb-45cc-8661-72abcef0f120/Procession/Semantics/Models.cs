using Microsoft.CodeAnalysis;
using SourceGeneration.Attributes.Data.Entity.Models;
using SourceGeneration.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Procession.Semantics
{
    public static class ModelsFunctions
    {
        public static string ComposeLocationForModel(this Entity transportable)
        {
            var e = transportable;
            return $"Communication/Models/{e.Symbol.AllBaseClassesHierarchy().Reverse().Select(bc => bc.Name.ToPlural()).Skip(2).Join("/").MustNotEndWith("/").MustNotStartWith("/")}/{e.Name}/I{e.Symbol.Name}Model.cs";
        }

        public static string ComposeNamespaceFromLocationForModel(string location)
        {
            return location.Split('/').TakeWhile(s => !s.EndsWith(".cs")).Join(".").MustNotEndWith(".").Replace("..", ".");
        }
    }
}
