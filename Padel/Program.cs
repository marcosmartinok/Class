using System;
using System.Collections.Generic;

namespace Padel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> players = new List<Jugador>();
            Jugador george = new Jugador("George", "Costanza", 63);
            players.Add(george);
            Jugador elaine = new Jugador("Elaine", "Benes", 59);
            players.Add(elaine);
            Jugador jerry = new Jugador("Jerry", "Seinfeld", 63);
            players.Add(jerry);
            Jugador kramer = new Jugador("Cosmo", "Kramer", 71);
            players.Add(kramer);

            List<Partido> partidos = new List<Partido>();
            Partido partidoOne = new Partido(george, elaine);
            partidos.Add(partidoOne);
            Partido partidoTwo = new Partido(jerry, kramer);
            partidos.Add(partidoTwo);
            Partido partidoThree = new Partido(george, jerry);
            partidos.Add(partidoThree);
            Partido partidoFour = new Partido(elaine, jerry);
            partidos.Add(partidoFour);
            Partido partidoFive = new Partido(george, kramer);
            partidos.Add(partidoFive);
            Partido partidoSix = new Partido(elaine, kramer);
            partidos.Add(partidoSix);

            Campeonato campeonato = new Campeonato();
            foreach(Partido partido in partidos)
            {
                campeonato.AddMatches(partido);
            }
            foreach(Jugador jugador in players)
            {
                campeonato.AddPlayer(jugador);
            }

            campeonato.PlayChampionship();          

            
            
            foreach (Jugador jugador in players)
            {
                PrintPlayerStats(jugador);
            }

            foreach(Partido partido in partidos)
            {
                PrintMatchResults(partido);
            }      

            campeonato.Tabla();     
        }
        private static void PrintPlayerStats(Jugador jugador)
        {
            System.Console.WriteLine("================= Player Stats ========================");
            System.Console.WriteLine("Name: {0}", jugador.Name);
            System.Console.WriteLine("Level: {0}", jugador.Level);
            System.Console.WriteLine("Age: {0}", jugador.Age);
            System.Console.WriteLine("Matches played: {0}", jugador.MatchesPlayed);
            System.Console.WriteLine("Matches won: {0}", jugador.MatchesWon);
            System.Console.WriteLine("=======================================================");
        }
        private static void PrintMatchResults(Partido partido)
        {
            System.Console.WriteLine("================= Match Result ========================");
            System.Console.WriteLine("Player one: {0}", partido.PlayerOne().Name);
            System.Console.WriteLine("Player two: {0}", partido.PlayerTwo().Name);
            System.Console.WriteLine("Score: {0}:{1}", partido.ScorePlayerOne, partido.ScorePlayerTwo);
            System.Console.WriteLine("Winner: {0}", partido.Winner().Name);
            System.Console.WriteLine("=======================================================");            
        }
    }   
}       
