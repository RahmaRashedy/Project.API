using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Dtos.UserAuth
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginDto(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }

}
