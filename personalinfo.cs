using System;
namespace personinfo
{ 
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person()
        {
            Console.WriteLine("Personal info: ");
        }
        public void setName(string Name)
        {
            this.name = Name;
        }
        public void setAge(int Age)
        {
            this.age = Age;
        }
        public void setGender(string Gender)
        {
            this.gender = Gender;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getGender()
        {
            return this.gender;
        }

        static void Main(string[] args)
        {
            Person person = new Person();

            person.setName("Hamid");
            person.setAge(18);
            person.setGender("male");
            Console.WriteLine($"Personal information: {person.getName()}, {person.getAge()}, {person.getGender()}");
            Console.ReadKey();
        }
    }
}