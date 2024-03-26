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

        public void GetDescription() {
            ColorTools.ColorfulLine("IPizza total price = " + Price, ConsoleColor.Green);
            ColorTools.ColorfulLine("----Your Order----", ConsoleColor.Magenta);
            Console.WriteLine();
            foreach (var item in Pizzas)
            {
                Console.WriteLine(item.GetDescription());
            }
            Console.WriteLine();

            ColorTools.ColorfulLine("Coupon Price = " + CouponValue, ConsoleColor.Green);
            ColorTools.ColorfulLine("Total Price = " + Total, ConsoleColor.White);

        }

        public void CalculatePrice()
        {
            foreach (var item in Pizzas)
            {
                Price += item.GetPrice();
            }
        }

    }
}
