using Data.Entities;
using Data.Entities.DataHolders.AccountingUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.CustomCommunicationContracts
{
    public class StartSessionRequest : Transported
    {
        public string Login { get; }
        public string Password { get; }
    }

    public partial class StartSessionResponse : Transported
    {
        public string SessionKey { get; }
        public User User { get; }
        public Permissions Permissions { get; }
    }

    public class VerifySessionRequest : Transported
    {
        public string SessionKey { get; }
        public uint SessionUserID { get; }
    }
}