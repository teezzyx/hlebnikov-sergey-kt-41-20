using System;
using System.Collections.Generic;

namespace Git.Models
{
    public class Teachers
    {
        public int TeacherId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual Departments? Departments { get; set; }
        public ICollection<JobLoads>? JobLoads { get; set; }
    }
}
