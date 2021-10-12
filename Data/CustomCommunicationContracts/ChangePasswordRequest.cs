using Data.Entities.DataHolders.AccountingUsers;

namespace Data.CustomCommunicationContracts
{
    public class ChangePasswordRequest : Transported
    {
        public string OldPassword { get; }
        public string NewPassword { get; }
    }
    
    
}