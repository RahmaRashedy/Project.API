using ClassLibrary1.BL.Dtos.Order;
using ClassLibrary1.DAL.Repositorries.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Models;

namespace ClassLibrary1.BL.Manager.Order
{
    public class OrderManager : IOrderManager
    {
    private readonly IUnitOfWork _unitofwork;
    public OrderManager(IUnitOfWork unitOfWork)
    {
        _unitofwork = unitOfWork;

    }
        public void PlaceOrder(AddOrderDto addOrderDto)
        {
            decimal totalPrice = 0;
            foreach (var item in addOrderDto.OrderItems)
            {
                decimal productPrice = _unitofwork.ProductRepository.GetPriceById(item.ProductId);
                totalPrice += productPrice * item.Quantity;
            }
            var order = new DAL.Models.Order
            {
                CreatedAt = DateTime.Now,
                TotalPrice = totalPrice,
                OrderItems = addOrderDto.OrderItems
           .Select(x => new DAL.Models.Cart
           {
               ProductId = x.ProductId,
               Quantity = x.Quantity
           }).ToList()
            };
            _unitofwork.OrderRepository.Add(order);
            _unitofwork.Savechages();
        }

        public IEnumerable<OrderDto> Viewordershistory()
        {
            var order = _unitofwork.OrderRepository.GetAll();
            return order.Select(o => new OrderDto
            {
                Id = o.Id,
                CreatedAt = DateTime.Now,
                TotalPrice = o.TotalPrice
            });
        }
    }
}
