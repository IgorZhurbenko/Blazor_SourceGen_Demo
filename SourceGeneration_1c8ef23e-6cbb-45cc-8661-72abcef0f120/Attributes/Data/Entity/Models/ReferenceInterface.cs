using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public class ReferenceInterface: Derived<CreatedModelInterface>, IClassInterface
    {
        public ReferenceModel DefaultImplementation;
    }

    public class CreatedReferenceInterfaces
    {
        public IEnumerable<ReferenceInterface> Items;
        public ReferenceInterface BaseInterface;
    }
}
