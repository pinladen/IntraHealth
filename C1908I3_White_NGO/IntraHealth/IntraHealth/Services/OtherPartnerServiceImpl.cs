using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class OtherPartnerServiceImpl: OtherPartnerService
    {
        private DatabaseContext db;
        public OtherPartnerServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public OtherPartner Create(OtherPartner otherPartner)
        {
            db.OtherPartners.Add(otherPartner);
            db.SaveChanges();
            return otherPartner;
        }

        public void Delete(int id)
        {
            db.OtherPartners.Remove(db.OtherPartners.Find(id));
            db.SaveChanges();
        }

        public OtherPartner Find(int id)
        {
            return db.OtherPartners.SingleOrDefault(i => i.IdPartner == id);
        }

        public List<OtherPartner> FindAll()
        {
            return db.OtherPartners.ToList();
        }

        public List<OtherPartner> Search(string keyword)
        {


            return db.OtherPartners.Where(p => p.NamePt.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public OtherPartner Update(OtherPartner otherPartner)
        {
            db.Entry(otherPartner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return otherPartner;
        }
    }
}
