using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class RoleN
    {
        public RoleN()
        {
            AccountRoles = new HashSet<AccountRole>();
        }

        public int IdRole { get; set; }
        public string NameRole { get; set; }
        public bool? StatusRole { get; set; }

        public virtual ICollection<AccountRole> AccountRoles { get; set; }
    }
}
