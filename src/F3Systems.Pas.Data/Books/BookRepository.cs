using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F3Systems.Pas.Data.Persistence;

namespace F3Systems.Pas.Data.Books
{
    internal class BookRepository : Repository<BookId, Book>, IBookRepository
    {
        protected override Book CreateInstance(BookId id, IEnumerable<object> events)
        {
            return new Book(id, events);
        }
    }
}
