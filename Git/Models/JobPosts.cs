using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Git.Models
{
    public class JobPosts
    {
        [Key]
        public int JobpostId { get; set; }
        public string? JobPost { get; set; }
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teachers? Teachers { get; set; }
    }
}
