using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.BusinessLayer;
using ShoppingCartApp.BusinessLayer.Models;
using ShoppingCartApp.BusinessLayer.Services;

namespace ShoppingCartApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListController : ControllerBase
    {
        private ProductBL pbl = new ProductBL();
        private readonly IProductService _service;

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{

        //    List<ProductModel> products = await pbl.GetAllProductList();
        //    return Ok(products);
        //}
        public ProductListController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            List<ProductModel> products = await _service.GetAllProductList();
            return Ok(products);
        }
    }
}
