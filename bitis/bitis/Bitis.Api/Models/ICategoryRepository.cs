using bitis.mode;
using System.Collections.Generic;

namespace Bitis.Api.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategorys();
        Category GetCategory(int idDanhMuc);
    }
}