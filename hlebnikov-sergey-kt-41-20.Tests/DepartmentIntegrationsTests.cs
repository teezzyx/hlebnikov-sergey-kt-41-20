using Git.Models;
using Git.Data;
using Git.Interfaces.TeachersInterfaces;
using Git.Filters.TeachersFilters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hlebnikov_sergey_kt_41_20.Tests
{
    public class DepartmentIntegrationsTests
    {
        public readonly DbContextOptions<TeachersDbContext> _dbContextOptions;
        public DepartmentIntegrationsTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<TeachersDbContext>()
                .UseInMemoryDatabase(databaseName: "teachers_test_db")
                .Options;
        }

        [Fact]
        public async Task GetTeacherssByDepartmentAsync_KT3120_TwoObjects()
        {
            // Arrange
            var ctx = new TeachersDbContext(_dbContextOptions);
            var teachersService = new TeachersService(ctx);
            var departments = new List<Departments>
            {
                new Departments
                {
                    DepartmentName = "IVT"
                },
                new Departments
                {
                    DepartmentName = "kt"
                }
            };
            await ctx.Set<Departments>().AddRangeAsync(departments);

            var teachers = new List<Teachers>
            {
                new Teachers
                {
                    Name = "Ivan",
                    LastName = "Ivanov",
                    DepartmentId= 1,
                },
                new Teachers
                {
                    Name = "Vasya",
                    LastName = "Vasilyev",
                    DepartmentId = 2,
                },
                new Teachers
                {
                    Name = "Danil",
                    LastName = "Danilov",
                    DepartmentId = 1,
                }
            };
            await ctx.Set<Teachers>().AddRangeAsync(teachers);

            await ctx.SaveChangesAsync();

            // Act
            var filter = new TeachersDepartmentFilter
            {
                DepartmentName = "IVT"
            };
            var teachersResult = await teachersService.GetTeachersByDepartmentsAsync(filter, CancellationToken.None);

            // Assert
            Assert.Equal(2, teachersResult.Length);

        }
    }
}
