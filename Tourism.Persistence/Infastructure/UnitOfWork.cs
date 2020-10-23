using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TourismContext _context;
        public Repository<User> UserRepository { get; }
        public Repository<Role> RoleRepository { get; }
        public Repository<UserRole> UserRoleRepository { get; }
        public Repository<Package> PackageRepository { get; }
        public Repository<PackageContent> PackageContentRepository { get; }

        public Repository<PackageContent> PackageContent => throw new NotImplementedException();

        public UnitOfWork(TourismContext context)
        {
            this._context = context;
            this.UserRepository = new Repository<User>(this._context);
            this.RoleRepository = new Repository<Role>(this._context);
            this.UserRoleRepository = new Repository<UserRole>(this._context);
            this.PackageRepository = new Repository<Package>(this._context);
            this.PackageContentRepository = new Repository<PackageContent>(this._context);
        }
        public int Save()
        {
            return this._context.SaveChanges();
        }
        public void Dispose()
        {
            this._context.Dispose();
        }
        

    }
        
        
}
