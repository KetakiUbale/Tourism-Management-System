using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;
using Tourism.Persistence;
using Tourism.Service.Interface;

namespace Tourism.Service.Implementation
{
  public class PackageContentService:IPackageContentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public int AddPackageContent(PackageContent packageContent)
        {
            this._unitOfWork.PackageContentRepository.Add(packageContent);
          
            this._unitOfWork.Save();
            return packageContent.Id;
           
        }

        public PackageContent GetById(int id)
        {
            return this._unitOfWork.PackageContentRepository.GetById(id);
        }

        IEnumerable<PackageContent> IPackageContentService.GetAllUsers()
        {
            return this._unitOfWork.PackageContentRepository.GetAll();
        }
    }
}
