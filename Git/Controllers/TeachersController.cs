using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Git.Data;
using Git.Models;
using Microsoft.AspNetCore.Mvc;
using Git.Interfaces.TeachersInterfaces;
using Git.Filters.TeachersFilters;

namespace Git.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly ILogger<TeachersController> _logger;
        private readonly ITeachersService _teachersService;

        public TeachersController(ILogger<TeachersController> logger, ITeachersService teachersService)
        {
            _logger = logger;
            _teachersService = teachersService;
        }

        [HttpPost(Name = "GetTeachersByDepartments")]
        public async Task<IActionResult> GetTeachersByDepartmentsAsync(TeachersDepartmentFilter filter, CancellationToken cancellationToken = default)
        {
            var teachers = await _teachersService.GetTeachersByDepartmentsAsync(filter, cancellationToken);
            return Ok(teachers);
        }


    }
}
