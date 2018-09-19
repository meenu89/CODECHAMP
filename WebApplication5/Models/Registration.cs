using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Registration
    {
        [Key]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string companyName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string CompanyEmail { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Test Date")]
        [DataType(DataType.Date)]
        public DateTime TestDate { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int TestDuration { get; set; }

        [Required(ErrorMessage = "Required.")]
        public String Password { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}