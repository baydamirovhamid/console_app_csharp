using System;
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string: ");
            string str = Console.ReadLine();    
            Console.ReadKey();

            string uppercase = str.ToUpper();
            Console.WriteLine("Uppercase: " + uppercase);

            string lowercase = str.ToLower();
            Console.WriteLine("Lowercase: " + lowercase);

            int totalCharacters = str.Length;
            Console.WriteLine("Total Characters: " + totalCharacters);

            string firstFive = str.Substring(0,5);
            Console.WriteLine("First Five Characters: " + firstFive);

            string lastFive = str.Substring(str.Length - 5);
            Console.WriteLine("Last Five Characters: " + lastFive );

            string replaced = str.Replace('e', '*');
            Console.WriteLine("Replace 'a' with '*': " + replaced);

            Console.WriteLine($"Contains CSharp: { str.Contains("CSharp")}");
            Console.WriteLine($"Index of 'e': { str.IndexOf('e')}");

            string[] words = str.Split(' ');
            Console.WriteLine("Split Words");
            foreach( string word in words )
            {
                Console.WriteLine(" - " + word);
            }          
        }
    }
}