using System;
using System.Diagnostics.CodeAnalysis;

namespace ArrayApplication
{
    class MyAverageArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("Enter the numbers: ");

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0; 
            foreach (int num in numbers) { sum += num; } 

            double average = (double)sum / n;

            Console.WriteLine($"The average of the {n} numbers: {average}");
        }
    }
}