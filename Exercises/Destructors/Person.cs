namespace Destructors
{
    class Person
    {
        public string Name {get;set;}

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Hello! my name is "+ this.Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }

    }
}