using System;

namespace backend04
{
    class program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the scores :");

            Console.Write("Subject 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double average = (a + b + c) / 3;
            Console.WriteLine("Average Grade: " + average.ToString("0"));
        }
    }
}

