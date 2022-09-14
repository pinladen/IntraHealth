using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class AccountN
    {
        public AccountN()
        {
            ContractUsNs = new HashSet<ContractUsN>();
            Donates = new HashSet<Donate>();
            NotificationNs = new HashSet<NotificationN>();
        }

        public int IdUser { get; set; }
        public string UsernameUser { get; set; }
        public string PasswordUser { get; set; }
        public string FistNameUser { get; set; }
        public string LastNameUser { get; set; }
        public string NicknameUser { get; set; }
        public string EmailUser { get; set; }
        public string AvatarUser { get; set; }
        public int? PhoneUser { get; set; }
        public DateTime? BrithdayUser { get; set; }
        public DateTime? TimeCreateUser { get; set; }
        public int? IdRole { get; set; }
        public bool? StatusUser { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<ContractUsN> ContractUsNs { get; set; }
        public virtual ICollection<Donate> Donates { get; set; }
        public virtual ICollection<NotificationN> NotificationNs { get; set; }
    }
}
