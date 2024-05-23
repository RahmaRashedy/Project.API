using ClassLibrary1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Models;
using ClassLibrary1.DAL.Repositorries.Generic;

namespace ClassLibrary1.DAL.Repositorries.OrderRepositorries
{
    public interface IOrderRepository : IGenericRepositorries<Order>
    {
        //IEnumerable<Order> GetByUserId(int userId);
    }
}
