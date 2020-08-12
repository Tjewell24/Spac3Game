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
            planets.Add(new Planets("Proxima Cent", "Titan seemms famaliar.. Why do these Terrestials look weird?\n Anyways, You're getting further way from home and feling good. Maybe you should stop by the store?", "GAZORPAZORT REZORT", -3.3, 4.2));
            planets.Add(new Planets("Alpha Cent", "Ahhh the sister planet, a tropical bash year round.. perfect for acquiring new stuff at the store", "\nShagloopy", -2.5, 4.367));
            planets.Add(new Planets("Bernard Star", "Welcome to the boog.. All is game here.. Might want to spend your money before someone spends it for you\n", "Salty Spitoon", 3.6, 5.978));

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


        //video bookmark 2:03:15
        private QuitReason ShouldQuit(QuitReason quitReason)
        {
            QuitReason AgeCheck() => playerOne.age >= 60 ? QuitReason.Age :
                QuitReason.DontQuit;
            QuitReason MoneyCheck() => hero.money < 0 : Quit
            {
                return playerOne.spaceCred < 0 ? QuitReason.OutOfSpaceCred :
            QuitReason.DontQuit;
            }
        
     
       //     }
       //
       //     if (quitReason == QuitReason.DontQuit)
       //     {
       //         quitReason = spaceCredCheck();
       //     }
       //   return quitReason;
       // }
         
        
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
            var valid = false;
            int selector = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Travel to: ");

                PrintLocationAndDistances(selector);
                var key = UI.UserInput();

                switch (key)
                { 
                 
                
                }
            } while (!valid);
        }

        private void PrintLocationAndDistances(int selector)
        {
            for (int i = 0; i < planets.Count; ++i)
            {
                Planets destination = planets[i];

                var distance = currentPlanet.DistanceTo(destination);


                Console.Write($"{i + 1}. ");
                if (i == selector)
                {
                    UI.Highlight();

                }

                Console.WriteLine($"{ destination.planetName}: { distance: f2}ly");
               UI.ResetColor();
            }
        }

        

    }
}

