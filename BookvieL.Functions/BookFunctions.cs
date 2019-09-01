using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BookvieL.Functions
{
    public  class BookFunctions
    {
        private static BookFunctions _func;
        private BookFunctions()
        {

        }
        public static BookFunctions getInstance()
        {
            if (_func == null)
            {
                _func = new BookFunctions();
                
            }
            return _func;
        }

        private static readonly BookvieContext _context = new BookvieContext();

        public List<Books> GetAllBooks()
        {
            return _context.Books.ToList();
        }


    }
}
