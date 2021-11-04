using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyAPITestController : ControllerBase
    {
        public string Hello()
        {
            return "Hello World!";
        }

    }
}
