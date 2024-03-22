using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models.Pizzas.impl
{
    public class MediumPizza : Pizza
    {
        public override string getDescription()
        {
            return "Medium Pizza";
        }

        public override double getPrice()
        {
            return 12;
        }
    }
}
