using InventoryManagement.Context;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace InventoryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context) //ye constroctor h
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var product = _context.product.ToList(); //employye ka sara data layega
            return View(product); // return view with data
            
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(product model)
        {

            var data = _context.product.Add(model);
            _context.SaveChanges();
            return View();
        }


        //public async Task<IEnumerable<product>> GetProduct()
        //{
        //    var product = await _context.product.ToListAsync();
        //    return product;
        //}

        //public async Task<dynamic> Edit(int ID)
        //{
        //    var product = await _context.product.FirstOrDefaultAsync(x => x.id == ID);
        //    return product;
        //}

        //public dynamic Update(product product)
        //{
        //    var Data = _context.product.Update(product);
        //    _context.SaveChanges();
        //    return Data;
        //}

        public IActionResult Put()
        {
            return View();
        }

        public IActionResult Get()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
