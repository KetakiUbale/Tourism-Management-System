using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;
using Tourism.Persistence;
using Tourism.Service.Interface;

namespace Tourism.Service
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<Role> GetAllUsers()
        {

            return this._unitOfWork.RoleRepository.GetAll();

        }
        public Role GetById(int id)
        {
            return this._unitOfWork.RoleRepository.GetById(id);
        }
        public int AddRole(Role Role)
        {
            this._unitOfWork.RoleRepository.Add(Role);
            this._unitOfWork.Save();

            return Role.Id;
          
        }
    }

}

