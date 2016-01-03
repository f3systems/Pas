using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Events
{
    public interface Handles<in T>
    {
        void Handle(T @event);
    }
}
