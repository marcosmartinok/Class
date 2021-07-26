using System;

namespace PersonStudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(20);
            student.Greet();
            student.ShowAge();
            student.Study();

            Professor professor = new Professor();
            professor.SetAge(50);
            professor.Greet();
            professor.Explain();

        }
    }
}
