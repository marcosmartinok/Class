namespace PersonStudentTeacher
{
    class Person
    {
        public int Age;
        public Person()
        {
            this.Age = 0;
        }

        public void Greet()
        {
            System.Console.WriteLine("Hello!");
        }
        public void SetAge(int age)
        {
            this.Age = age;
        }
    }
}