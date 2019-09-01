using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookvieL.Functions
{
    public class MovieFunctions
    {
        private readonly BookvieContext _context = new BookvieContext();
        public static MovieFunctions _func;
        private MovieFunctions()
        {

        }

        public static MovieFunctions getInstance()
        {
            if (_func == null)
            {
                _func = new MovieFunctions();
            }

            return _func;
        }


        public Movies GetMovieWithBookID(int bookid)
        {
            return _context.Movies.Where(m => m.ReleatedBookId == bookid).First();
        }
    }
}
