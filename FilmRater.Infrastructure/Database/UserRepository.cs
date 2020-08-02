using FilmRater.Core.Models;
using FilmRater.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilmRater.Infrastructure.Database
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Add(User user)
        {
            _dbContext.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User Get(int id)
        {
            return _dbContext.Users
                .Include(a => a.Movies)
                .SingleOrDefault(u => u.id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users
                .Include(a => a.Movies);
        }

        public void Remove(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public User Update(User user)
        {
            var currentUser = _dbContext.Users.Find(user.id);
            if (currentUser == null) return null;
            _dbContext.Entry(currentUser).CurrentValues.SetValues(user);
            _dbContext.Users.Update(currentUser);
            _dbContext.SaveChanges();
            return currentUser;
        }
    }
}
