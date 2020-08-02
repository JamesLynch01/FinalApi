using FilmRater.Core.Models;
using FilmRater.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FilmRater.Infrastructure.Database
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _dbContext;

        public MovieRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Movie Add(Movie movie)
        {
            _dbContext.Add(movie);
            _dbContext.SaveChanges();
            return movie;
        }

        public Movie Get(int id)
        {
            return _dbContext.Movies
                .SingleOrDefault(m => m.Id == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _dbContext.Movies
                .Include(m => m.User);
        }

        public IEnumerable<Movie> GetMovieForUser(int id)
        {
            return _dbContext.Movies
                .Include(m => m.User)
                .Where(m => m.UserId == id);
        }


        public void Remove(Movie movie)
        {
            _dbContext.Movies.Remove(movie);
            _dbContext.SaveChanges();
        }

        public Movie Update(Movie movie)
        {
            var currentMovie = _dbContext.Movies.Find(movie.Id);
            if (currentMovie == null) return null;
            _dbContext.Entry(currentMovie).CurrentValues.SetValues(movie);
            _dbContext.Movies.Update(currentMovie);
            _dbContext.SaveChanges();
            return currentMovie;
        }
    }
}
