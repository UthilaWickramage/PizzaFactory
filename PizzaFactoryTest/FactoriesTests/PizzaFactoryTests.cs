using Pizza_Factory.Factories;
using Pizza_Factory.Models.Pizzas.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTest.FactoriesTests
{
    public class PizzaFactoryTests
    {
        [Fact]
        public void PizzaFactory_CreatePizza_IsLargePizza()
        {
            //Arrange
            //Act
            var pizza = PizzaFactory.createPizza("Large");

            //Assert
            Assert.IsType<LargePizza>(pizza);

        }
        [Fact]
        public void PizzaFactory_CreatePizza_IsMediumPizza()
        {
            //Arrange
            //Act
           var pizza =  PizzaFactory.createPizza("Medium");

            //Assert
            Assert.IsType<MediumPizza>(pizza);
        }
        [Fact]
        public void PizzaFactory_CreatePizza_IsSmallPizza()
        {
            //Arrange
            //Act
            var pizza = PizzaFactory.createPizza("Small");

            //Assert
            Assert.IsType<SmallPizza>(pizza);
        }
    }
}
