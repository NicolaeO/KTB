using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KTB.Models;

namespace KTB.Controllers{
    public class HomeController : Controller{

        private KTBContext _context;
        public HomeController(KTBContext context){
            _context = context;
        }
        public IActionResult Index(){
            return View();
        }

        public IActionResult Contact(){
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
