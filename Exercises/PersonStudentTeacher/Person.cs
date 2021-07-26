using System;
namespace PersonStudentTeacher
{
    abstract class Person
    {
        public int Age;
        public Person()
        {
            this.Age = 0;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Hello, I am just a regular person");
        }
        
        public void SetAge(int age)
        {
            this.Age = age;
        }
    }
}