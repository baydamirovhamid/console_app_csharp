using System;
namespace task11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your numerical score: ");
            double number = Convert.ToDouble(Console.ReadLine());
         

            string grade = number >= 90 && number <= 100 ? "A" : number >= 80 && number <= 89.99 ? "B" : number >= 70 && number <= 79.99 ? "C" : number >= 60 && number <= 69.99 ? "D" : number >= 0 && number <= 59.99 ? "F" : "Invalid Score";

            Console.WriteLine("Your letter grade is: {0}", grade);
            Console.ReadKey();

        }
    }
}