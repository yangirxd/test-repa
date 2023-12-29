
using System;
using System.Diagnostics.Metrics;

namespace Test
{
    public class Programm
    {
        public static void Main() {
            
        }
    }

    class Player 
    { 
        public string Name { get; set; }
        public int Number { get; set; }
    }

    class Team
    {
        Player[] players = new Player[11];

        public Player this[int index] {
            get 
            {
                return players[index];
            }
            set 
            {
                players[index] = value;
            }
        }

    }
    }