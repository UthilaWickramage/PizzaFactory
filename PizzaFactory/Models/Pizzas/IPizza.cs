using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models.Pizzas
{
    public abstract class Pizza
    {
       
        public abstract double GetPrice();

        public abstract string GetDescription();
    }
}
