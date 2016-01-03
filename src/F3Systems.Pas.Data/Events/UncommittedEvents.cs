using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Events
{
    internal class UncommittedEvents : IUncommittedEvents
    {
        private readonly List<object> events = new List<object>();

        public void Append(object @event)
        {
            events.Add(@event);
        }

        IEnumerator<object> IEnumerable<object>.GetEnumerator()
        {
            return events.GetEnumerator();
        }

        public bool HasEvents
        {
            get { return events.Count != 0; }
        }

        void IUncommittedEvents.Commit()
        {
            events.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return events.GetEnumerator();
        }
    }
}