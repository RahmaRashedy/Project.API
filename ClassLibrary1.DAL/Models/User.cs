using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace ClassLibrary1.DAL.Models
{
    public class User :IdentityUser
    {
        //public string Username { get; set; }
        //public string PasswordHash { get; set; }
        //public string Email { get; set; }
        public string type { get; set; } = string.Empty;

    }
}
