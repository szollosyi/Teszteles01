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
    public class ProgramTests
    {
        [TestMethod()]
        public void NegyzetTest1()
        {
            //Arrange
            int szam = 2;
            int expected = 4;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NegyzetTest2()
        {
            //Arrange
            int szam = 3;
            int expected = 9;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NegyzetTest3()
        {
            //Arrange
            int szam = 3;
            int expected = 6;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NegyzetTest4()
        {
            //Arrange
            int szam = -3;
            int expected = 9;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}