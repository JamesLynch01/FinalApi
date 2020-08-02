using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Services
{
    public interface IMovieRepository
    {
        //create
        Movie Add(Movie movie);

        //Read
        Movie Get(int id);

        //Update
        Movie Update(Movie movie);

        //Delete
        void Remove(Movie movie);

        //List
        IEnumerable<Movie> GetAll();

        //GetMovie
        IEnumerable<Movie> GetMovieForUser(int id);
    }
}
