using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Systems.Pas.Data.Books
{
    public class BookRegistered
    {
        public readonly BookId Id;
        public readonly string Title;
        public readonly string Isbn;

        public BookRegistered(BookId id, string title, string isbn)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
        }
    }

    public class BookLent
    {
        public readonly BookId Id;
        public readonly string Borrower;
        public readonly DateTime Date;
        public readonly TimeSpan ExpectedDuration;

        public BookLent(BookId id, string borrower, DateTime date,
               TimeSpan expectedDuration)
        {
            Id = id;
            Borrower = borrower;
            Date = date;
            ExpectedDuration = expectedDuration;
        }
    }

    public class BookReturned
    {
        public readonly BookId Id;
        public readonly string By;
        public readonly TimeSpan After;
        public readonly bool Late;

        public BookReturned(BookId id, string @by, TimeSpan after, bool late)
        {
            Id = id;
            By = by;
            After = after;
            Late = late;
        }
    }
}
