using System;
using System.Collections.Generic;

namespace Git.Models
{
    public class Teachers
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<JobLoads>? JobLoads { get; set; }
    }
}
