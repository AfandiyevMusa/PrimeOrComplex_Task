using System;

namespace PrimeOrComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4, cnt = 0;
            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt > 2)
                {
                    Console.WriteLine("n is complex number!");
                }
                else
                {
                    Console.WriteLine("n is prime number");
                }
            }
            else
            {
                Console.WriteLine("Please, write the correct number!");
            }
        }
    }
}