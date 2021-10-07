using System;
using System.Collections.Generic;

namespace api_pizza.Repository
{
    public class Pizza 
    {
        public int Id {get ; set;}
        public string Nom {get ; set;}
        public string Ingredients {get ; set;}
        public int Price {get ; set;}

        public Pizza (int Id, string Nom, string Ingredients, int Price)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Ingredients = Ingredients;
            this.Price = Price;
        }
    }

}