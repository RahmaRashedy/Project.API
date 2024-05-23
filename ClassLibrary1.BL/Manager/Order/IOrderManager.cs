using ClassLibrary1.BL.Dtos.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Manager.Order
{
    public interface IOrderManager
    {
        void PlaceOrder(AddOrderDto addOrderDto);
        IEnumerable<OrderDto> Viewordershistory();

    }
}
