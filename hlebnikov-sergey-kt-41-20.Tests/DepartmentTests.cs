using Git.Data;
using Git.Models;
namespace hlebnikov_sergey_kt_41_20.Tests
{
    public class DepartmentTests
    {
        [Fact]
        public void IsValidDepartmentName_MS_True()
        {
            var testDepartment = new Departments
            { DepartmentId = 1, DepartmentName = "QWERT" };

            var result = testDepartment.isValidDepartmentName();

            Assert.True(result);

        }
    }
}