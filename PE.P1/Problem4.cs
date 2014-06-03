using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Probs
{
    public class Problem4
    {
//        A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

//Find the largest palindrome made from the product of two 3-digit numbers.

        public int Problem4d(int FirstNumberCount, int SecondNumberCount)
        {
            int firstlownum = LowestNum(FirstNumberCount);
            int firsthighnum = HighestNum(FirstNumberCount);

            int secondlownum = LowestNum(SecondNumberCount);
            int secondhighnum = HighestNum(SecondNumberCount);

            List<int> pdromes = new List<int>();

            for (int first = firstlownum; first < firsthighnum + 1; first++)
            {

                for (int second = secondlownum; second < secondhighnum; second++)
                {
                    int nnum = first * second;
                    if (isPdrome(nnum))
                    {
                        pdromes.Add(nnum);

                    }

                }



            }


            var sorted = pdromes.ToList();
            sorted.Sort();

            return sorted.Last();
        }

        public bool isPdrome(int nnum)
        {

            char[] arr = nnum.ToString().ToCharArray();

            Array.Reverse(arr);

            string reversed = new string(arr);

            if (nnum == int.Parse(reversed))
            {
                return true;
            }
            return false;
        }

        private static int HighestNum(int NumberCount)
        {
            return (int)Math.Pow(10, (NumberCount)) - 1;
        }

        private static int LowestNum(int NumberCount)
        {
            return (int)Math.Pow(10, (NumberCount - 1));
        }

    }
}
