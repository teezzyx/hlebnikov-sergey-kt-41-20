using System;
using System.Collections.Generic;
namespace Git.Models
{
    public class AcademicDegrees
    {
        public int DegreeId { get; set; }
        public string? Degree { get; set; }
        public int? TeacherId { get; set; }
    }
}
