using Pizza_Factory.Factories;
using Pizza_Factory.Models.Pizzas.impl;
using Pizza_Factory.Models.Toppings.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTest.FactoriesTests
{
    public class ToppingFactoryTests
    {
        [Fact]
        public void ToppingFactory_AddTopping_IsCheeseTopping()
        {
            //Arrange
            LargePizza largePizza = new LargePizza();
            //Act
            var cheeseTopping = ToppingFactory.addTopping("Cheese",largePizza);

            //Assert
            Assert.IsType<CheeseTopping>(cheeseTopping);
        }

        [Fact]
        public void ToppingFactory_AddTopping_IsHamTopping()
        {
            //Arrange
            LargePizza largePizza = new LargePizza();
            //Act
            var hamTopping = ToppingFactory.addTopping("Ham", largePizza);

            //Assert
            Assert.IsType<HamTopping>(hamTopping);
        }

        [Fact]
        public void ToppingFactory_AddTopping_IsPepperoniTopping()
        {
            //Arrange
            LargePizza largePizza = new LargePizza();
            //Act
            var pepperoniTopping = ToppingFactory.addTopping("Pepperoni", largePizza);

            //Assert
            Assert.IsType<PepperoniTopping>(pepperoniTopping);
        }
    }
}
