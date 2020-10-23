using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Tourism.Model;
using Tourism.Persistence;
using Tourism.Service.Interface;

namespace Tourism.Service.Implementation
{
   public class PackageService: IPackageService
    {
        private readonly IUnitOfWork _unitOfWork;
       
        public IEnumerable<Package> GetAllUsers()
        {
            return this._unitOfWork.PackageRepository.GetAll();
        }

        public Package GetById(int id)
        {
            return this._unitOfWork.PackageRepository.GetById(id);
        }

      // public Package GetByPackageName(string PackageName)
        //{
          
        //}
        public int AddPackage(Package Package)
        {
            this._unitOfWork.PackageRepository.Add(Package);
            this._unitOfWork.Save();

            return Package.Id;
        }

        
    }
}
