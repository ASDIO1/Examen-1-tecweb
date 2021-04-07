using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreAPI.Models;
using StoreAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private IItemsService _itemsService;
        public ItemsController(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }

        [HttpPost]
        public ActionResult<ItemModel> CreateItem([FromBody] ItemModel newItem)
        {
            try
            {
                if (!ModelState.IsValid)            //if invalid
                    return BadRequest(ModelState);

                var item = _itemsService.CreateItem(newItem);
                return Created($"api/items/{item.Id}", item);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        }
    }
}
