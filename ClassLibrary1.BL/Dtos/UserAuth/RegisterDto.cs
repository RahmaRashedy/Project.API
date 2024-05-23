using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Dtos.UserAuth
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }

        public RegisterDto(string userName, string email, string type, string password)
        {
            UserName = userName;
            Email = email;
            Type = type;
            Password = password;
        }
    }

}
