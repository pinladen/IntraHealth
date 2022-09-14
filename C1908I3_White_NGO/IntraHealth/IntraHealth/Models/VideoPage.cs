using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class VideoPage
    {
        public int IdImagePage { get; set; }
        public string DataImagePage { get; set; }
        public int? IdPage { get; set; }
        public bool? StatusImagePage { get; set; }

        public virtual Page IdPageNavigation { get; set; }
    }
}
