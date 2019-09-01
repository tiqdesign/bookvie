using System;
using System.Collections.Generic;

namespace BookvieL.Functions
{
    public partial class Movies
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Genres { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Runtime { get; set; }
        public int ReleatedBookId { get; set; }

        public Books ReleatedBook { get; set; }
    }
}
