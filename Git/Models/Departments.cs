using System;
using System.Collections.Generic;
namespace Git.Models
{
    public class Departments
    {
        public int ID { get; set; }
        public string? Department { get; set; }
        public ICollection <Teachers> Teacher { get; set; }
    }
}
