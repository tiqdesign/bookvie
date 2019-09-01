using System;
using System.Collections.Generic;

namespace BookvieL.Functions
{
    public partial class Books
    {
        public Books()
        {
            Movies = new HashSet<Movies>();
        }

        public int Id { get; set; }
        public string Isbn { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public string BookUrl { get; set; }

        public ICollection<Movies> Movies { get; set; }
    }
}
