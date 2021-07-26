using System;

namespace Padel
{
    /// <summary>
    /// Los nombres de las calses son en Singular. Por que cada objeto va a ser un UNICO jugador. 
    /// La clase no representa a TODOS los jugadores, solo a uno de ellos.
    /// ok
    /// </summary>
    class Jugador
    {
        public string Name {get;set;}
        public string LastName {get;set;}      
        public int Age {get;set;} 
        public int MatchesPlayed {get;set;}
        public int MatchesWon {get;set;}
        private Random random = new Random(); //esto deberia ser privado --- Ok
        public int Level {get;set;} //esto deberia estar encapsulado ---- Ok
        public Jugador (string name, string lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName; 
            this.Age = age;
            this.MatchesPlayed = 0;
            this.MatchesWon = 0;
            this.Level = random.Next(100);           

        }
    }
}