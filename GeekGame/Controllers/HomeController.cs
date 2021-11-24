using GeekGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace GeekGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBaseContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataBaseContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }




        [HttpGet]
        public IActionResult GetData(string dataIndex)
        {
            int indx = Convert.ToInt32(dataIndex);
            return Json(_context.TblNationality.OrderByDescending(a => a.Id).Skip(indx).FirstOrDefault());
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
