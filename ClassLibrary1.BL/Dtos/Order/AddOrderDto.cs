using ClassLibrary1.BL.Dtos.Cart;
using ClassLibrary1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Dtos.Order
{
    public class AddOrderDto
    {
        public IEnumerable<CartItemDto> OrderItems { get; set; }

    }
}
