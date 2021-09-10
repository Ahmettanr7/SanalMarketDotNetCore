using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("getallbyuserid")]

        public IActionResult GetAllByUserId(int userId)
        {
            var result = _cartService.GetAllByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        
        [HttpGet("getallbyuseridandcartstatusistrue")]

        public IActionResult GetAllByUserIdAndCartStatusIsTrue(int userId)
        {
            var result = _cartService.GetAllByUserIdAndCartStatusIsTrue(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbyuseridandcartstatusisfalse")]

        public IActionResult GetAllByUserIdAndCartStatusIsFalse(int userId)
        {
            var result = _cartService.GetAllByUserIdAndCartStatusIsFalse(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyuseridtotalcartprice")]

        public IActionResult GetByUserIdTotalCartPrice(int userId)
        {
            var result = _cartService.GetByUserIdTotalCartPrice(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Cart cart)
        {
            var result = _cartService.Add(cart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("decreasead")]
        public IActionResult DecreaseAd(int userId, int itemId)
        {
            var result = _cartService.DecreaseAd(userId, itemId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("decreasekg")]
        public IActionResult DecreaseKg(int userId, int itemId)
        {
            var result = _cartService.DecreaseKg(userId, itemId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("increasead")]
        public IActionResult IncreaseAd(int userId, int itemId)
        {
            var result = _cartService.IncreaseAd(userId, itemId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("increasekg")]
        public IActionResult IncreaseKg(int userId, int itemId)
        {
            var result = _cartService.IncreaseKg(userId, itemId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _cartService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
