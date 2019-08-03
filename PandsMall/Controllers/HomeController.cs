using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PandsMall.Data.Repository.Interface;
using PandsMall.Domain.ViewModels;
using PandsMall.Models;

namespace PandsMall.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(ICategoryRepository categoryRepository,
            IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        
         public IActionResult Index()
        {
            var homeVM = new HomeViewModel
            {
                CategoriesCount = _categoryRepository.Count(x => true),
                ProductsCount = _productRepository.Count(x => true)
            };

            return View(homeVM);
        }
    }
}
