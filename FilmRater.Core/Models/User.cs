using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Models
{
        public class User
        {
            public int id { get; set; }

            public string userName { get; set; }

            public ICollection<Movie> Movies { get; set; }

            //future plans for this project includes other forms
            //of entrainment, like books, video games, etc.
            //for now, I just doing Movies.
            //public ICollection<Book> Books { get; set; }
        }
    
}
