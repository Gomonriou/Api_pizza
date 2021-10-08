using System;
using System.Collections.Generic;
using api_pizza.Repository;
using System.Linq;

namespace api_pizza.Service
{
    public static class PriceService
    {
        public static double ConvertToEur( this double usd )
        {
            return Math.Round(usd * 0.85, 2);
        }
    }

}