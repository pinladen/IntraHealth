using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class Donate
    {
        public int IdDonate { get; set; }
        public decimal? AmoutDonate { get; set; }
        public int? QuantityDonate { get; set; }
        public DateTime? TimeDonate { get; set; }
        public string NoteDonate { get; set; }
        public int? IdUser { get; set; }
        public int? IdEvent { get; set; }
        public bool? StatusDonate { get; set; }

        public virtual EventN IdEventNavigation { get; set; }
        public virtual AccountN IdUserNavigation { get; set; }
    }
}
