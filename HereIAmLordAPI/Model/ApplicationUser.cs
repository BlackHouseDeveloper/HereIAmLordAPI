using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HereIAmLordAPIAccount.Model
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [RegularExpression(@"(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[0-1])-([12]\d{3})", ErrorMessage = "Birthday should match a valid MM/DD/YYYY value")]
        public string Bday { get; set; }
        public string Description { get; set; }

    }
}
