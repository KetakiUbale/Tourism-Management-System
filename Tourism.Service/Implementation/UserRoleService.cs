using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;
using Tourism.Persistence;

namespace Tourism.Service
{
   public class UserRoleService : IUserRoleService
    {

        private readonly IUnitOfWork _unitOfWork;
        public UserRoleService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<UserRole> GetAllUsers()
        {
            return this._unitOfWork.UserRoleRepository.GetAll();
        }

        public UserRole GetById(int id)
        {
            return this._unitOfWork.UserRoleRepository.GetById(id);
        }
        public int AddUserRole(UserRole UserRole)
        {
            this._unitOfWork.UserRoleRepository.Add(UserRole);
            this._unitOfWork.Save();

            return UserRole.Id;
        }
    }
}
