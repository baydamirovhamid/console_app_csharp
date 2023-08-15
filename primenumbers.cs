using System;

namespace PrimeNumbers
{
    class Program
    {
        static bool IsPrime(int n)
        {

            if (n < 2)
            {
                return false;
            }


            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {

            int limit;
            Console.WriteLine("Enter the last number: ");
            limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The prime numbers from 1 to limit are:", limit);
            for (int i = 1; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}                
                


            



      