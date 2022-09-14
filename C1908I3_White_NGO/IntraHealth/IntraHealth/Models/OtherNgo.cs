using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class OtherNgo
    {
        public int IdNgo { get; set; }
        public string NameNgo { get; set; }
        public string UrlNgo { get; set; }
        public string InforNgo { get; set; }
        public DateTime? JoinDateNgo { get; set; }
        public bool? StatusNgo { get; set; }
    }
}
