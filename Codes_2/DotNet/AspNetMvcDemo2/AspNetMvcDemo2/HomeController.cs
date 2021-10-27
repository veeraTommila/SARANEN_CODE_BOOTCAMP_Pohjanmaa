using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDemo2
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*public void Read()
        {
            //path of file
            var path = @"D:\Tiedostot\SARANEN_CODE_BOOTCAMP_Pohjanmaa\Codes_2\DotNet\Number.txt";
            if (System.IO.File.Exists(path))
            {
                using (TextReader tr = new StreamReader(path))
                {
                    var text = tr.ReadLine();
                }
            }
        }*/
    }
}
