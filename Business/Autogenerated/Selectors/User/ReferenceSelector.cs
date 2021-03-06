// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.ProtoModels;
using System.Linq;
using System;
using System.Collections.Generic;
using Data;
using Data.Entities.DataHolders.AccountingUsers;
using Communication.Models.Entities.ReferrableEntities.DataHolders.User;
using System.Linq.Expressions;
namespace Business.Selectors
{
    public static partial class UserSelectors
    {
        public static readonly Expression<Func<User, IUserReference>> ReferenceSelector = e1 => new Communication.Models.Entities.ReferrableEntities.DataHolders.User.UserReference{ID = e1.ID, Representation = e1.Representation};
    }
}