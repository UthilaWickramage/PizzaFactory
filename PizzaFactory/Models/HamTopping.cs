using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models
{
    public class HamTopping : Topping
    {
        public HamTopping(Pizza pizza):base(pizza)
        {
            
        }
        public override string getDescription()
        {
            return Pizza.getDescription() + " with Ham Topping";
        }

        public override double getPrice()
        {
            return Pizza.getPrice() + 2;
        }
    }
}
