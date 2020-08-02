using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmRater.ApiModels
{
    public class MovieModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public int Duration { get; set; }

        public string Genres { get; set; }

        public string DirectorName { get; set; }

        public int UserId { get; set; }

        public string User { get; set; }
    }
}
