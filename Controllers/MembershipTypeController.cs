using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TNPCF.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TNPCF.Controllers
{
    public class MembershipTypeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            MemberContext memberContext = new MemberContext();
            List<Membership> MembershipTypes = memberContext.MembershipTypes.ToList();
            return View(MembershipTypes);
        }
    }
}
