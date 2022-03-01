using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using products_categories.Models;
using Microsoft.EntityFrameworkCore;

namespace products_categories.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.allProducts = _context.Products.ToList();
            ViewBag.allCategories = _context.Categories.ToList();
            return View();
        }

        [HttpGet("Products")]
        public IActionResult Products()
        {
            ViewBag.allProducts = _context.Products.ToList();
            return View();
        }

        [HttpPost("addProduct")]
        public IActionResult createProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Products");
            } else {
                return View("Products");
            }
        }

        [HttpGet("Categories")]
        public IActionResult Categories()
        {
            ViewBag.allCats = _context.Categories.ToList();
            return View();
        }

        [HttpPost("addCategory")]
        public IActionResult createCategory(Category newCat)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(newCat);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            } else {
                return View("Categories");
            }
        }

        [HttpPost("addProductToCategory")]
        public IActionResult addProductToCategory(Association newAssn)
        {
            //from single category page
            _context.Associations.Add(newAssn);
            _context.SaveChanges();
            return Redirect($"category/get/{newAssn.CategoryId}");
        }

        [HttpPost("addCategoryToProduct")]
        public IActionResult addCategoryToProduct(Association newAssn)
        {
            //from single product page
            _context.Associations.Add(newAssn);
            _context.SaveChanges();
            return Redirect($"products/get/{newAssn.ProductId}");
        }

        [HttpGet("products/get/{pid}")]
        public IActionResult SingleProduct(int pid)
        {
            ViewBag.addedCategories = _context.Categories.Include(s=>s.Products).ThenInclude(d=>d.Product).FirstOrDefault(a=>a.CategoryId == pid);
            ViewBag.singleProd = _context.Products.FirstOrDefault(b=>b.ProductId== pid);
            ViewBag.allCategories = _context.Categories.OrderBy(d=>d.Name).ToList();
            return View();
        }

        [HttpGet("category/get/{cid}")]
        public IActionResult SingleCategory(int cid)
        {
            ViewBag.singleCat = _context.Categories.FirstOrDefault(b=>b.CategoryId== cid);
            ViewBag.allProducts = _context.Products.OrderBy(d=>d.Name).ToList();
            return View("SingleCategory");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
