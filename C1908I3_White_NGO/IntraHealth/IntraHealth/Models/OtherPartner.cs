using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class OtherPartner
    {
        public int IdPartner { get; set; }
        public string LogoPt { get; set; }
        public string NamePt { get; set; }
        public string CompanyPt { get; set; }
        public int? PhonePt { get; set; }
        public string EmailPt { get; set; }
        public DateTime? JoinDatePt { get; set; }
        public bool? StatusPt { get; set; }
    }
}
