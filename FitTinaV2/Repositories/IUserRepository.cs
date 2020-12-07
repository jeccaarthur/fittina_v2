using System;
using System.Linq;
using FitTinaV2.Models;

namespace FitTinaV2.Repositories
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void AddUser(User user);
        User GetUserByName(string name);
    }
}
