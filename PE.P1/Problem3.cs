using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Probs
{
    public class Problem3
    {
//        The prime factors of 13195 are 5, 7, 13 and 29.

//What is the largest prime factor of the number 600851475143 ?


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


        public int LargestPrimeFactor(int number)
        {
            int largestPrime = 2;


            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    if (isPrime(i))
                    {
                        if (largestPrime < i)
                        {
                            largestPrime = i;
                        }
                    }
                }
            }
            

            return largestPrime;
        }
    }
}
