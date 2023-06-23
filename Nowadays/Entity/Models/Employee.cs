#nullable disable
using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Issues = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }
    }
}