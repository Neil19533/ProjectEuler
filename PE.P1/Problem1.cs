using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Probs
{
    /// <summary>
    /// 
    ///     If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    ///     Find the sum of all the multiples of 3 or 5 below 1000.
    ///
    /// </summary>
    public class Problem1
    {

        public int Multiples(int StartNumber, int EndNumber, int[] Multiples)
        {

            List<int> numbers = new List<int>();

            for (int i = StartNumber; i < EndNumber; i++)
            {
                foreach (var multiple in Multiples)
                {
                    if (i % multiple == 0)
                    {
                        if(!numbers.Contains(i))
                        numbers.Add(i);
                    }
                }
            }


            int sum = SumNumbers(numbers);

            return sum;
        }

        private int SumNumbers(List<int> numbers)
        {
            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }


}
