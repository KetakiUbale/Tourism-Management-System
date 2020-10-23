using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Service
{
   public interface IPackageContentService
    {
        IEnumerable<PackageContent> GetAllUsers();
        PackageContent GetById(int id);
        //Package GetByPackageName(string PackageName);
        int AddPackageContent(PackageContent packageContent);
    }
}
