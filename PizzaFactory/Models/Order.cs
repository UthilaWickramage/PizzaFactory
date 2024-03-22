using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Models.Pizzas;

namespace PizzaFactory.Models
{
    public class Order
    {
        public double Price { get; set; }
        public double CouponValue { get; set; }
        public double Total { get; set; }
        public List<Pizza> Pizzas { get; set; }

    }
}
