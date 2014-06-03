using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PE.Tests
{
    [TestClass]
    public class Problem10
    {
        [TestMethod]
        public void SumPrimesSample()
        {
            //arrange
            PE.Probs.Problem10 prob = new Probs.Problem10();

            int expected = 17;


            //act
            int result = prob.GetSumOfPrimes(10);

            //assert

            Assert.AreEqual(expected, result);
        }

        //[TestMethod]
        //public void problem()
        //{
        //    //arrange
        //    PE.Probs.Problem10 prob = new Probs.Problem10();

        //    int expected = 17;


        //    //act
        //    int result = prob.GetSumOfPrimes(2000000);

        //    //assert

        //    Assert.AreEqual(expected, result);
        //}
    }
}
