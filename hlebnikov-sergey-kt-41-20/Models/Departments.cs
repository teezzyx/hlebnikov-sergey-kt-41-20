using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace hlebnikov_sergey_kt_41_20.Models
{
    public class Departments
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection <Teachers>? Teacher { get; set; }
        public bool isValidDepartmentName()
        {
            return Regex.Match(DepartmentName, @"[A-Z ]+").Success;
        }
    }
}
