using System;
using ShoppingCartApp.DataAccessLayer.Interfaces;
using ShoppingCartApp.DataAccessLayer.Functions;
using ShoppingCartApp.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace ShoppingCartApp.BusinessLayer
{
    public class ProductBL
    {
        private IProductList productList = new ProductListFunction();

        public async Task<List<Product>> GetAllProductList()
        {
            List<Product> productAllList = await productList.GetAllProductList();
            return productAllList;
        }
    }
}
