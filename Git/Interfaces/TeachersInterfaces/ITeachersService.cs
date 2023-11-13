using Git.Data;
using Git.Filters.TeachersFilters;
using Git.Models;
using Microsoft.EntityFrameworkCore;

namespace Git.Interfaces.TeachersInterfaces
{
    public interface ITeachersService
    {
        public Task<Teachers[]> GetTeachersByDepartmentsAsync(TeachersDepartmentFilter filter, CancellationToken cancellationToken);
    }
    public class TeachersService : ITeachersService
    {
        private readonly TeachersDbContext _dbContext;
        public TeachersService(TeachersDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<Teachers[]> GetTeachersByDepartmentsAsync(TeachersDepartmentFilter filter, CancellationToken cancellationToken = default)
        {
            var teachers = _dbContext.Set<Teachers>().Where(w => w.Departments.DepartmentName == filter.DepartmentName).ToArrayAsync(cancellationToken);
            return teachers;
        }

    }
}


