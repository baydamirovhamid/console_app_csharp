using System;


namespace backend05
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert Celsius to Fahrenheit: ");

            Console.WriteLine("temperature: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double num = ((a - 32) * 5 / 9);
            Console.WriteLine(" Celsius to Fahrenheit: " + num.ToString("0") );
        }

    }

}
