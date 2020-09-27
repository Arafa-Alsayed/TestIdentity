using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.models
{
    public class MyCustomValidationAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value !=null)
            {
                string email = value.ToString();
                if(email.Contains("@yahoo"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "email should contain @yahoo");
        }
        /// <summary>
        /// //////////////////////////////////
        /// </summary>
        //private readonly string allowedDomain;

        //public MyCustomValidationAttribute(string allowedDomain)
        //{
        //    this.allowedDomain = allowedDomain;
        //}

        //public override bool IsValid(object value)
        //{
        //    string[] strings = value.ToString().Split('@');
        //    return strings[1].ToUpper() == allowedDomain.ToUpper();
        //}
    }
}
