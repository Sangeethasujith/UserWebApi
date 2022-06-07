using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Data.Repository
{
    public class UserRepository : IUsers
    { 
    //{
    //    List<User> userList = new List<User>
    //    {
    //        new User{Id=1,Username="Sangeetha"},
    //        new User{Id=2,Username="Sanjana"},
    //        new User{Id=3,Username="Ashok"}
    //    };
        UserContext _userContext;

        public UserRepository(UserContext context)
        {
            _userContext = context;
        }
        public void Add(User user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
        }

        public void Delete(User user)
        {
            _userContext.Users.Remove(user);
            _userContext.SaveChanges();

        }

        public List<User> GetAllUsers()
        {
            return _userContext.Users.ToList();
        }

        public User GetUser(int id)
        {
            return _userContext.Users.FirstOrDefault(u=>u.Id==id);
        }

        public void Update(User user,User entity)
        {
            user.Username=entity.Username;
            _userContext.SaveChanges();
        }
    }
}
