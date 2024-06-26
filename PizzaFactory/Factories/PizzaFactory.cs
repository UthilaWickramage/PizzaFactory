﻿using Pizza_Factory.Models.Pizzas;
using Pizza_Factory.Models.Pizzas.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory.Factories
{
    public static class PizzaFactory
    {
     
        public static Pizza createPizza(string input)
        {
            if (input.Equals("Large"))
            {
                return new LargePizza();
            }
            else if (input.Equals("Medium"))
            {
                return new MediumPizza();
            }
            else if (input.Equals("Small"))
            {
                return new SmallPizza();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
