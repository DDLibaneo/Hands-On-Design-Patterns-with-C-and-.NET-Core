﻿using System;
using FlixOne.Web.Common;
using FlixOne.Web.Models;
using FlixOne.Web.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace FlixOne.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IInventoryRepositry _inventoryRepositry;

        public ProductController(IInventoryRepositry inventoryRepositry) => _inventoryRepositry = inventoryRepositry;

        public IActionResult Index() => View(_inventoryRepositry.GetProducts().ToProductvm());

        public IActionResult Details(Guid id) => View(_inventoryRepositry.GetProduct(id).ToProductvm());
        
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] Product product)
        {
            try
            {
                _inventoryRepositry.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        public IActionResult Edit(Guid id) => View(_inventoryRepositry.GetProduct(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [FromBody] Product product)
        {
            try
            {
                _inventoryRepositry.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(Guid id) => View(_inventoryRepositry.GetProduct(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Guid id, [FromBody] Product product)
        {
            try
            {
                _inventoryRepositry.RemoveProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}