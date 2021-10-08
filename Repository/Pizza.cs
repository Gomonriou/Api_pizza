using System;
using System.Collections.Generic;
using api_pizza.Service;

namespace api_pizza.Repository
{
    public class Pizza 
    {
        public int Id {get ; set;}
        public string Nom {get ; set;}
        public string Ingredients {get ; set;}
        public double Price {get ; set;}

        public Pizza (int Id, string Nom, string Ingredients, double Price)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Ingredients = Ingredients;
            this.Price = PriceService.ConvertToEur(Price);
        }
    }

}