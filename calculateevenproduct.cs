using System;

class Program
{
    static void Main()
    {
        int limit;
        limit = Convert.ToInt32(Console.ReadLine());
        long result = CalculateEvenProduct(limit);
        Console.WriteLine($"Product of all even numbers up to {limit} is: {result}");
    }

    static long CalculateEvenProduct(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else if (n % 2 != 0)
        {
            return CalculateEvenProduct(n - 1);
        }
        else
        {
            return CalculateEvenProduct(n - 2) * n;
        }
    }
}