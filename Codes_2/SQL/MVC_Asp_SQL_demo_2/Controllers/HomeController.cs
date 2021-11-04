using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Asp_SQL_demo_2.Models;

namespace MVC_Asp_SQL_demo_2.Controllers
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
            NorthwindContext context = new();
            List<Customer> allCustomers = context.Customers.ToList(); //-> Customers.cs

            ViewBag.AllCustomers = allCustomers;

            return View();
        }

        public IActionResult Privacy()
        {
            NorthwindContext context = new();
            List<Order> allOrders = context.Orders.ToList();    //-> Order.cs
            /*List<Order> allOrders = (from tilaus in context.Orders //tilaus on vain tilapäinen muuttuja.
                                     where tilaus.EmployeeId == 2
                                     orderby tilaus.OrderDate descending
                                     select tilaus).ToList();            
            */
            ViewBag.AllOrders = allOrders;

            return View();
        }

        public IActionResult Orders(int id) //This is for the Orders.cshtml.
        {
            NorthwindContext context = new();
            List<Order> allOrders = context.Orders.ToList();

            ViewBag.AllOrders = allOrders;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
