using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public interface EventService
    {

        EventN Find(int id);
        List<EventN> FindAll();
        EventN Create(EventN eventN);
        dynamic Delete(int id);
        dynamic Update(EventN eventN);
    }
}
