using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class DonationServiceImpl : DonationService
    {
        private DatabaseContext db;
        public DonationServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        
        public Donate Create(Donate doante)
        {
            
            doante.TimeDonate = DateTime.Now;
            db.Donates.Add(doante);
            db.SaveChanges();
            return doante;
        }

        public void Delete(int id)
        {
            db.Donates.Remove(db.Donates.Find(id));
            db.SaveChanges();
        }

        

        public List<Donate> FindAll()
        {
            return db.Donates.ToList();
        }

        public Donate FindId(int id)
        {
            return db.Donates.SingleOrDefault(i => i.IdDonate == id);
        }

        public List<Donate> FindUser(int iduser)
        {
            return db.Donates.Where(p => p.IdUser == iduser).ToList();
        }

        public dynamic Update(Donate donate)
        {
            db.Entry(donate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return donate;
        }
    }
}
