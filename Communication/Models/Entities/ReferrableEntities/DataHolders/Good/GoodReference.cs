// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.Entities.ReferrableEntities.DataHolders.Good
{
    public class GoodReference : Communication.Models.Reference<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodModel>, Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference
    {
        public override bool Equals(object other)
        {
            return other is IGoodReference rightType && rightType.ID == ID;
        }
    }
}