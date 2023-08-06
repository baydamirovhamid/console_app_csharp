using System;
namespace Conversion
{
    class conversion
    {
        static void Main(string[] args)
        {
            int int1 = 10;
            double double1 = (double)int1;
            Console.WriteLine(double1);

            float float1 = 5.84f;
            int int2 = (int)float1;
            Console.WriteLine(int2);

            string str1 = "96.1";
            int int3 = int.Parse(str1);
            Console.WriteLine(int3);

            bool bool1 = true;
            string str2 = bool1.ToString();
            Console.WriteLine(str2);

            double double2 = 6.66;
            string str3 = double2.ToString();
            Console.WriteLine(str3);

        }
    }
}