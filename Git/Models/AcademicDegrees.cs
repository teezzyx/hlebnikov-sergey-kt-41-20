using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Git.Models
{
    public class AcademicDegrees
    {
        [Key]
        public int DegreeId { get; set; }
        public string? Degree { get; set; }
        public int? TeacherId { get; set; }
        public ICollection<Teachers>? Teachers { get; set; }
    }
}
