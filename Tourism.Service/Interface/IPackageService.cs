using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Service.Interface
{
    public interface IPackageService
    {
        IEnumerable<Package> GetAllUsers();
        Package GetById(int id);
        //Package GetByPackageName(string PackageName);
        int AddPackage(Package Package);
    }
}
