using System;

namespace Destructors
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] people = new Person[total];

            for(int i = 0; i < total; i++)
            {
                System.Console.Write("Name {0}: ", i + 1);
                people[i] = new Person(Console.ReadLine());
            }

            foreach(Person person in people)
            {
                System.Console.WriteLine(person.ToString());
            }
        }
    }
}
