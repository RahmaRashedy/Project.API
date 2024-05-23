using ClassLibrary1.DAL.Data.Context;
using ClassLibrary1.DAL.Models;
using ClassLibrary1.DAL.Repositorries.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Repositorries.CartRepositorries
{
    public class CartRepository : GenericRepositorries<Cart>, ICartRepository
    {
       // protected readonly ProjectContext _context;
        public CartRepository(ProjectContext context) : base(context)
        {
            //_context = context;
        }
        //public IEnumerable<Cart> GetByUserId(int userId)
        //{
        //    return  _context.CartItems.Where(ci => ci.UserId == userId).ToList();
        //}

        //public Cart GetByUserIdAndProductId(int userId, int productId)
        //{
        //    return  _context.CartItems.SingleOrDefault(ci => ci.UserId == userId && ci.ProductId == productId);
        //}
    }
}
