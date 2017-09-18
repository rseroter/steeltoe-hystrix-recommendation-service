using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core_hystrix_recommendation_service;

namespace core_hystrix_recommendation_service.Controllers
{
    [Route("api/[controller]")]
    public class RecommendationsController : Controller
    {
        // GET api/recommendations
        [HttpGet]
        public IEnumerable<Recommendations> Get()
        {   
            Recommendations r1 = new Recommendations();
            r1.ProductId = "10023";
            r1.ProductDescription = "Women's Triblend T-Shirt";
            r1.ProductImage = "https://cdn.shopify.com/s/files/1/0692/5669/products/charcoal_pivotal_grande_43987370-6045-4abf-b81c-b444e4c481bc_1024x1024.png?v=1503505687";

            Recommendations r2 = new Recommendations();
            r2.ProductId = "10040";
            r2.ProductDescription = "Men's Bring Back Your Weekend T-Shirt";
            r2.ProductImage = "https://cdn.shopify.com/s/files/1/0692/5669/products/m2_1024x1024.png?v=1503525900";

            Recommendations r3 = new Recommendations();
            r3.ProductId = "10057";
            r3.ProductDescription = "H2Go Force Water Bottle";
            r3.ProductImage = "https://cdn.shopify.com/s/files/1/0692/5669/products/Pivotal-Black-Water-Bottle_1024x1024.png?v=1442486197";

            Recommendations r4 = new Recommendations();
            r4.ProductId = "10059";
            r4.ProductDescription = "Migrating to Cloud Native Application Architectures by Matt Stine";
            r4.ProductImage = "https://cdn.shopify.com/s/files/1/0692/5669/products/migrating_1024x1024.png?v=1458083725";

            return new Recommendations[] { r1, r2, r3, r4 };
        }
    }
}
