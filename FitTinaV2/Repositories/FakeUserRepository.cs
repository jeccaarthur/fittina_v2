using System;
using System.Collections.Generic;
using System.Linq;
using FitTinaV2.Models;

namespace FitTinaV2.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private List<User> users = new List<User>();

        public IQueryable<User> Users
        {
            get
            {
                return users.AsQueryable<User>();
            }
        }

        public void AddUser(User user)
        {
            // simulate ai pk
            user.UserID = users.Count;

            // add user to list
            users.Add(user);
        }

        public User GetUserByName(string name)
        {
            User user = users.Find(u => u.Name == name);

            return user;
        }
    }
}
