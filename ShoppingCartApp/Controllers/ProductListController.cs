using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.BusinessLayer;
using ShoppingCartApp.BusinessLayer.Models;

namespace ShoppingCartApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListController : ControllerBase
    {
        private ProductBL pbl = new ProductBL();

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            List<ProductModel> products = await pbl.GetAllProductList();
            return Ok(products);
        }
    }
}
