using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.models
{
    public class Movie
    {
        public int ID { get; set; } //Primary Key
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

