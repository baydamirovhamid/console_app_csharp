using System;

namespace LibraryInfo
{
    public class Program
    {
       public static void Main(string[] args)
        {
            LibraryItem[] items = new LibraryItem[]
        {
            new Book 
            { 
                Title = "The Silent Patient", PublicationYear = 2019, Author = "Alex Michaelides" 
            },

            new DVD 
            { 
                Title = "Black Widow", PublicationYear = 2021, Director = "Cate Shortland" 
            },

            new Magazine 
            { 
                Title = "Time", PublicationYear = 1923, IssueNumber = 5 
            }
        };

            foreach (var item in items)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}