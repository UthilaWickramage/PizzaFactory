using PizzaFactory;
using PizzaFactory.Models;
using PizzaFactory.Models.Pizzas;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isOrderDone = false;
        List<Pizza> pizzas = new List<Pizza>();
        while (!isOrderDone)
        {
            Pizza pizza;
            ColorTools.ColorfulLine("What size of pizza do you want?",ConsoleColor.Cyan);
            string result1 = Console.ReadLine();
            if(result1.Equals("Large"))
            {
                pizza = new LargePizza();
            }else if(result1.Equals("Medium"))
            {
                pizza = new MediumPizza();
            }else if(result1.Equals("Small"))
            {
                pizza = new SmallPizza();
            }
            else
            {
                ColorTools.ColorfulLine("Invalid Input",ConsoleColor.Red);
                continue;
            }

            while (true)
            {
                ColorTools.ColorfulLine("What topping do you want?",ConsoleColor.Yellow);

                string result2 = Console.ReadLine();
                if (result2.Equals("Ham"))
                {
                    pizza = new HamTopping(pizza);
                }
                else if (result2.Equals("Pepperoni"))
                {
                    pizza = new PepperoniTopping(pizza);
                }
                else if (result2.Equals("Cheese"))
                {
                    pizza = new CheeseTopping(pizza);
                }
                else
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
        
        double pizzaTotalPrice = 0;
        foreach (var item in pizzas)
        {
            pizzaTotalPrice+= item.getPrice();
        }
        Order order = new Order();
        order.Price = pizzaTotalPrice;
        order.Pizzas = pizzas;
        order.CouponValue = coupon;
        order.Total = order.Price - order.CouponValue;
        Console.WriteLine("------CHECKOUT------");
        ColorTools.ColorfulLine("Pizza total price = "+pizzaTotalPrice, ConsoleColor.Green);
        ColorTools.ColorfulLine("----Your Order----",ConsoleColor.Magenta);
        foreach (var item in order.Pizzas)
        {
            Console.WriteLine(item.getDescription());
        }

        ColorTools.ColorfulLine("Coupon Price = "+order.CouponValue,ConsoleColor.Green);
        ColorTools.ColorfulLine("Total Price = "+order.Total,ConsoleColor.White);


    }
}