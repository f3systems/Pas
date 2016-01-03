﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Events
{
    public class EventStorage : IEventStorage, IDisposable
    {
        private readonly Dictionary<Type, dynamic> stores = new Dictionary<Type, dynamic>();

        public IAggregateRootStorage<TId> GetAggregateRootStorage<TAggregateRoot, TId>()
            where TAggregateRoot : AggregateRoot<TId>
        {
            dynamic store;
            if (!stores.TryGetValue(typeof(TAggregateRoot), out store))
            {
                store = new AggregateRootStorage<TId>();
                stores.Add(typeof(TAggregateRoot), store);
            }
            return store;
        }

        public void Dispose()
        {
            stores.Clear();
        }
    }
}
