using System;
using System.Linq;
using FitTinaV2.Models;

namespace FitTinaV2.Repositories
{
    public class UserRepository : IUserRepository
    {
        private FitTinaDbContext context;


        public UserRepository(FitTinaDbContext c)
        {
            context = c;
        }


        public IQueryable<User> Users
        {
            get
            {
                return context.Users;
            }
        }


        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }


        public User GetUserByName(string name)
        {
            return context.Users.Where(u => u.Name == name).SingleOrDefault();
        }
    }
}
