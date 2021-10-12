using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication.Exceptions
{
    public class HandledException : Exception
    {
        public HandledException(string message) : base(message)
        {
            
        }
        public HandledException() : base()
        { 
        }
    }

    public class InvalidArgumentHandledException : HandledException
    {
        public InvalidArgumentHandledException(string message) : base(message)
        {
        }
    }

    public class InvalidSessionKeyHandledException : UnauthorisedHandledException
    {   
        public InvalidSessionKeyHandledException(string message) : base(message)
        {
        }
    }

    public class InvalidCredentialsHadledException : HandledException
    {
        public InvalidCredentialsHadledException() : base("Invalid credentials supplied.")
        {
        }

        public InvalidCredentialsHadledException(string message) : base(message)
        {
        }
    }

    public class UnauthorisedHandledException : HandledException
    {
        public UnauthorisedHandledException()
        {
        }

        public UnauthorisedHandledException(string message) : base(message)
        {
        }
    }
}