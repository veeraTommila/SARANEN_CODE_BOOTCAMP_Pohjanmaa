using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo_1.Models;

namespace WebAPIDemo_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public List <Customer> AllCustomers()
        {
            NorthwindContext context = new();
            List<Customer> allCustomers = context.Customers.ToList();
            return allCustomers;

        }
    }
}
