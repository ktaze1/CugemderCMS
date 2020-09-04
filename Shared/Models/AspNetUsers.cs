using System;
using System.Collections.Generic;

namespace CugemderPortal.Shared.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            Uploads = new HashSet<Uploads>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string CustomClaim { get; set; }
        public string Company { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string FirstName { get; set; }
        public int? Gender { get; set; }
        public int? Group { get; set; }
        public int? JobTitle { get; set; }
        public int? Notifications { get; set; }
        public string PhotoUrl { get; set; }
        public int? Points { get; set; }
        public int? Position { get; set; }
        public string ReferencedBy { get; set; }
        public int? Speciality { get; set; }
        public string SurName { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string PhoneNo { get; set; }

        public virtual Genders GenderNavigation { get; set; }
        public virtual Groups GroupNavigation { get; set; }
        public virtual JobTitles JobTitleNavigation { get; set; }
        public virtual Notifications NotificationsNavigation { get; set; }
        public virtual Points PointsNavigation { get; set; }
        public virtual Positions PositionNavigation { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<Uploads> Uploads { get; set; }
    }
}
