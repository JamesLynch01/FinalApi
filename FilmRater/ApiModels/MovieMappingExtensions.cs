using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmRater.ApiModels
{
    public static class MovieMappingExtensions
    {
        public static MovieModel ToApiModel(this Movie item)
        {
            return new MovieModel
            {
                Id = item.Id,
                Title = item.Title,
                Rating = item.Rating,
                Duration = item.Duration,
                Genres = item.Genres,
                DirectorName = item.DirectorName,
                User = item.User.userName,
                UserId = item.UserId,

            };
        }
        public static Movie ToDomainModel(this MovieModel movieModel)
        {
            return new Movie
            {
                Id = movieModel.Id,
                Title = movieModel.Title,
                Rating = movieModel.Rating,
                Duration = movieModel.Duration,
                Genres = movieModel.Genres,
                DirectorName = movieModel.DirectorName,
                UserId = movieModel.UserId,
            };
        }

        public static IEnumerable<MovieModel> ToApiModels(this IEnumerable<Movie> items)
        {
            return items.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Movie> ToDomainModels(this IEnumerable<MovieModel> items)
        {
            return items.Select(a => a.ToDomainModel());
        }
    }
}
