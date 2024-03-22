using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models
{
    public class PepperoniTopping : Topping
    {
        public PepperoniTopping(Pizza pizza):base(pizza)
        {
            
        }
        public override string getDescription()
        {
            return Pizza.getDescription()+ " with Pepperoni Topping";
        }

        public override double getPrice()
        {
            return Pizza.getPrice()+2;
        }
    }
}
