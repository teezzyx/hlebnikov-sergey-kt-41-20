﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Git.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        { }
        public DbSet <AcademicDegrees> AcademicDegrees { get; set; } = null!;
        public DbSet<Departments> Departments { get; set; } = null!;
        public DbSet<Disciplines> Disciplines { get; set; } = null!;
        public DbSet <JobLoads> JobLoads { get; set; } = null!;
        public DbSet <JobPosts> JobPosts { get; set; } = null!;
        public DbSet<Teachers> Teachers { get; set; } = null!;

    }
}
