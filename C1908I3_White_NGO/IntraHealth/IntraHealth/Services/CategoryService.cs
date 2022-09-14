using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public interface CategoryService
    {
        List<Category> FindAll();
        Category Create(Category category);
        void Delete(int id);
        Category Find(int id);
        List<Category> Search(string keyword);
        Category Update(Category category);
    }
}
