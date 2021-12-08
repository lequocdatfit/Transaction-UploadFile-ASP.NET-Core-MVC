using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UploadFileMVC.Models;

namespace UploadFileMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadFile(IFormFile myFile)
        {
            if(myFile != null)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "MyFile", myFile.FileName);
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    myFile.CopyTo(file);
                }
            }
            return View("Index");
        }

        public IActionResult Privacy()
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