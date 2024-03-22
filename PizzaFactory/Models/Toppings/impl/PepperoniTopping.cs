using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Models.Pizzas;

namespace PizzaFactory.Models.Toppings.impl
{
    public class PepperoniTopping : Topping
    {
        public PepperoniTopping(Pizza pizza) : base(pizza)
        {

        }
        public override string getDescription()
        {
            return Pizza.getDescription() + " with Pepperoni Topping";
        }

        public override double getPrice()
        {
            return Pizza.getPrice() + 2;
        }
    }
}
