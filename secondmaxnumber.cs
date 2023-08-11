using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Enter the numbers: ");

        for ( int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = int.MinValue;
        int secondMax = int.MinValue;


        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > max)
            {
                secondMax = max;
                max = numbers[i];
            }
            else if (n > secondMax && n < max)
            {
                secondMax = n;
            }
        }

        Console.WriteLine("The second largest number in the array is: " + secondMax);
    }
}
