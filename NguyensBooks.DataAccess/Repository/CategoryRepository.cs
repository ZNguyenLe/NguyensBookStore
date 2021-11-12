using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyensBooks.DataAccess.Repository.IRepository;
using NguyensBooks.Models;
using NguyensBookStore.DataAccess.Data;

namespace NguyensBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use the .NET LINQ to retrieve the first or default category object. and pass the id as a generic entity that matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //this saves changes if its not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();

            }
        }
    }
}
