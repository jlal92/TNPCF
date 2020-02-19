using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TNPCF.Models
{
    public class MemberContext : IdentityDbContext
    {
        public DbSet<Membership> MembershipTypes { get; set; }
        public DbSet<Member> Members { get; set;}
    }
}
