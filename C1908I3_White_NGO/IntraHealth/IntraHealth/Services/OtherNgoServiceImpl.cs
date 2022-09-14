using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class OtherNgoServiceImpl : OtherNgoSevice
    {
        private DatabaseContext db;
        public OtherNgoServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public OtherNgo Create(OtherNgo otherNgo)
        {
            db.OtherNgos.Add(otherNgo);
            db.SaveChanges();
            return otherNgo;
        }

        public void Delete(int id)
        {
            db.OtherNgos.Remove(db.OtherNgos.Find(id));
            db.SaveChanges();
        }

        public OtherNgo Find(int id)
        {
            return db.OtherNgos.SingleOrDefault(i => i.IdNgo == id);
        }

        public List<OtherNgo> FindAll()
        {
            return db.OtherNgos.ToList();
        }

        public List<OtherNgo> Search(string keyword)
        {


            return db.OtherNgos.Where(p => p.NameNgo.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public OtherNgo Update(OtherNgo otherNgo)
        {
            db.Entry(otherNgo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return otherNgo;
        }
    }
}
