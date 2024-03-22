using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models.Pizzas.impl
{
    public class SmallPizza : Pizza
    {
        public override string getDescription()
        {
            return "Small Pizza";
        }

        public override double getPrice()
        {
            return 10;
        }
    }
}
