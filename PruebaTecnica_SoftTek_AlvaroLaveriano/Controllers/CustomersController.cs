using PruebaTecnica_SoftTek_AlvaroLaveriano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaTecnica_SoftTek_AlvaroLaveriano.Controllers
{
    [Authorize]
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetId(int id)
        {
            var customerFake = "customer-fake";
            return Ok(customerFake);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var products = new List<Ventas> { 
                new Ventas { producto = "Producto 1",
                             cantidad = "2",
                             impUnitario = "10",
                             impTotal = "20"},
                new Ventas { producto = "Producto 2",
                             cantidad = "5",
                             impUnitario = "15",
                             impTotal = "75"},
                new Ventas { producto = "Producto 3",
                             cantidad = "10",
                             impUnitario = "5",
                             impTotal = "50"}
            };

            return Ok(products);
        }
    }
}
