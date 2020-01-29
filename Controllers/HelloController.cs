using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TNPCF.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TNPCF.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
            // return View();
            return View();
             
            //Content("<h1>Hello World</h1>", "text/html");
        }
    }
}
