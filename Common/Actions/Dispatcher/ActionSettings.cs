using System;
using System.Threading.Tasks;

namespace Common.Actions
{
    public class ActionSettings<TParameter>
    {
        public ushort ID;
        public decimal CacheValidityPeriodSeconds;
        public ushort ActionsStoreCapacity;
        public string Name;
        public Func<TParameter, TParameter, bool> CompareParameters = (o1, o2) => o1.Equals(o2);
    }
    public class AsynchronousActionSettings<TParameter, TResult> : ActionSettings<TParameter>
    {
        public Func<TParameter, Task<TResult>> MainAction;
    }
    public class SynchronousActionSettings<TParameter, TResult> : ActionSettings<TParameter>
    {
        public Func<TParameter, TResult> MainAction;
    }

}
