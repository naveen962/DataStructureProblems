using System;

namespace PrimeNumber2D
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int [,]prime = new int[10,2];  //creation of 2d array

            int k = 0;

            int count = 0;  //to count how many prime number is there

            for (int i = 0; i <= 1000; i++)
            {

                bool x =Prime2D.isPrime(i);

                if (x)
                {

                    count++;

                }

                if (i % 100 == 0 && i != 0)
                {

                    prime[k,0] = i;

                    prime[k,1] = count;

                    count = 0;

                    k++;

                }

            }

            int j = 0;

            while (j < 2)
            {

                for (int n = 0; n < 10; n++)
                {

                    Console.Write(prime[n,j] + " ");
                    

                }
                Console.WriteLine();
               

                j++;

            }

        }
    }
}