using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectCourse.Models;

namespace ProjectCourse.Data
{
    public class ProjectCourseContext : DbContext
    {
        public ProjectCourseContext (DbContextOptions<ProjectCourseContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectCourse.Models.Department> Department { get; set; }
    }
}
