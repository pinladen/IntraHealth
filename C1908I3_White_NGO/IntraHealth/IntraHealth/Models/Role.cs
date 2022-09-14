using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class Role
    {
        public Role()
        {
            AccountNs = new HashSet<AccountN>();
        }

        public int IdRole { get; set; }
        public string NameRole { get; set; }

        public virtual ICollection<AccountN> AccountNs { get; set; }
    }
}
