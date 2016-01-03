﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Events
{
    class AggregateRootStorage<TId> : IAggregateRootStorage<TId>
    {
        private readonly Dictionary<TId, List<object>> store = new Dictionary<TId, List<object>>();

        public void Append(TId id, IEnumerable<object> events)
        {
            List<object> aggregateRootEvents;
            if (!store.TryGetValue(id, out aggregateRootEvents))
            {
                aggregateRootEvents = new List<object>();
                store.Add(id, aggregateRootEvents);
            }

            aggregateRootEvents.AddRange(events);
        }

        public IEnumerable<object> this[TId id]
        {
            get { return store[id]; }
        }
    }
}
