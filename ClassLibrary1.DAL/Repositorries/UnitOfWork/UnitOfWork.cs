using ClassLibrary1.DAL.Data.Context;
using ClassLibrary1.DAL.Repositorries.CartRepositorries;
using ClassLibrary1.DAL.Repositorries.OrderRepositorries;
using ClassLibrary1.DAL.Repositorries.ProductRepositorries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Repositorries.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ProjectContext _context;

        public IProductRepository ProductRepository { get; }

        public IOrderRepository OrderRepository { get; }

        public ICartRepository CartRepository { get; }
        public UnitOfWork(ProjectContext context, IProductRepository productReopsitry,
      IOrderRepository orderReopsitry, ICartRepository cartReopsitry)
        {
            _context = context;
            ProductRepository = productReopsitry;
            OrderRepository = orderReopsitry;
            CartRepository = cartReopsitry;
        }
        public void Savechages()
        {
            _context.SaveChanges();

        }
    }


}

