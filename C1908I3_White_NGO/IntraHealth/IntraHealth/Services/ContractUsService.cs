using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public interface ContractUsService
    {
        List<ContractUsN> FindAll();
        ContractUsN Create(ContractUsN contractUsN);
        void Delete(int id);
        ContractUsN Find(int id);
        ContractUsN Update(ContractUsN contractUsN);
    }
}
