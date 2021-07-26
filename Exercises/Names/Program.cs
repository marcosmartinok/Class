using System;
using System.Collections;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] people = new Person[total];

            for (int i = 0; i < total; i++)
            {
                Console.Write("Name {0}: ", (i + 1));
                people[i] = new Person(Console.ReadLine().ToString());
            }

            foreach (Person person in people)
            {
                person.PrintNames();
            }            
        }
    }
}
