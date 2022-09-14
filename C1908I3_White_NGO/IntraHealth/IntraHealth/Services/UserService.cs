using IntraHealth.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
     public interface UserService
    {
        public AccountN Find(int id);
        public AccountN FindRole(int id);
        public AccountN Find(string username);
        public AccountN Login(string username, string password);
        public List<AccountN> FindAll();
        public List<AccountN> Search(string keyword);
        public AccountN Create(AccountN accountN);
        public AccountN Update(AccountN accountN);
        public void Delete(int idUser);
    }
}
