using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PE.Tests
{
    [TestClass]
    public class Problem7
    {

        [TestMethod]
        public void getprimebyindex_1_2()
        {
            //arrange
            PE.Probs.Problem7 Prob = new Probs.Problem7();

            var expectedres = 2;


            //act
            var res = Prob.GetPrimeByIndex(1);


            //assert
            Assert.AreEqual(expectedres, res);

        }

        [TestMethod]
        public void getprimebyindex_2_3()
        {
            //arrange
            PE.Probs.Problem7 Prob = new Probs.Problem7();

            var expectedres = 3;


            //act
            var res = Prob.GetPrimeByIndex(2);


            //assert
            Assert.AreEqual(expectedres, res);

        }

        [TestMethod]
        public void getprimebyindex_3_5()
        {
            //arrange
            PE.Probs.Problem7 Prob = new Probs.Problem7();

            var expectedres = 5;


            //act
            var res = Prob.GetPrimeByIndex(3);


            //assert
            Assert.AreEqual(expectedres, res);

        }

        [TestMethod]
        public void getprimebyindex_4_7()
        {
            //arrange
            PE.Probs.Problem7 Prob = new Probs.Problem7();

            var expectedres = 7;


            //act
            var res = Prob.GetPrimeByIndex(4);


            //assert
            Assert.AreEqual(expectedres, res);

        }

        [TestMethod]
        public void getprimebyindex_5_11()
        {
            //arrange
            PE.Probs.Problem7 Prob = new Probs.Problem7();

            var expectedres = 11;


            //act
            var res = Prob.GetPrimeByIndex(5);


            //assert
            Assert.AreEqual(expectedres, res);

        }

        [TestMethod]
        public void getprimebyindex_6_13()
        {
            //arrange
            PE.Probs.Problem7 Prob = new Probs.Problem7();

            var expectedres = 13;


            //act
            var res = Prob.GetPrimeByIndex(6);


            //assert
            Assert.AreEqual(expectedres, res);

        }

        [TestMethod]
        public void getprimebyindex_answer()
        {
            //arrange
            PE.Probs.Problem7 Prob = new Probs.Problem7();

            var expectedres = 104743;


            //act
            var res = Prob.GetPrimeByIndex(10001);


            //assert
            Assert.AreEqual(expectedres, res);

        }

    }
}

