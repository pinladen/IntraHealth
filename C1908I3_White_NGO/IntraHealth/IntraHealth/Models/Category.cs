using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class Category
    {
        public Category()
        {
            Pages = new HashSet<Page>();
        }

        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public bool? StatusCategory { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
    }
}
