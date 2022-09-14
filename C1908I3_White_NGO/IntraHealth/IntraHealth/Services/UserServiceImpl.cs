using IntraHealth.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Services
{
    public class UserServiceImpl : UserService
    {
        private DatabaseContext db;
        public UserServiceImpl(DatabaseContext _db)
        {
            db = _db;
        } 

        // Create account
        public AccountN Create(AccountN account)
        {
            try
            {
                if(account != null)
                {
                    if(account.PasswordUser != null)
                    {
                        account.PasswordUser = BCrypt.Net.BCrypt.HashString(account.PasswordUser);
                    }
                    if(account.TimeCreateUser == null)
                    {
                        account.TimeCreateUser = DateTime.Now;
                    }
                    if(account.IdRole == null)
                    {
                        account.IdRole = 2;
                    }
                    if(account.StatusUser == null)
                    {
                        account.StatusUser = true;
                    }
                    db.AccountNs.Add(account);
                    db.SaveChanges();
                    return account;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        // Delete user
        public void Delete(int idUser)
        {
            if(Find(idUser) != null)
            {
                // delete relationship Forengkey : Doante
                if(db.Donates.Where(p =>p.IdUser == idUser) != null)
                {
                    var donate = db.Donates.Where(p => p.IdUser == idUser).ToList();
                    for (var i = 0; i < donate.Count; i++)
                    {
                        if(donate.Count >=0)
                        {
                            db.Donates.Remove(donate[i]);
                            Debug.WriteLine("donate : check ");
                        }
                        
                    }                   
                }
                // delete relationship Forengkey : Noitification
                if (db.NotificationNs.Where(p => p.IdUser == idUser) != null)
                {
                    var noiti = db.NotificationNs.Where(p => p.IdUser == idUser).ToList();
                    for (var i = 0; i < noiti.Count; i++)
                    {
                        db.NotificationNs.Remove(noiti[i]);
                        Debug.WriteLine("noitification : check ");
                    }
                }
                // delete relationship Forengkey : Contract
                if (db.ContractUsNs.Where(p => p.IdUser == idUser) != null)
                {
                    var contract = db.ContractUsNs.Where(p => p.IdUser == idUser).ToList();
                    for (var i = 0; i < contract.Count; i++)
                    {
                        db.ContractUsNs.Remove(contract[i]);
                        Debug.WriteLine("contract : check ");
                    }
                }
                db.AccountNs.Remove(Find(idUser));
                db.SaveChanges();
            }
            else
            {
                Debug.WriteLine("Can't delete User by relationship");
            }            
        }

        // Find singer account
        public AccountN Find(string username)
        {
            var result = db.AccountNs.SingleOrDefault(p => p.UsernameUser == username);
            return result;
        }
        public AccountN Find(int id)
        {
            return db.AccountNs.SingleOrDefault(p => p.IdUser == id);
        }

        public AccountN FindRole(int id)
        {
            return db.AccountNs.SingleOrDefault(p=>p.IdRole ==id);
        }

        public List<AccountN> FindAll()
        {
            return db.AccountNs.ToList();
        }

        public AccountN Login(string username , string password )
        {
            try
            {
                var account = Find(username);
                
                if (account != null)
                {
                    if (account.UsernameUser == username)
                    {
                        if( BCrypt.Net.BCrypt.Verify(password, account.PasswordUser))
                        {
                            return account;
                        }
                        else
                        {
                            Debug.WriteLine("sai password");
                            return null;
                        }
                    }
                    else
                    {
                        Debug.WriteLine("sai username");
                        return null;
                    }
                }
                else
                {
                    Debug.WriteLine("khong co tai khoan nao ca");
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<AccountN> Search(string keyword)
        {
            return db.AccountNs.Where(a => a.UsernameUser.Contains(keyword)).ToList();
        }

        public AccountN Update(AccountN account)
        {

            db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return account;
        }
    }
}
