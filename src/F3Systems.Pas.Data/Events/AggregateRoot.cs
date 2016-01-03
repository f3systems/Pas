using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Events
{
    public abstract class AggregateRoot<TId>
    {
        private readonly UncommittedEvents uncommittedEvents = new UncommittedEvents();

        protected void Replay(IEnumerable<object> events)
        {
            dynamic me = this;
            foreach (var @event in events)
                me.Apply(@event);
        }

        protected void Append(object @event)
        {
            uncommittedEvents.Append(@event);
        }

        public abstract TId Id { get; }

        internal IUncommittedEvents UncommittedEvents
        {
            get { return uncommittedEvents; }
        }
    }
}
