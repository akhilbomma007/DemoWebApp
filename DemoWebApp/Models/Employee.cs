using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;

namespace DemoWebApp.Models
{
    public class Employee
    {
        [Required]
        [Display(Name ="Employee ID")]
        [Range(10000, 99999, ErrorMessage = "You need to enter a valid employee id")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to enter your first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to enter your Last name")]
        public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "You need to enter your Email ID")]
        [DataType(DataType.EmailAddress)]
        public string Email_Id { get; set; }

        [Display(Name = "Confirm Email ID")]
        [Required(ErrorMessage = "You need to Confirm your Email ID")]
        [Compare("Email_Id", ErrorMessage = "Email and Confirm Email must be same")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to enter a password")]
        [MembershipPassword]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "You need to Confirm your password")]
        [MembershipPassword]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must be same")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}