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
    public class ItemsController : ControllerBase
    {
        IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost("add")]
        public IActionResult Add(Item item)
        {
            var result = _itemService.Add(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _itemService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyitemname")]

        public IActionResult GetByItemName(String itemName)
        {
            var result = _itemService.GetByItemName(itemName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyitemnamepageable")]

        public IActionResult GetByItemNamePageable(string itemName, int pageNo, int pageSize)
        {
            var result = _itemService.GetByItemNamePageable(itemName, pageNo, pageSize);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcategory1id")]

        public IActionResult GetCategory1Id(int cat1Id, int pageNo, int pageSize)
        {
            var result = _itemService.GetCategory1Id(cat1Id, pageNo, pageSize);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getallcategory1id")]

        public IActionResult GetAllCategory1Id(int cat1Id)
        {
            var result = _itemService.GetAllCategory1Id(cat1Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int id)
        {
            var result = _itemService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
