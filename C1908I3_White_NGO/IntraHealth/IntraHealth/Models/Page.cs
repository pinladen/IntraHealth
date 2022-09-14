using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class Page
    {
        public int IdPage { get; set; }
        public string NamePage { get; set; }
        public string TitlePage { get; set; }
        public string AuthorPage { get; set; }
        public DateTime? TimeCreatePage { get; set; }
        public string ContentPage { get; set; }
        public string PhotoPage { get; set; }
        public int? IdCategory { get; set; }
        public bool? StatusPage { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
    }
}
