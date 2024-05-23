using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Models;

namespace ClassLibrary1.BL.Dtos.Order
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
