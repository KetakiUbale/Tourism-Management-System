using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;
using Tourism.Persistence;

namespace Tourism.Service
{
 public class UserService:IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<User>GetAllUsers()
        {

            return this._unitOfWork.UserRepository.GetAll();
            
        }
        public User GetById(int id)
        {


            return this._unitOfWork.UserRepository.GetById(id);
        }
        public User GetByEmail(string email)
        {
           
            return this._unitOfWork.UserRepository.FirstOrDefault(X => X.Email == email);
        }
        public User AddUser(User user)
        {
            this._unitOfWork.UserRepository.Add(user);
            this._unitOfWork.Save();

            return user;
        }
        public User UpdateUser(User user)
        {
            this._unitOfWork.UserRepository.Update(user);
            this._unitOfWork.Save();

            return user;
        }

        public bool DeleteUser(int userId)
        {
            User user = this._unitOfWork.UserRepository.GetById(userId);
            if (user != null)
            {
                this._unitOfWork.UserRepository.Remove(user);
                this._unitOfWork.Save();

                return true;
            }
            return false;
        }
    }
}
