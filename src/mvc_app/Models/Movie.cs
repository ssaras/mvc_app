using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_app.Models
{
    public class Movie
    {
        public int ID { get; set; } //required by the DB for the primary key
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
