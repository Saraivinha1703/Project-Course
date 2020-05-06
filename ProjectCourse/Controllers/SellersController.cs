using System;
using System.Collections.Generic;
using ProjectCourse.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectCourse.Services;

namespace ProjectCourse.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService seller)
        {
            _sellerService = seller;
        }

        public IActionResult Index()
        {
            List<Seller> list = _sellerService.FindAll();

            return View(list);
        }
        public IActionResult Create()
        {
            return View();
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