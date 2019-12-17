using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Models
{
    public class Pizza : MenuItem
    {
        public List<string> Toppings { get; set; }
        public string CrustType { get; set; }

    }
}
