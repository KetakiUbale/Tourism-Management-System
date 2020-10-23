using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Service
{
    
    
        public interface IRoleService
        {
            IEnumerable<Role> GetAllUsers();
            Role GetById(int id);
            //User GetByEmail(string email);
            int AddRole(Role Role);


        }
    
}
