using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class EventN
    {
        public EventN()
        {
            Donates = new HashSet<Donate>();
        }

        public int IdEvent { get; set; }
        public string NameEvent { get; set; }
        public string ContentEvent { get; set; }
        public DateTime? TimeCreateEvent { get; set; }
        public DateTime? StartDateEvent { get; set; }
        public DateTime? EndDateEvent { get; set; }
        public decimal? MoutEvent { get; set; }
        public decimal? AmoutAchievedEvent { get; set; }
        public string AddressEvent { get; set; }
        public string AuthorEvent { get; set; }
        public string PhotoEvent { get; set; }
        public bool? StatusEvent { get; set; }

        public virtual ICollection<Donate> Donates { get; set; }
    }
}
