using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class PageServiceImpl : PageServie
    {
        private DatabaseContext db;
        public PageServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public Page Create(Page page)
        {
            page.PhotoPage = "abc.png";
            db.Pages.Add(page);
            db.SaveChanges();
            return page;
        }

        public void Delete(int id)
        {
            db.Pages.Remove(db.Pages.Find(id));
            db.SaveChanges();
        }

        public Page Find(int id)
        {
            return db.Pages.SingleOrDefault(i => i.IdPage == id);
        }

        public List<Page> FindAll()
        {
            return db.Pages.ToList();
        }

        public List<Page> Search(string keyword)
        {


            return db.Pages.Where(p => p.NamePage.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public Page Update(Page page)
        {
            db.Entry(page).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return page;
        }
    }
}
