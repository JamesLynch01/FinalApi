using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public int Duration { get; set; }

        public string Genres { get; set; }

        public string DirectorName { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
