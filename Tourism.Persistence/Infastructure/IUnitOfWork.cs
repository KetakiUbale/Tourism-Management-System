using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Persistence
{
    public interface IUnitOfWork:IDisposable
    {
        Repository<User> UserRepository { get; }
        Repository<Role> RoleRepository { get; }
        Repository<UserRole> UserRoleRepository { get; }
        Repository<Package> PackageRepository { get; }
        Repository<PackageContent> PackageContentRepository { get; }
        int Save();
    }
}
