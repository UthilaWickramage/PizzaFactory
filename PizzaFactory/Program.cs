using Pizza_Factory;
using Pizza_Factory.Factories;
using Pizza_Factory.Models;
using Pizza_Factory.Models.Pizzas;
using Pizza_Factory.Models.Pizzas.impl;
using Pizza_Factory.Models.Toppings.impl;
using System.Data;

public class Program
{
    private static void Main(string[] args)
    {
        bool isOrderDone = false;
        List<Pizza> pizzas = new List<Pizza>();
        Console.WriteLine("-----Welcome to PIZZA FACTORY-----");
        while (!isOrderDone)
        {
            Pizza pizza;

            ColorTools.ColorfulLine("What size of pizza do you want?",ConsoleColor.Cyan);
            string result1 = Console.ReadLine();
            try
            {
                pizza = Pizza_Factory.Factories.PizzaFactory.createPizza(result1);

            }catch(NullReferenceException ex)
            {
                ColorTools.ColorfulLine("Invalid Input", ConsoleColor.Red);
                continue;
            }
       
            while (true)
            {
                ColorTools.ColorfulLine("What topping do you want?",ConsoleColor.Yellow);

                string result2 = Console.ReadLine();
                try
                {
                    pizza = ToppingFactory.addTopping(result2, pizza);

                }
                catch (NullReferenceException ex)
                {
                    ColorTools.ColorfulLine("Invalid Input", ConsoleColor.Red);
                    continue;
                }
             

                ColorTools.ColorfulLine("Do you want more topping?",ConsoleColor.DarkYellow);
                string result3 = Console.ReadLine();
                if (result3.Equals("No"))
                {
                    break;
                }
            }

            ColorTools.ColorfulLine("Do you want more pizza?",ConsoleColor.DarkCyan);
            string result4 = Console.ReadLine();
            if (result4.Equals("No"))
            {
                isOrderDone = true;
            }
          
            pizzas.Add(pizza);
        }

        ColorTools.ColorfulLine("Add coupon price",ConsoleColor.Blue);
        double coupon = double.Parse(Console.ReadLine());
        
        
        Order order = new Order();
        order.Pizzas = pizzas;
        order.CalculatePrice();
        order.CouponValue = coupon;
        order.Total = order.Price - order.CouponValue;
        Console.WriteLine("------CHECKOUT------");
         order.GetDescription();

    }
}