// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.Entities.ReferrableEntities.DataHolders.User
{
    public class UserReference : Communication.Models.Reference<Communication.Models.Entities.ReferrableEntities.DataHolders.User.IUserModel>, Communication.Models.Entities.ReferrableEntities.DataHolders.User.IUserReference
    {
        public override bool Equals(object other)
        {
            return other is IUserReference rightType && rightType.ID == ID;
        }
    }
}