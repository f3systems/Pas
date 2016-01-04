using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F3Systems.Pas.Data.Events;

namespace F3Systems.Pas.Data.Books
{
    public class LateReturnNotifier : Handles<BookReturned>
    {
        public void Handle(BookReturned @event)
        {
            if (@event.Late)
            {
                Console.WriteLine("{0} was late", @event.By);
            }
        }
    }
}
