using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

namespace Padel
{
    class Campeonato    
    {
        List<Jugador> participantes;
        ArrayList matches;
        public Campeonato()
        {
            this.participantes = new List<Jugador>();
            this.matches = new ArrayList();
        }

        public void AddPlayer(Jugador jugador)
        {
            this.participantes.Add(jugador);
        }
        public void AddMatches(Partido partido)
        {
            this.matches.Add(partido);
        }
        public void PlayChampionship()
        {
            foreach(Partido partido in this.matches)
            {
                partido.PlayMatch();
            }

        }
        //te olvidaste del metodo jaja. logica suelta no camina jaja sisi

        
        public void Tabla()
        { 
            this.participantes.Sort( 
                (x,y) => 
                    x.MatchesWon.CompareTo(y.MatchesWon)
            );
            StringBuilder puntos = new StringBuilder();            
            for (int i = this.participantes.Count - 1; i >= 0; i--)
            {
                Jugador jugador = this.participantes[i];
                puntos.Append(jugador.Name);
                puntos.Append(" ---- ");
                puntos.Append(jugador.MatchesPlayed);
                puntos.Append(" ---- ");
                puntos.Append(jugador.MatchesWon);
                puntos.Append("***");                                
            }

            string[] filas = puntos.ToString().Split("***");

            System.Console.WriteLine("Player   Matches   Points");
            foreach(string item in filas)
            {
                System.Console.WriteLine(item);
            }

            

        }
        

        

    }
}