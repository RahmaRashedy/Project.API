using ClassLibrary1.DAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Models;
using ClassLibrary1.DAL.Data;
using ClassLibrary1.DAL.Repositorries.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.DAL.Repositorries.OrderRepositorries
{
    public class OrderRepository : GenericRepositorries<Order>, IOrderRepository
    {
        protected readonly ProjectContext _context;
        public OrderRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        //public IEnumerable<Order> GetByUserId(int userId)
        //{
        //    return  _context.Orders.Where(o => o.UserId == userId).Include(o => o.OrderItems).ToList();
        //}
    }
}
