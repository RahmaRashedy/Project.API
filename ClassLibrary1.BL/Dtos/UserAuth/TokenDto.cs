using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Dtos.UserAuth
{
    public class TokenDto
    {
        public string Token { get; set; }
        public DateTime Expiry { get; set; }

        public TokenDto(string token, DateTime expiry)
        {
            Token = token;
            Expiry = expiry;
        }
    }

}
