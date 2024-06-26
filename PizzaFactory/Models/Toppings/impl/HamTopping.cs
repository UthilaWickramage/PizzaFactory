﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza_Factory.Models.Pizzas;

namespace Pizza_Factory.Models.Toppings.impl
{
    public class HamTopping : Topping
    {
        public HamTopping(Pizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return Pizza.GetDescription() + " with Ham Topping";
        }

        public override double GetPrice()
        {
            return Pizza.GetPrice() + 2;
        }
    }
}
