using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PE.Tests
{
    [TestClass]
    public class Problem3
    {
        [TestMethod]
        public void Problem3_SimpleTest()
        {
            //arrange
            Probs.Problem3 Prob3 = new Probs.Problem3();

            int calnum = 24;
            int expectedRes = 3;


            //act
            int res = Prob3.LargestPrimeFactor(calnum);

            //assert
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void Problem3_LargeNumTest()
        {
            //arrange
            Probs.Problem3 Prob3 = new Probs.Problem3();

            int calnum = 457654;
            int expectedRes = 9949;


            //act
            int res = Prob3.LargestPrimeFactor(calnum);

            //assert
            Assert.AreEqual(expectedRes, res);
        }
    }
}
