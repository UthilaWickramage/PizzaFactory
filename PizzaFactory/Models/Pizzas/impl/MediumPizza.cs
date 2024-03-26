using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models.Pizzas.impl
{
    public class MediumPizza : Pizza
    {
        private string Description { get; set; }
        private double Price { get; set; }
        public MediumPizza()
        {
            Description = "Medium Pizza";
            Price = 12;
        }

        public override double GetPrice()
        {

            return Price;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
