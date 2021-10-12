using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public abstract class Derived
    {
        public string Name;
        public string FileWithDefinitionLocation;
        public string Namespace;
        public Representation Representation;
        public virtual string FullSignature => $"{Namespace}.{Name}";
        public IEnumerable<Member> GettablesSettablesIntersect => Gettables.Union(Settables.Where(s => !Gettables.Any(g => g.Name == s.Name)));
        public IEnumerable<Member> Gettables => FieldsAndproperties.Where(fp => fp.Gettable);
        public IEnumerable<Member> Settables => FieldsAndproperties.Where(fp => fp.Settable);
        public IEnumerable<Member> FieldsAndproperties = new List<Member>();

        public override bool Equals(object obj)
        {
            return obj is Derived dc && dc.FullSignature == FullSignature;
        }

    }
    public class Derived<TBase> : Derived
    {
        public TBase Base;
    }
}
