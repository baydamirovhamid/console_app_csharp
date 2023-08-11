using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());
            
        int[] numbers = new int[n];
        Console.WriteLine($"Enter {n} integers:");

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");
    }
}