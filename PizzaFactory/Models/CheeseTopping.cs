using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models
{
    public class CheeseTopping : Topping
    {
        public CheeseTopping(Pizza pizza):base(pizza)
        {
            
        }
        public override string getDescription()
        {
            return Pizza.getDescription() + " with Cheese Topping";
        }

        public override double getPrice()
        {
            return Pizza.getPrice() + 2;
        }
    }
}
