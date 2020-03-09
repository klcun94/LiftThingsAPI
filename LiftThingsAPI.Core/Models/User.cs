using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace LiftThingsAPI.Core.Models
{
    public class User : IdentityUser, IEntity<string>
    {
        public ClaimsIdentity id;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string Id { get; set; }
    }
}
