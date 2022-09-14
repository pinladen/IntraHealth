using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
   public interface OtherNgoSevice
    {
        List<OtherNgo> FindAll();
        OtherNgo Create(OtherNgo otherNgo);
        void Delete(int id);
        OtherNgo Find(int id);
        List<OtherNgo> Search(string keyword);
        OtherNgo Update(OtherNgo otherNgo);
    }
}
