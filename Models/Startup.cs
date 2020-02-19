using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions.Common;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Builder;

namespace TNPCF.Models
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
         Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
