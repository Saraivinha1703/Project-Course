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
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }



        public ProjectCourseContext (DbContextOptions<ProjectCourseContext> options) : base(options)
        {
        }
    }
}
