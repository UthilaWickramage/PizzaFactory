using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models.Pizzas.impl
{
    public class LargePizza : Pizza
    {

        public override string getDescription()
        {
            return "Large Pizza";
        }

        public override double getPrice()
        {
            return 14;
        }
    }
}
