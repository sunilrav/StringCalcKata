using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalcKata.Console.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Add_EmptyString_ReturnZero()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add("");

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_SingleNumber1_Returns1()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add("1");

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Add_SingleNumber1091_Returns1091()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add("1091");

            //Assert
            Assert.AreEqual(1091, result);
        }

        [TestMethod]
        public void Add_TwoNumbers1And2_Returns3()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add("1,2");

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_TwoNumbers50And51_Returns101()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add("50,51");

            //Assert
            Assert.AreEqual(101, result);
        }

        [TestMethod]
        public void Add_ThreeNumbers10And21And15_Returns46()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add("10,21,15");

            //Assert
            Assert.AreEqual(46, result);
        }

        [TestMethod]
        public void Add_ThreeNumbers10And21And15WithNewLineDemilter_Returns46()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add("10\n21\n15");

            //Assert
            Assert.AreEqual(46, result);
        }
    }
}
