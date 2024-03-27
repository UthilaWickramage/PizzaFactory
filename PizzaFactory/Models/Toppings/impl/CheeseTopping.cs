using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza_Factory.Models.Pizzas;

namespace Pizza_Factory.Models.Toppings.impl
{
    public class CheeseTopping : Topping
    {
        public CheeseTopping(Pizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return Pizza.GetDescription() + " with Cheese Topping";
        }

        public override double GetPrice()
        {
            return Pizza.GetPrice() + 2;
        }
    }
}
