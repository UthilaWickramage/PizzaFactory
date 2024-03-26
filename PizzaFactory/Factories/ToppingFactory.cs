using PizzaFactory.Models.Pizzas;
using PizzaFactory.Models.Toppings.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Factories
{
    public static class ToppingFactory
    {
public static Pizza addTopping(string input, Pizza pizza)
        {
        
            if (input.Equals("Ham"))
            {
                return new HamTopping(pizza);
            }
            else if (input.Equals("Pepperoni"))
            {
                return new PepperoniTopping(pizza);
            }
            else if (input.Equals("Cheese"))
            {
                return new CheeseTopping(pizza);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
