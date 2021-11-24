using NguyensBooks.DataAccess.Repository.IRepository;
using NguyensBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyensBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork   // makes the method public to access the class
    {
        private readonly ApplicationDbContext _db;  // using statement
        public UnitOfWork(ApplicationDbContext db) // constructor to use the DI and inject into the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public ICoverTypeRepository CoverTypeRepository { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()      // All changes will be saved when the save method is called at 'parent' level
        {
            _db.SaveChanges();
        }
    }
}
