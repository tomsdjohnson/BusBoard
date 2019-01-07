using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController
    {
    
        public IEnumerable<List<Station>> GetAllProducts()
        {
            yield return GetAllStations.Get();
        }

    }
}
