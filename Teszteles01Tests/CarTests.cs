using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teszteles01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszteles01.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest1()
        {
            //Arrange
            Car car = new Car("Opel", "Astra", 2010);
            //Act

            //Assert
            Assert.AreEqual("Opel", car.Brand);
        }

        [TestMethod()]
        public void CarTest2()
        {
            //Arrange
            Car car = new Car("Opel", "Astra", 2010);
            //Act
            int expected = 10000;
            //Assert
            Assert.AreEqual(expected, car.Tax);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            Car car = new Car("Opel", "Astra", 2010);
            //Act
            string expected = "Opel Astra (2010) - 10000 Ft";
            //Assert
            Assert.AreEqual(expected, car.ToString());
        }
    }
}