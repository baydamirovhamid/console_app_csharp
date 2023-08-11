using System;
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args) {

            int[,] a = new int[2, 2] { { 4, 5 }, { 3, 4 } };
            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine($"Enter {n} integers:");
            
        }
    }
}