using AspNetMvcDemo2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDemo2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string SayHello()
        {
            return "Hello everyone";
        }

        //Reads lines of Number.txt and sum the numbers. The text file is in
        //sub folder called FileSum.
        public IActionResult FileSum()
        {
            string filename = "D:\\Tiedostot\\SARANEN_CODE_BOOTCAMP_Pohjanmaa\\Codes_2\\DotNet\\Numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            int sum = 0;
            foreach (string line in lines)
            {
                int value = int.Parse(line);
                sum += value; //sum = sum + value.
            }

            ViewBag.SourceOfData = filename;
            ViewBag.CalculatedSum = sum;

            return View();
        }

        
        public IActionResult Index()
        {
            return View();
        }
         
        public IActionResult SecondPage()
        {
            return View();
        }
        public IActionResult Summa()
        {
            return View();
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
