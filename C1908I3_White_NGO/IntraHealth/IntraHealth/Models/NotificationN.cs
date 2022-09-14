using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class NotificationN
    {
        public int IdNotification { get; set; }
        public string FromAdmin { get; set; }
        public int? IdUser { get; set; }
        public string TextNotification { get; set; }
        public DateTime? SendTimeNotification { get; set; }
        public bool? StatusNotification { get; set; }

        public virtual AccountN IdUserNavigation { get; set; }
    }
}
