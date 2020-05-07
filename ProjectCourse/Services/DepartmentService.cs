using ProjectCourse.Data;
using ProjectCourse.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectCourse.Services
{
    public class DepartmentService
    {
        private readonly ProjectCourseContext _context;

        public DepartmentService(ProjectCourseContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
