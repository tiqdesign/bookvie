using System;
using System.Collections.Generic;
using System.Text;

namespace BookvieL.Functions.Templates
{
    public static class ApiTemplates
    {
        
        public static class MovieTemplates
        {
            public const string GetMovieByBookId = "GetMovieWithBookId/{bookid}";
        }

        public static class BookTemplates
        {
            public const string GetAllBooks = "GetAllBooks";
        }
    }
}
