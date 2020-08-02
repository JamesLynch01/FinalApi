using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRates;

        public MovieService(IMovieRepository movieRates)
        {
            _movieRates = movieRates;
        }
        public Movie Add(Movie newMovie)
        {
            _movieRates.Add(newMovie);
            return newMovie;
        }

        public void Delete(Movie movie)
        {
            _movieRates.Remove(movie);
        }

        public Movie Get(int id)
        {
            return _movieRates.Get(id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _movieRates.GetAll();
        }

        public IEnumerable<Movie> GetMovieForUser(int id)
        {
            return _movieRates.GetMovieForUser(id);
        }

        public Movie Update(Movie updatedMovie)
        {
            var movie = _movieRates.Update(updatedMovie);
            return movie;
        }
    }
}
