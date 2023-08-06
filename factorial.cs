using System;
namespace task11
{
    class Program
    {
        static int factorial(int n)
        {
            if ( n<=1)
                return 1;

            return n* factorial(n-1);
              
        }

        static void Main(string[] args)
        {
            int number, result;
            Console.WriteLine("Enter a positive number ");
            number = Convert.ToInt32(Console.ReadLine());
            result = factorial(number);
            Console.WriteLine("{0}! = {1}", number, result);
        }
                
           
        }      
    }
