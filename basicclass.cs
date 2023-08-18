using System;

public class Person
{   
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter information for a person:");
        Person person = new Person();

        Console.Write("Name: ");
        person.Name = Console.ReadLine();

        Console.Write("Age: ");   
        person.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gender: ");
        person.Gender = Console.ReadLine();

  
        Console.WriteLine("\nPerson's Information:");
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Gender: {person.Gender}");
    }
}
