using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Data.Repository
{
    public class UserRepository : IUsers
    {
        List<User> userList = new List<User>
        {
            new User{Id=1,Username="Sangeetha"},
            new User{Id=2,Username="Sanjana"},
            new User{Id=3,Username="Ashok"}
        };
        public List<User> GetAllUsers()
        {
            return userList;
        }

        public User GetUser(int id)
        {
            return userList.Find(x => x.Id == id);
        }
    }
}
