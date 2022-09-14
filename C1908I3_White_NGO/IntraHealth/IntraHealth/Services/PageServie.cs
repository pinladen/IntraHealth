using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public interface PageServie
    {
        List<Page> FindAll();
        Page Create(Page page);
        void Delete(int id);
        Page Find(int id);
        List<Page> Search(string keyword);
        Page Update(Page page);
    }
}
