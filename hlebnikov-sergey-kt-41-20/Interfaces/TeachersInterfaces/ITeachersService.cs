using hlebnikov_sergey_kt_41_20.Data;
using hlebnikov_sergey_kt_41_20.Filters.TeachersFilters;
using hlebnikov_sergey_kt_41_20.Models;
using Microsoft.EntityFrameworkCore;

namespace hlebnikov_sergey_kt_41_20.Interfaces.TeachersInterfaces
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


