#nullable disable
using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Company
    {
        public Company()
        {
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}