using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Books
{
    public class BookState
    {
        public BookId Id { get; set; }
        public string Title { get; set; }
        public bool Lent { get; set; }
    }
}
