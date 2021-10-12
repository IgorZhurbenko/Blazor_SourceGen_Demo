using Data.Entities.DataHolders.Persons;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Entities.DataHolders
{
    public partial class Employee : Person
    {
        public Employee Mentor { get; set; }
        public ICollection<Good> ResponsibleForGoods { get; set; }
    } 
}