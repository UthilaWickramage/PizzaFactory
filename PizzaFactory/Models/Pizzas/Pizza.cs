using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models.Pizzas
{
    public abstract class Pizza
    {
        protected string Description { get; set; }
        protected double Price { get; set; }

        public abstract double getPrice();

        public abstract string getDescription();
    }
}
