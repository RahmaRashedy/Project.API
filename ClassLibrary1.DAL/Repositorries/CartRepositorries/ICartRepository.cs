using ClassLibrary1.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Models;

namespace ClassLibrary1.DAL.Repositorries.CartRepositorries
{
    public interface ICartRepository : IGenericRepositorries<Cart>
    {
       // IEnumerable<Cart> GetByUserId(int userId);
       // Cart GetByUserIdAndProductId(int userId, int productId);
    }
}
