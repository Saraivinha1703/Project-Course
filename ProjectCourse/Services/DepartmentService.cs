using ProjectCourse.Data;
using ProjectCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCourse.Services
{
    public class DepartmentService
    {
        private readonly ProjectCourseContext _context;

        public DepartmentService(ProjectCourseContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
