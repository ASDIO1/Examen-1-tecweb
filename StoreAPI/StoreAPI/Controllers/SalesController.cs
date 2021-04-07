using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreAPI.Exceptions;
using StoreAPI.Models;
using StoreAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Controllers
{
    [Route("api/items/{itemId:long}/[Controller]")]
    public class SalesController : Controller
    {
        private ISalesService _salesService;
        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }

        //ENDPOINTS
        [HttpPost()]
        public IActionResult CreateSale(long itemId, [FromBody] SaleModel newSale) //ActionResult<ProductModel>
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
        }

        [HttpGet("income")]  //I didnt use the  itemID and the saleID at the end
        public ActionResult<IEnumerable<IncomeModel>> GetIncome(long itemId, long saleId, string filterBy = "Type")
        {
            try
            {
                var income = _salesService.GetIncome(itemId, saleId, filterBy);
                return Ok(income);
            }
            catch (NotFoundItemException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        }
    }
}
