using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class CategoryServiceImpl : CategoryService
    {
        private DatabaseContext db;
        public CategoryServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public Category Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return category;
        }

        public void Delete(int id)
        {
            // delete relationship Forengkey : Doante
            if (db.Categories.Where(p => p.IdCategory == id) != null)
            {
                var pages = db.Pages.Where(p => p.IdCategory == id).ToList();
                for (var i = 0; i < pages.Count; i++)
                {
                    if (pages.Count >= 0)
                    {
                        db.Pages.Remove(pages[i]);
                        Debug.WriteLine("Pages : check ");
                    }

                }
            }
            db.Categories.Remove(db.Categories.Find(id));
            db.SaveChanges();
        }

        public Category Find(int id)
        {
            return db.Categories.SingleOrDefault(i => i.IdCategory == id);
        }

        public List<Category> FindAll()
        {
            return db.Categories.ToList();
        }

        public List<Category> Search(string keyword)
        {


            return db.Categories.Where(p => p.NameCategory.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public Category Update(Category category)
        {
            db.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return category;
        }
    }
}
