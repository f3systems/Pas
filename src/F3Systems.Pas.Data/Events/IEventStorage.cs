using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Events
{
    public interface IEventStorage
    {
        IAggregateRootStorage<TId> GetAggregateRootStorage<TAggregateRoot, TId>()
            where TAggregateRoot : AggregateRoot<TId>;
    }
}
