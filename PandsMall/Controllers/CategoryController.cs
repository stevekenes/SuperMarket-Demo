using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PandsMall.Data.Entities;
using PandsMall.Data.Repository.Interface;
using PandsMall.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [Route("Category")]
        [AllowAnonymous]
        public IActionResult List()
        {
            if (!_categoryRepository.Any()) return View("Empty");

            var categories = _categoryRepository.GetAllWithProducts();

            return View(categories);
        }

        [AllowAnonymous]
        public IActionResult CategoryDetail(int id)
        {
            var category = _categoryRepository.GetWithProducts(id);

            //if (category.Products == null)
            //{
            //    return View("Empty");
            //}

            return View(category);
        }

        [AllowAnonymous]
        public IActionResult Detail(int id)
        {
            var category = _categoryRepository.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public IActionResult Update(int id)
        {
            var category = _categoryRepository.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            _categoryRepository.Update(category);

            return RedirectToAction("List");
        }

        public ViewResult Create()
        {
            return View(new CreateCategoryViewModel { Referer = Request.Headers["Referer"].ToString() });
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryViewModel categoryVM)
        {
            if (!ModelState.IsValid)
            {
                return View(categoryVM);
            }

            _categoryRepository.Create(categoryVM.Category);

            if (!String.IsNullOrEmpty(categoryVM.Referer))
            {
                return Redirect(categoryVM.Referer);
            }

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var category = _categoryRepository.GetById(id);

            _categoryRepository.Delete(category);

            return RedirectToAction("List");
        }
    }
}
