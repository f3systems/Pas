using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Books
{
    public interface IBookRepository
    {
        void Add(Book book);
        Book this[BookId id] { get; }
    }
}
