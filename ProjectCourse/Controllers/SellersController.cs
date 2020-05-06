using System;
using System.Collections.Generic;
using ProjectCourse.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectCourse.Services;
using ProjectCourse.Models.ViewModels;

namespace ProjectCourse.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService seller, DepartmentService departmentService)
        {
            _sellerService = seller;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            List<Seller> list = _sellerService.FindAll();

            return View(list);
        }
        public IActionResult Create()
        {
            ICollection<Department> departments = _departmentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel) ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}