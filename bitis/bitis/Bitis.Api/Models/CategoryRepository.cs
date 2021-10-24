using bitis.mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitis.Api.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Category GetCategory(int idDanhMuc)
        {
            return appDbContext.Categorys
                .FirstOrDefault(d => d.IdDanhMuc == idDanhMuc);
        }

        public IEnumerable<Category> GetCategorys()
        {
            return appDbContext.Categorys;
        }
    }
}
