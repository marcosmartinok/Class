using System;

namespace Names
{
    class Person
    {
        public string Name {get;set;}

        public Person(string name)
        {
            this.Name = name;
        }

        public void PrintNames()
        {
            Console.WriteLine("Hello! my name is {0}", this.Name.ToString());
        }       
       
    }
}