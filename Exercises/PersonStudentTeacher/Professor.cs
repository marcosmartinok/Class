namespace PersonStudentTeacher
{
    class Professor : Person
    {
        public void Explain()
        {
            System.Console.WriteLine("I'm explaining");
        }
        public override void Greet()
        {
            
            System.Console.WriteLine("Hello! I am a professor");
        }
        
    }
}