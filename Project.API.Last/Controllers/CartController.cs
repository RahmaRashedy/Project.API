using ClassLibrary1.BL.Dtos.Cart;
using ClassLibrary1.BL.Manager.Cart;
using ClassLibrary1.BL.Manager.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.API.Last.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly IcartManager _cartManager;
        public CartController(IcartManager cartManager)
        {
            _cartManager = cartManager;
        }
        [Authorize]
        [HttpGet]

        public ActionResult<IEnumerable<AddCatrItemDto>> GetAll()
        {
            var cartItems = _cartManager.GetAll();
            return Ok(cartItems);
        }
        [Authorize]
        [HttpPost]
        public ActionResult<AddCatrItemDto> AddToCart(AddCatrItemDto item)
        {
            _cartManager.Add(item);
            return Ok(new { Message = "Product Created Successfully" });

        }
        //[Authorize]
        [HttpPut]
        [Route("{id}")]
        public ActionResult EditCart(int id, UpdateCartItemDto editeCartItemsDot)
        {
            editeCartItemsDot.Id = id;
            _cartManager.Edit(editeCartItemsDot);
            return Ok(editeCartItemsDot);

        }
        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult RemoveFromCart(int id)
        {
            _cartManager.Remove(id);
            return Ok(new { Message = "Product Deleted Successfully" });

        }
    }
}
