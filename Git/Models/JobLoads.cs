﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Git.Models
{
    public class JobLoads
    {
        [Key]
        public int JobloadId { get; set; }
        public int? TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public Teachers? Teacher { get; set; }
        public int Hours { get; set; }
    }
}
