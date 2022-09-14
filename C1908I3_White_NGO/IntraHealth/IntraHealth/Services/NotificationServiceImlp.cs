using IntraHealth.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class NotificationServiceImlp : NotificationService
    {
        private DatabaseContext db;
        public NotificationServiceImlp(DatabaseContext _db)
        {
            db = _db;
        }
        public NotificationN Create(NotificationN notification)
        {
            db.NotificationNs.Add(notification);
            db.SaveChanges();
            return notification;
        }

        public void Delete(int id)
        {
            db.NotificationNs.Remove(db.NotificationNs.Find(id));
            db.SaveChanges();
        }

        public NotificationN Find(int id)
        {
            return db.NotificationNs.SingleOrDefault(i => i.IdNotification == id);
        }

        public List<NotificationN> FindAll()
        {
            return db.NotificationNs.ToList();
        }

        public List<NotificationN> FindUser(int iduser)
        {
            return db.NotificationNs.Where(p => p.IdUser == iduser).ToList();
        }

        public List<NotificationN> Search(string keyword)
        {
            return db.NotificationNs.Where(p => p.FromAdmin.ToLower().Contains(keyword.ToLower())).ToList();

        }

        public NotificationN Update(NotificationN notificationN)
        {
            db.Entry(notificationN).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return notificationN;
        }
    }
}
