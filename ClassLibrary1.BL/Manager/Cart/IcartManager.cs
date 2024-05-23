using ClassLibrary1.BL.Dtos.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Manager.Cart
{
    public interface IcartManager
    {
        void Add(AddCatrItemDto addCartItemsDot);
        IEnumerable<CartItemDto> GetAll();
        void Edit(UpdateCartItemDto editeCartItemsDot);
        void Remove(int id);
    }
}
