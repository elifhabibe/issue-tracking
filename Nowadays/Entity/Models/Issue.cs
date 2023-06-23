#nullable disable
using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Issue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? EmployeeId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}