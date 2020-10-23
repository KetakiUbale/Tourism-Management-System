using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Service
{
    public interface IUserRoleService
    {
        IEnumerable<UserRole> GetAllUsers();
        UserRole GetById(int id);
        
        int AddUserRole(UserRole UserRole);
    }
}
