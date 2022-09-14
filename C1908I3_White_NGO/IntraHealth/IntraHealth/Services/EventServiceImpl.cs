using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class EventServiceImpl : EventService
    {
        private DatabaseContext db;
        public EventServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        //find event
        public EventN Find(int id)
        {
            return db.EventNs.SingleOrDefault(p => p.IdEvent == id);
        }


        // return all list Event
        public List<EventN> FindAll()
        {
            return db.EventNs.ToList();
        }

        //Create Event(new)
        public EventN Create(EventN eventN)
        {
                eventN.TimeCreateEvent = DateTime.UtcNow;
                eventN.AmoutAchievedEvent = 0;
                db.EventNs.Add(eventN);
                db.SaveChanges();
               return eventN;
        }

        //Delete for id
        public dynamic Delete(int id)
        {
            db.EventNs.Remove(db.EventNs.Find(id));
            db.SaveChanges();
            return new
            {
                status = true
            };
        }

        //Update opject 
        public dynamic Update(EventN eventN)
        {
            Debug.WriteLine("amout ac : " + eventN.AmoutAchievedEvent);
            db.Entry(eventN).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            Debug.WriteLine("thanh cong");
            return new
            {
                status = true
            };
        }

        
    }
}
