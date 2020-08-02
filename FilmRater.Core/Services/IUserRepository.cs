using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Services
{
    public interface IUserRepository
    {
        //create
        User Add(User user);

        //Read
        User Get(int id);

        //update
        User Update(User user);

        //Delete
        void Remove(User user);

        //List
        IEnumerable<User> GetAll();
    }
}
