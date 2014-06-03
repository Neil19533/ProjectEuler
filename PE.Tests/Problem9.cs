using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PE.Tests
{
    [TestClass]
    public class Problem9
    {
        [TestMethod]
        public void CheckMultea()
        {
            //Arrange
            PE.Probs.Problem9 problem9 = new Probs.Problem9();

            //Action

            problem9.GetSquareNumbers(1000);

            //Assert
        }
    }
}
