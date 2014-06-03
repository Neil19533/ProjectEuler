using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Probs
{
    class Problem6
    {

        ///The sum of the squares of the first ten natural numbers is,
        ///12 + 22 + ... + 102 = 385
        ///The square of the sum of the first ten natural numbers is,
        ///(1 + 2 + ... + 10)2 = 552 = 3025
        ///Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        ///Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        public int Problem6d(int firstnum, int secondnum)
        {
            int[] numbers = GetNumbers(firstnum, secondnum);


            int SumOfSqares = sumSquares(numbers);
            int SquareOfSum = SquareSum(numbers);

            return SumOfSqares - SquareOfSum;


        }

        private int[] GetNumbers(int firstnum, int secondnum)
        {
            int[] retnums = new int[secondnum - firstnum];

            for (int i = 0; i < retnums.Length; i++)
            {
                retnums[i] = firstnum + i;
            }
            return retnums;
        }

        private int SquareSum(int[] p)
        {
            int retnum = 0;

            foreach (var num in p)
            {
                retnum += num;
            }

            retnum = (int)Math.Pow(retnum, 2);

            return retnum;
        }

        private int sumSquares(int[] Numbers)
        {
            int returnnum = 0;

            foreach (var num in Numbers)
            {
                returnnum += (int)Math.Pow(num, 2);
            }

            return returnnum;
        }


    }
}
