using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Git.Models
{
    public class Departments
    {
        [Key]
        public int DepartmentId { get; set; }
        public string? Department { get; set; }
        public ICollection <Teachers>? Teacher { get; set; }
    }
}
