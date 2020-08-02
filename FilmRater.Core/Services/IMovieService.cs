using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Services
{
    public interface IMovieService
    {
        //get all movies
        IEnumerable<Movie> GetAll();

        //get a movie by id
        Movie Get(int id);

        //Add a movie
        Movie Add(Movie newMovie);

        //update a movie
        Movie Update(Movie updatedMovie);

        //delete a movie
        void Delete(Movie movie);

        IEnumerable<Movie> GetMovieForUser(int id);
    }
}
