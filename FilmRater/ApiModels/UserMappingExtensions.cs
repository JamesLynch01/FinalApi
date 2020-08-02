using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmRater.ApiModels
{
    public static class UserMappingExtensions
    {
        public static UserModel ToApiModel(this User item)
        {
            return new UserModel
            {
                Id = item.id,
                Name = item.userName,

            };
        }
        public static User ToDomainModel(this UserModel userModel)
        {
            return new User
            {
                id = userModel.Id,
                userName = userModel.Name,
            };
        }

        public static IEnumerable<UserModel> ToApiModels(this IEnumerable<User> items)
        {
            return items.Select(a => a.ToApiModel());
        }

        public static IEnumerable<User> ToDomainModels(this IEnumerable<UserModel> items)
        {
            return items.Select(a => a.ToDomainModel());
        }
    }
}
