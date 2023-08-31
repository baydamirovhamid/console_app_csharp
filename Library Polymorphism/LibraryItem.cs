using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfo
{
    internal class LibraryItem
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }
    }
}