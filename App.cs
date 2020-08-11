using System;
using System.Runtime.CompilerServices;

namespace Spac3Game
{
   

    public class App
    {
        Planets planets;

            
        public App()
        {
            planets = new Planets("You are on Earth", "Everything is known... Your current goal is to get away from your dad.", "Dollar general");

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
                Console.WriteLine(planets.planetName);

                // print a discription of location
                Console.WriteLine(planets.planetDescription);

                // provide options to the user things they can do
                Console.WriteLine($"Your local store is {planets.planetStore}.. Spend wisely Cowboy");


                var key = UI.UserInput();
                quitReason = HandleInput(key);
            } while (quitReason == QuitReason.DontQuit);
            return quitReason;
        }    
         private QuitReason HandleInput(ConsoleKey key)
         {
            switch (key)
            {
                case ConsoleKey.Q:
                    return QuitReason.UserQuit;
            } return QuitReason.DontQuit;
            
            

         }


    }
}

