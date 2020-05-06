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

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            Seller obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
