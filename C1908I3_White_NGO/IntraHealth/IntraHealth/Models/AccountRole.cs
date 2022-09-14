using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class AccountRole
    {
        public int IdAccountRole { get; set; }
        public int? IdUser { get; set; }
        public int? IdRole { get; set; }

        public virtual RoleN IdRoleNavigation { get; set; }
        public virtual AccountN IdUserNavigation { get; set; }
    }
}
