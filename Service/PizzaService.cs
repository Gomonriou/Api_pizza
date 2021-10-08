using System;
using System.Collections.Generic;
using api_pizza.Repository;
using System.Linq;

namespace api_pizza.Service
{
    public static class PizzaService
    {
        public static IEnumerable<Pizza> GetPizzasbytype(string type)
        {
            IEnumerable<Pizza> query = 
                from n in PizzaRepository.GetPizzas()
                where n.Nom.Contains(type)
                select n;
            
            return query;
        }

        public static IEnumerable<Pizza> Getall()
        {
            IEnumerable<Pizza> query = 
                from n in PizzaRepository.GetPizzas()
                select n;
            
            return query;
        }

        
    }
    
}