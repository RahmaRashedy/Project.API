using ClassLibrary1.BL.Dtos.Cart;
using ClassLibrary1.BL.Manager.Order;
using ClassLibrary1.DAL.Repositorries.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Models;

namespace ClassLibrary1.BL.Manager.Cart
{
    public class CartManager : IcartManager
    {
       
            private readonly IUnitOfWork _unitofwork;
            public CartManager(IUnitOfWork unitOfWork)
            {
                _unitofwork = unitOfWork;

            }
         public void Add(AddCatrItemDto addCartItemsDot)
        {
            var cart = new DAL.Models.Cart
            {
                ProductId = addCartItemsDot.ProductId,
                Quantity = addCartItemsDot.Quantity
            };
            _unitofwork.CartRepository.Add(cart);

            _unitofwork.Savechages();

        }

        public void Edit(UpdateCartItemDto editeCartItemsDot)
        {
            var cartItem = _unitofwork.CartRepository.GetById(editeCartItemsDot.Id);
            if (cartItem == null) { return; }


            cartItem.Quantity = editeCartItemsDot.Quantity;
            _unitofwork.CartRepository.Update(cartItem);
            _unitofwork.Savechages();
        }

        public IEnumerable<CartItemDto> GetAll()
        {
            var cartItems = _unitofwork.CartRepository.GetAll();
            return cartItems.Select(x => new CartItemDto
            {
                Id = x.Id,
                Quantity = x.Quantity,
                ProductId = x.ProductId
            });
        }

        public void Remove(int id)
        {
            var cart = _unitofwork.CartRepository.GetById(id);
            if (cart == null) { return; }
            _unitofwork.CartRepository.Delete(cart);
            _unitofwork.Savechages();
        }
    }
}
