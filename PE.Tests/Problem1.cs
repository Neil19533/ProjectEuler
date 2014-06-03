using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PE.Tests
{
    [TestClass]
    public class Problem1
    {
        [TestMethod]
        public void GivenExample()
        {
            //Arrange
            PE.Probs.Problem1 Problem1 = new Probs.Problem1();

            int Problem1GivenResult = 23;

            //Act
            int ActualResult = Problem1.Multiples(0, 10, new int[] { 3, 5 });

            //Assert
            Assert.AreEqual(Problem1GivenResult, ActualResult, "The given example is not correct.");

        }

        [TestMethod]
        public void Given3multiples()
        {
            //Arrange
            PE.Probs.Problem1 Problem1 = new Probs.Problem1();

            int Problem1GivenResult = 37;

            //Act
            int ActualResult = Problem1.Multiples(0, 10, new int[] { 2, 3, 5 });

            //Assert
            Assert.AreEqual(Problem1GivenResult, ActualResult);
        }
    }
}
