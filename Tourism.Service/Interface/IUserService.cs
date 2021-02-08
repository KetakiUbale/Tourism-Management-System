using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetById(int id);
        User GetByEmail(string email);
        User AddUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(int userId);


    }
}