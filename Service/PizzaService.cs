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

    // public static class ExtensionMethods
    // {​​​
    //     public static void Execute()
    //     {​​​
    //         double dollar = 5;
    //         Console.WriteLine(dollar + "$ = " + dollar.ConvertToEur() + "€");
    //     }​​​

    //     public static double ConvertToEur(this double usd)
    //     {​​​
    //         if (usd > 0)
    //         {​​​
    //             return usd * 0.85;
    //         }​​​

    //         return usd;

    //         {​​​

    //         }​​​
    //     }​​​
    // }​​​