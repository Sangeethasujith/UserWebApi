using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
//using UserApi.Models;

namespace Data.Repository
{
    public interface IUsers
    {
        List<User> GetAllUsers();
        public User GetUser(int id);
         void Add(User user);
        void Update(User user, User entity);
        void Delete(User user);
    }
}
