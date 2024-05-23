using ClassLibrary1.BL.Dtos.Order;
using ClassLibrary1.BL.Manager.Order;
using ClassLibrary1.BL.Manager.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.API.Last.Controllers
{
      [Route("api/[controller]")]
      [ApiController]
    public class OrderController : Controller
    {
            private readonly IOrderManager _orderManager;
            public OrderController(IOrderManager orderManager)
            {
                _orderManager = orderManager;
            }
        [Authorize]
        [HttpPost]
        public ActionResult<AddOrderDto> AddToCart(AddOrderDto item)
        {
            _orderManager.PlaceOrder(item);
            return Ok(new { Message = "Order Created Successfully" });

        }
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<OrderDto>> GetAll()
        {
            var orders = _orderManager.Viewordershistory();
            return Ok(orders);
        }

    }
}
