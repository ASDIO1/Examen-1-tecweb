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
    [Route("api/items/{saleId:long}/[Controller]")]
    public class SalesController : Controller
    {
        private ISalesService _salesService;
        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }

        //ENDPOINTS
       /* [HttpPost]
        public ActionResult<SaleModel> CreateSale(long itemId, [FromBody] SaleModel newSale)
        {
            try
            {
                if (!ModelState.IsValid)//Validates if Model restrictions are fullfiled
                {
                    return BadRequest(ModelState);
                }
                var createdSale = _salesService.CreateSale(itemId, newSale);
                return Created($"api/items/{itemId}/{createdSale.Id}", createdSale);
            }
            catch (NotFoundItemException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        }*/
    }
}
