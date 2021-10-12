using System;

namespace SourceGeneration.Attributes.Web.Server.Actions
{
    public abstract class Caching : Attribute
    {
        readonly float ExpirationPeriodSeconds;
        readonly ushort StoreCapacity;

        protected Caching(float expirationPeriodSeconds, ushort storeCapacity)
        {
            ExpirationPeriodSeconds = expirationPeriodSeconds;
            StoreCapacity = storeCapacity;
        }
    }

    public class ClientCaching : Caching
    {
        public ClientCaching(float expirationPeriodSeconds, ushort storeCapacity) : base(expirationPeriodSeconds, storeCapacity)
        {
        }
    }

    public class ServerCaching : Caching
    {
        public ServerCaching(float expirationPeriodSeconds, ushort storeCapacity) : base(expirationPeriodSeconds, storeCapacity)
        {
        }
    }
}
