// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee
{
    public class EmployeeReference : Communication.Models.Reference<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>, Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference
    {
        public override bool Equals(object other)
        {
            return other is IEmployeeReference rightType && rightType.ID == ID;
        }
    }
}