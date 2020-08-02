using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Services
{
    public interface IUserService
    {
        //Add
        User Add(User user);

        //Get
        User Get(int id);

        //get all
        IEnumerable<User> GetAll();

        //delete
        void Remove(User user);

        //update
        User Update(User updatedUser);
    }
}

