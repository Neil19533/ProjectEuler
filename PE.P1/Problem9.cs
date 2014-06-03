using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Probs
{

        //    A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

        //a2 + b2 = c2

        //For example, 32 + 42 = 9 + 16 = 25 = 52.

        //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        //Find the product abc.

    public class Problem9
    {

        List<int> SquareNumbers = new List<int>();

        public void GetSquareNumbers(int Max)
        {
            int currentproduct = 1;
            int currentnum = 1;
            while(currentproduct < Max)
            {
                currentproduct = (int)Math.Pow(currentnum, 2);

                SquareNumbers.Add(currentproduct);
                currentnum++;
            }
        }


        public void Sum()
        {
            foreach (var item in SquareNumbers)
            {

                
            }
        }
        
    }
}
