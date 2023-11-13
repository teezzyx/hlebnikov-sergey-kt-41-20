using System;
using System.Collections.Generic;
using hlebnikov_sergey_kt_41_20.Models;
using Microsoft.EntityFrameworkCore;
namespace hlebnikov_sergey_kt_41_20.Data
{
    public class TeachersDbContext : DbContext
    {
        public TeachersDbContext(DbContextOptions<TeachersDbContext> options)
        : base(options)
        { }
        public DbSet<AcademicDegrees> AcademicDegrees { get; set; } = null!;
        public DbSet<Departments> Departments { get; set; } = null!;
        public DbSet<Disciplines> Disciplines { get; set; } = null!;
        public DbSet<JobLoads> JobLoads { get; set; } = null!;
        public DbSet<JobPosts> JobPosts { get; set; } = null!;
        public DbSet<Teachers> Teachers { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcademicDegrees>().ToTable("AcademicDegrees");
            modelBuilder.Entity<Departments>().ToTable("Departments");
            modelBuilder.Entity<Disciplines>().ToTable("Disciplines");
            modelBuilder.Entity<JobLoads>().ToTable("JobLoads");
            modelBuilder.Entity<JobPosts>().ToTable("JobPosts");
            modelBuilder.Entity<Teachers>().ToTable("Teachers");
        }
    }
}
