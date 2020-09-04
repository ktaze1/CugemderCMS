using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CugemderPortal.Server.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string CustomClaim { get; set; }

        public string firstName { get; set; }

        public string surName { get; set; }

        public int? gender { get; set; }

        public string? company { get; set; }

        public string? photoUrl { get; set; }

        public string? phoneNo { get; set; }

        public int? jobTitle { get; set; }

        public string? speciality { get; set; }

        public int? position { get; set; }

        public int? points { get; set; }

        public int? notifications { get; set; }

        public string? referencedBy { get; set; }

        public int? group { get; set; }

        public DateTime? createdAt { get; set; }

        public DateTime? updatedAt { get; set; }
    }
}
