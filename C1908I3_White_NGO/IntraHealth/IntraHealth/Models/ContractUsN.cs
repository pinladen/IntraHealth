using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class ContractUsN
    {
        public int IdContractUs { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Details { get; set; }
        public int? IdUser { get; set; }
        public bool? StatusContratcus { get; set; }

        public virtual AccountN IdUserNavigation { get; set; }
    }
}
