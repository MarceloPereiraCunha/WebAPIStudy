using System.Collections.Generic;
using System.Web.Http;
using WebServiceSample.Models;

namespace WebServiceSample.Controllers
{
    public class HomeController : ApiController
    {


        public IEnumerable<Product> GetItems()
        {
            IList<Product> products = new List<Product>
            {
                new Product
                {
                    productName = "Biscuits",
                    manufacturingYear = 2018,
                    brandName="ParleG"
                },
                new Product
                {
                    productName = "Cars",
                    manufacturingYear = 2018,
                    brandName="BMW"
                },
                new Product
                {
                    productName = "Cars",
                    manufacturingYear = 2018,
                    brandName="Mercedese"
                },
                new Product
                {
                    productName = "Brush",
                    manufacturingYear = 2017,
                    brandName="Colgate"
                }

            };

            return products;
        }
    }


}