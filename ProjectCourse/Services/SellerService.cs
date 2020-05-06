using ProjectCourse.Data;
using ProjectCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCourse.Services
{
    public class SellerService
    {
        private readonly ProjectCourseContext _context;
        public SellerService(ProjectCourseContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
