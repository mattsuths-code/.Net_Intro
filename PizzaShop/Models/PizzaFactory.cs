using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Models
{
    public class PizzaFactory
    {
        public List<Pizza> CreatePizzas()
        {
            var pizzaList = new List<Pizza>();

            Pizza hawaiianPizza = new Pizza();
            hawaiianPizza.Name = "Hawaiian";
            hawaiianPizza.Price = 17.99;
            hawaiianPizza.Toppings = new List<string> { "canadian bacon", "pineapple" };
            hawaiianPizza.CrustType = "thin crust";

            Pizza supremePizza = new Pizza
            {
                Name = "Supreme",
                Price = 19.99,
                Toppings = new List<string> { "olives", "peppers", "pepperoni", "onions" },
                CrustType = "regular"
            };


            pizzaList.Add(hawaiianPizza);
            pizzaList.Add(supremePizza);

            return pizzaList;
        }
    }
}
