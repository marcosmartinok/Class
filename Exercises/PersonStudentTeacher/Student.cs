namespace PersonStudentTeacher
{
    class Student : Person
    {
        public void Study()
        {
            System.Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            System.Console.WriteLine("My age is: {0} years old", Age);
        }
        
    }
}