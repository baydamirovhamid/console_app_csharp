using System;
using System.Diagnostics.Metrics;

namespace operators
{
    class NumberManipulator
    {

        static void Main(string[] args)
        {
            Console.Write($"Number:");
            int num1;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter:");
            string num2;
            num2 = Convert.ToString(Console.ReadLine());
            Console.Write($"Number:");
            int num3;
            num3 = Convert.ToInt32(Console.ReadLine());




            if (num2 == "/")
            {
                if (num3 == 0)
                {
                    Console.WriteLine("Cannot divide by 0");
                                     
                }
                Console.WriteLine("Answer: {0}", (num1 / num3));

            }

            else if (num2 == "*")
            {
                Console.WriteLine("Answer: {0}", (num1 * num3));
            }

            else if (num2 == "+")
            {
                Console.WriteLine("Answer: {0}", (num1 + num3));
            }

            else if (num2 == "-")
            {
                Console.WriteLine("Answer: {0}", (num1 - num3));
            }

            else
            {
                Console.Write("Error");
            }
        }

    }
}

