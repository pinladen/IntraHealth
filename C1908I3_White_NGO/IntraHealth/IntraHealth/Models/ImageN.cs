using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class ImageN
    {
        public int IdImg { get; set; }
        public string NameImg { get; set; }
        public string UrlImg { get; set; }
        public int? IdEvent { get; set; }
        public bool? StatusImg { get; set; }

        public virtual EventN IdEventNavigation { get; set; }
    }
}
