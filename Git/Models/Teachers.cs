using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Git.Models
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int? DegreeId { get; set; }
        public int? DisciplineId { get; set; }

        [ForeignKey("DegreeId")]
        public virtual AcademicDegrees? AcademicDegrees { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Departments? Departments { get; set; }
        [ForeignKey("DisciplineId")]
        public virtual Disciplines? Disciplines { get; set; }
        public ICollection<JobLoads>? JobLoads { get; set; }
        public ICollection<JobPosts>? JobPosts { get; set; }
    }
}
