using FilmRater.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmRater.Core.Services
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserServices(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Add(User user)
        {
            _userRepo.Add(user);
            return user;
        }

        public User Get(int id)
        {
            return _userRepo.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepo.GetAll();
        }

        public void Remove(User user)
        {
            _userRepo.Remove(user);
        }

        public User Update(User updatedUser)
        {
            var user = _userRepo.Update(updatedUser);
            return user;
        }
    }
}
