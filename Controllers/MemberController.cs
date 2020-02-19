using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TNPCF.Models;

namespace TNPCF.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Details(int id)
        {
            MemberContext memberContext = new MemberContext();
            Member member = memberContext.Members.SingleOrDefault(x => x.MemberId == id);

            return View(member);
        }

        public ActionResult Index(int membershipId)
        {
            MemberContext memberContext = new MemberContext();
            List<Member> members = memberContext.Members.Where(mem => mem.MembershipId == membershipId).ToList();

            return View(members);
        }
    }
}