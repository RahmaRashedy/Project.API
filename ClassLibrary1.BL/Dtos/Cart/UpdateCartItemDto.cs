﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Dtos.Cart
{
    public class UpdateCartItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
