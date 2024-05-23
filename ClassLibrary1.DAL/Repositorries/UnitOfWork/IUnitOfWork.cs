using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Repositorries.CartRepositorries;
using ClassLibrary1.DAL.Repositorries.OrderRepositorries;
using ClassLibrary1.DAL.Repositorries.ProductRepositorries;

namespace ClassLibrary1.DAL.Repositorries.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }

        public ICartRepository CartRepository { get; }
        void Savechages();
    }
}
