using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public interface DonationService
    {
        Donate FindId(int id);
        
        List<Donate> FindAll();
        Donate Create(Donate donate);
        void Delete(int id);
        dynamic Update(Donate donate);

        List<Donate> FindUser(int iduser);
    }
}
