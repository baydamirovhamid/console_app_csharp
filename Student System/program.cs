using System;

namespace student
{
   public class Program
    {
        static void Main(string[] args)
        {
            studentsystem hamid =  new studentsystem();
            hamid.SetID(1);
            hamid.SetName("Hamid");
            hamid.SetSurname("Baydamirov");
            hamid.SetBirthdate(new DateTime(09 / 07 / 2005));
            hamid.Display();

            Console.ReadKey();
        }
    }
}