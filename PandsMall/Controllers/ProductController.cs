using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PandsMall.Data.Entities;
using PandsMall.Data.Repository.Interface;
using PandsMall.Domain.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PandsMall.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, 
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        [Route("Product")]
        [AllowAnonymous]
        public IActionResult List(int? categoryId)
        {

            var book = _productRepository.GetAllWithCategory().ToList();

            IEnumerable<Product> products;

            ViewBag.CategoryId = categoryId;

            if (categoryId == null)
            {
                products = _productRepository.GetAllWithCategory();
                return CheckProductsCount(products);
            }
            else
            {
                var category = _categoryRepository.GetWithProducts((int)categoryId);

                if (category.Products == null || category.Products.Count() == 0)
                    return View("EmptyCategory", category);
            }

            products = _productRepository.FindWithCategory(a => a.Category.Id == categoryId);

            return CheckProductsCount(products);
        }

        [AllowAnonymous]
        private IActionResult CheckProductsCount(IEnumerable<Product> products)
        {
            if (products == null || products.ToList().Count == 0)
            {
                return View("Empty");
            }
            else
            {
                return View(products);
            }
        }

        public IActionResult Update(int id)
        {
            Product product = _productRepository.FindWithCategory(a => a.Id == id).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            var productVM = new ProductEditViewModel
            {
                Product = product,
                Categories = _categoryRepository.GetAll()
            };

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Update(ProductEditViewModel productVM)
        {
            if (!ModelState.IsValid)
            {
                productVM.Categories = _categoryRepository.GetAll();
                return View(productVM);
            }
            _productRepository.Update(productVM.Product);

            return RedirectToAction("List");
        }

        public IActionResult Create(int? categoryId)
        {
            Product product = new Product();

            if (categoryId != null)
            {
                product.CategoryId = (int)categoryId;
            }

            var productVM = new ProductEditViewModel
            {
                Categories = _categoryRepository.GetAll(),
                Product = product
            };

            return View(productVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductEditViewModel productVM)
        {
            if (!ModelState.IsValid)
            {
                productVM.Categories = _categoryRepository.GetAll();
                return View(productVM);
            }

            _productRepository.Create(productVM.Product);

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id, int? categoryId)
        {
            var product = _productRepository.GetById(id);

            _productRepository.Delete(product);

            return RedirectToAction("List", new { categoryId = categoryId });
        }
    }
}
