using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Probs
{
    public class Problem7
    {
//        By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

//What is the 10 001st prime number?


        public int GetPrimeByIndex(int index)
        {

            int i = 0;
            int num =0;
            while(i<index)
            {

                num++;

                if (isPrime(num))
                {

                    i++;

                }

                


            }

            return num;

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
