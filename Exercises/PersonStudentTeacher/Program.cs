using System;
using System.Collections.Generic;

namespace PersonStudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Student student = new Student();
            people.Add(student);
            student.SetAge(20);
            student.Greet();
            student.ShowAge();
            student.Study();

            Professor professor = new Professor();
            people.Add(professor);
            professor.SetAge(50);
            professor.Greet();
            professor.Explain();

            foreach(Person person in people)
            {
                person.Greet();
            }

        }
    }
}
