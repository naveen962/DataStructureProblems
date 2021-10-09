using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumber2D
{
    class Prime2D
    {
        public static bool isPrime(int n)
        {

            if (n == 0 || n == 1)
            {

                return false;

            }

            int i = 2;

            while (i <= n / 2)
            {

                if (n % i == 0)
                {

                    return false;

                }

                i++;

            }

            return true;

        }

    }
}
