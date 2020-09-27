using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.models
{
    //to add new element to identityUser
    public class ApplicationUser : IdentityUser
    {
        public string city { get; set; }
    }
}
