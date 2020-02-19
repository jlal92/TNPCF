using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;


namespace TNPCF.Models
{
    [Table("tblMember")]   
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MembershipType { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int MembershipId { get; set; }
    }
}
