using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Models.Pizzas;

namespace PizzaFactory.Models.Toppings
{
    public abstract class Topping : Pizza
    {
        protected Pizza Pizza { get; set; }

        public Topping(Pizza pizza)
        {
            Pizza = pizza;

        }
    }
}
