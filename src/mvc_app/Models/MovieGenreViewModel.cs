using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace mvc_app.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}
