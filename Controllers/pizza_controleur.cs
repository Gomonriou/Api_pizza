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
        public IEnumerable<Pizza> Get()
        {
            return PizzaService.GetPizzasbytype("orientale");
            
        }

    
    }    
}