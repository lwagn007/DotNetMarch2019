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
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actual = calcRepo.AddTwoNumbers(1, 1);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
