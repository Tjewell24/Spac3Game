using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Spac3Game
{
   

    public class App
    {
        List<Planets> planets = new List<Planets>();

        Planets currentPlanet;

            
        public App()
        {
            planets.Add(new Planets("Earth", "Everything is known... Your current goal is to get away from your dad.", "Dollar general", 0, 0));

            currentPlanet = planets[0];

        }

        public void Run()
        {
            Story.Intro();

           var quitReason = EventLoop();

            Story.ClosingMessage(quitReason);
        }



        private QuitReason EventLoop()
        {
            var quitReason = QuitReason.DontQuit;

            do
            {
                Console.Clear();

                //print current location
                Console.WriteLine($"You are on {currentPlanet.planetName}\n");

               // printed location description for user
                Console.WriteLine(currentPlanet.planetDescription);

                // provide options to the user things they can do
                PrintOptionList();


                var key = UI.UserInput();
                quitReason = HandleInput(key);
            } while (quitReason == QuitReason.DontQuit);
            return quitReason;
        }

        private void PrintOptionList()
        {
            Console.WriteLine("CHOOSE WHAT YOU WANT TO DO\n");
            Console.WriteLine("1. Travel to your next Planet\n");
            Console.WriteLine("2. Go to your local Dollar General\n");
            Console.WriteLine("3. Chill on Earth and do some cowboy stuff");
        }

        private QuitReason HandleInput(ConsoleKey key)
         {
            switch (key)
            {
                case ConsoleKey.Q:
                    return QuitReason.UserQuit;
                case ConsoleKey.D1:
                    TravelOptions();
                    break;
            } return QuitReason.DontQuit;
            
            

         }

        private void TravelOptions()
        {
            Console.WriteLine("Travel to:");
            for (int i = 0; i < planets.Count; ++i)
            {
                Planets destination = planets[i];

                var distance = currentPlanet.DistanceTo(destination);

                Console.WriteLine($"{i + 1}. {planets}: {distance}ly\n");
            }
        }
    }
}

