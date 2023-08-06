using System;
namespace task14
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the odd number: ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            for( int i = 1; i < number; i= i + 2 ) 
            { 
            
                Console.WriteLine(i);
            
            
            }
            Console.ReadLine();


        }
    }
}