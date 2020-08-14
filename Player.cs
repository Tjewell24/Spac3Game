using System;

namespace Spac3Game
{
    public class Player
    {
       public Planets planets;
        public double age = 20;
            
        public Player(Planets planet)
        {
            this.planets = planets;
        }

        public void TravelTo(Planets destination)
        {
            this.planets = destination;
        }
    }
}