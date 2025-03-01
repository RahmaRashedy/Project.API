﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        //public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalPrice { get; set; }

        //public User User { get; set; }
        public ICollection<Cart> OrderItems { get; set; } = [];

    }
}
