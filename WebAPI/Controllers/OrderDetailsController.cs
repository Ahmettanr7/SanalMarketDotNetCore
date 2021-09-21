using Business.Abstract;
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
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailService _orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _orderDetailService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyisdeliveredisfalse")]
        public IActionResult GetByIsDeliveredIsFalse()
        {
            var result = _orderDetailService.GetByIsDeliveredIsFalse();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyisdeliveredistrue")]
        public IActionResult GetByIsDeliveredIsTrue()
        {
            var result = _orderDetailService.GetByIsDeliveredIsTrue();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getorderhistorybyuserid")]
        public IActionResult GetOrderHistoryByUserId(int userId)
        {
            var result = _orderDetailService.GetOrderHistoryByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyorderid")]
        public IActionResult GetByOrderId(int orderId)
        {
            var result = _orderDetailService.GetByOrderId(orderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _orderDetailService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
