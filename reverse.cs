using System;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed word: " + new string(charArray));
        }
    }
}