using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Probs
{
    public class Problem10
    {

        //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        //Find the sum of all the primes below two million.


        public int GetSumOfPrimes(int PrimesBelow)
        {
            int sum = 0;
            //getprimes
            for (int i = 0; i < PrimesBelow; i++)
            {

                //sumprimes
                if (isPrime(i))
                    sum += i;
            }
            
            return sum;
        }

        public bool isPrime(int number)
        {
            if (number > 1)
            {

                if (number == 2)
                {
                    return true;
                }

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;

            }
            return false;
        }

    }
}
