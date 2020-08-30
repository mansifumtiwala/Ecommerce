using Ecommerce.Entities;
using Ecommerce.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryServices categoryServices = new CategoryServices();
        public ActionResult Index()
        {
            var categories = categoryServices.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryServices.SaveCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Category category = categoryServices.GetCategoryByID(Id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryServices.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            Category category = categoryServices.GetCategoryByID(Id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            Category cat = categoryServices.GetCategoryByID(category.ID);
            categoryServices.DeleteCategory(cat);
            return RedirectToAction("Index");
        }
    }
}