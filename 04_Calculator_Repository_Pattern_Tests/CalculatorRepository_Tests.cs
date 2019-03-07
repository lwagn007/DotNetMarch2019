using System;
using _04_Calculator_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Calculator_Repository_Pattern_Tests
{
    [TestClass]
    public class CalculatorRepository_Tests
    {
        [TestMethod]
        public void CalculatorRepository_AddTwoNumbers_ShouldBeCorrectInt()
        {
            // Arrange 
            CalculatorRepository calcRepo = new CalculatorRepository();

            // Act
            int actual = calcRepo.AddTwoNumbers(1, 1);

            // Assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void CalculatorRepository_SubtractTwoNumbers_ShouldBeCorrectInt()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actual = calcRepo.SubtractTwoNumbers(1, 1);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void CalculatorRepository_MultiplyTwoNumbers_ShouldBeCorrectInt()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.MultiplyTwoNumbers(1, 1);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void CalculatorRepository_DivideTwoNumbers_ShouldBeCorrectInt()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.DivideTwoNumbers(1,1);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void CalculatorRepository_RemainderOfTwoNumbers_ShouldBeCorrectInt()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.RemainderOfTwoNumbers(10, 3);
            Assert.AreEqual(1, actual);
        }
    }
}
