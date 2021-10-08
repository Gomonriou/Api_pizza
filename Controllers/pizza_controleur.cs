using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api_pizza.Repository;
using api_pizza.Service;




namespace api_pizza.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PizzaController : ControllerBase
    {

        [HttpGet]
        [Route("{name}")]
        public IEnumerable<Pizza> Get(string name)
        {
            return PizzaService.GetPizzasbytype(name);           
        }

        [HttpGet]
        public IEnumerable<Pizza> GetAll()
        {
            return PizzaService.Getall();
        }

        public static double Convert()
        {
            return PizzaService.ConvertToEur(10);
        }
    }    
}

// try
// {
//     double? p = null;
//     p ??= Predicate;
//     p = null;
//     return p.ConvertToEur();
// }
// catch (Exception e)
// {
//     Console.WriteLine("PriceService: " + e);
// }

// return 0;