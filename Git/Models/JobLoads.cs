﻿using System;
using System.Collections.Generic;
namespace Git.Models
{
    public class JobLoads
    {
        public int JobloadId { get; set; }
        public Teachers? Teacher { get; set; }
        public int Hours { get; set; }
    }
}
