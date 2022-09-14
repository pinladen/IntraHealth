using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class ContractUsServiceImlp : ContractUsService
    {
        private DatabaseContext db;
        public ContractUsServiceImlp(DatabaseContext _db)
        {
            db = _db;
        }
        public ContractUsN Create(ContractUsN contractUsN)
        {
            db.ContractUsNs.Add(contractUsN);
            db.SaveChanges();
            return contractUsN;
        }

        public void Delete(int id)
        {
            db.ContractUsNs.Remove(db.ContractUsNs.Find(id));
            db.SaveChanges();
        }

        public ContractUsN Find(int id)
        {
            return db.ContractUsNs.SingleOrDefault(i => i.IdContractUs == id);
        }

        public List<ContractUsN> FindAll()
        {
            return db.ContractUsNs.ToList();
        }



        public ContractUsN Update(ContractUsN contractUsN)
        {
            db.Entry(contractUsN).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return contractUsN;
        }
    }
}

