using System.Collections;
using System;

namespace Padel
{
    class Partido
    {
        public bool Played {get;set;}
        public int ScorePlayerOne {get;set;}
        public int ScorePlayerTwo {get;set;}
               
        Jugador jugadorUno;
        Jugador jugadorDos;

        public Partido (Jugador jugadorUno, Jugador jugadorDos)
        {
            this.Played = false;
            this.ScorePlayerOne = 0;
            this.ScorePlayerTwo = 0;
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
        }
        
        public Jugador PlayerOne()
        {
            return jugadorUno;
        }
        public Jugador PlayerTwo()
        {
            return jugadorDos;
        }
        public Jugador Winner()
        {
            if (ScorePlayerOne > ScorePlayerTwo)
            {
                return jugadorUno;
            }
            else if (ScorePlayerOne < ScorePlayerTwo)
            {
                return jugadorDos;
            }
            else
            {
                return null;
            }
        }
        public void PlayMatch()
        {
            this.Played = true;
            Random One = new Random();

            int formPlayerOne = One.Next(10, 15);
            int formPlayerTwo = One.Next(10, 15);

            int levelPlayerOne = (this.jugadorUno.Level * formPlayerOne) / 10;
            int levelPlayerTwo = (this.jugadorDos.Level * formPlayerTwo) / 10;
            
            if (levelPlayerOne > levelPlayerTwo)
            {
                this.ScorePlayerOne = 6;
                this.jugadorUno.MatchesWon++;
                this.ScorePlayerTwo = One.Next(0, 5);
            }
            else
            {
                this.ScorePlayerTwo = 6;
                this.jugadorDos.MatchesWon++;
                this.ScorePlayerOne = One.Next(0, 5);
            }

            this.jugadorUno.MatchesPlayed++;
            this.jugadorDos.MatchesPlayed++;
        }

        
    }
}