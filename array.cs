using System;
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};
            int sum = 0;

            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("SUM: " +sum );

        }
    }
}