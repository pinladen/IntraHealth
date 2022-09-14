using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
   public interface OtherPartnerService
    {
        List<OtherPartner> FindAll();
        OtherPartner Create(OtherPartner otherPartner);
        void Delete(int id);
        OtherPartner Find(int id);
        List<OtherPartner> Search(string keyword);
        OtherPartner Update(OtherPartner otherPartner);
    }
}
