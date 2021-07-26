namespace PersonStudentTeacher
{
    abstract class Person
    {
        public int Age;
        public Person()
        {
            this.Age = 0;
        }

        public abstract void Greet();
        
        public void SetAge(int age)
        {
            this.Age = age;
        }
    }
}