using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.models.ViewModels
{
    public class RegisterViewModel
    {
        //  [Required]
        // [EmailAddress]
        [MyCustomValidation]
       // [Remote(action:"IsEmailInUse",controller:"home")]
        //  [MyCustomValidation(allowedDomain: "pragimtech.com",
        //ErrorMessage = "Email domain must be pragimtech.com")]
       
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="password not match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string city { get; set; }
    }
}
