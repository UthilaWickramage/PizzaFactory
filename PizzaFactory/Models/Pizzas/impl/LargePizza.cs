using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory.Models.Pizzas.impl
{
    public class LargePizza : Pizza
    {
        private string  Description { get; set; }
        private  double Price { get; set; }
        public LargePizza()
        {
            Description = "Large Pizza";
            Price = 14;
            
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
