using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Project
    {
        public Project()
        {
            Issues = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}