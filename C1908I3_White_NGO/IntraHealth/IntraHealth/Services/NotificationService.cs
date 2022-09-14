using IntraHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public interface NotificationService
    {
        List<NotificationN> FindAll();
        NotificationN Create(NotificationN notificationN);
        void Delete(int id);
        NotificationN Find(int id);
        List<NotificationN> Search(string keyword);
        List<NotificationN> FindUser(int iduser);
        NotificationN Update(NotificationN notificationN);
    }
}

