using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Numerics;

namespace Spac3Game
{


    public class App
    {
        List<Planets> planets = new List<Planets>();
        Player YOU; 

        Planets currentPlanet;
 

        public App()
        {
            planets.Add(new Planets("Earth", "Everything is known... Your current goal is to get away from your dad.", "Dollar general", 0, 0));

            
            planets.Add(new Planets("Titan", "This planet orbits Proxima Cent and it seemms oddly famaliar.. Why do these Terrestials look weird?\n Anyways, You're getting further way from home and feeling good. Maybe you should stop by the store?", "GAZORPAZORT REZORT", -3.3, 4.2));
            planets.Add(new Planets("Alpha Proxima 1", "Ahhh the sister planet. This planet orbits Alpha Cent and is a tropical bash year round.. perfect for acquiring new stuff at the store", "\nShagloopy", -2.5, 4.367));
            planets.Add(new Planets("Alpha Proxima 2", " \"a.k.a. The adopted twin\" . This planet orbits Alpha Cent as well, however due to its location further away from Alpha Cent, this planet faces harsh winters...nearly all year round. Only the hard reside here.  Only the strong", "\nLeidas", -2.5, 4.369)); 
            planets.Add(new Planets("Arad", "Welcome to the boog.. This desert planet is located at the far reaches of known colonized space and orbits the  Bernard Star. All is game here.. Might want to spend your money before someone spends it for you.\nA good place to hide out for those looking to excape the law", "Salty Spitoon", 3.6, 5.978));

            YOU = new Player(planets[0]);
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
                Console.WriteLine($"You are on {YOU.currentPlanet.planetName}\n");

                // printed location description for user
                Console.WriteLine(YOU.currentPlanet.planetDescription);

                // provide options to the user things they can do
                PrintOptionList();


                var key = UI.UserInput();
                quitReason = HandleInput(key);
            } while (quitReason == QuitReason.DontQuit);
            return quitReason;
        }


        //video bookmark 2:03:15
       // private QuitReason ShouldQuit(QuitReason quitReason)
        //{
          //  QuitReason AgeCheck() => playerOne.age >= 60 ? QuitReason.Age :
            //    QuitReason.DontQuit;
            //QuitReason MoneyCheck() => hero.money < 0 : Quit
            //{
              //  return playerOne.spaceCred < 0 ? QuitReason.OutOfSpaceCred :
            //QuitReason.DontQuit;
            //}


            //     }
            //
            //     if (quitReason == QuitReason.DontQuit)
            //     {
            //         quitReason = spaceCredCheck();
            //     }
            //   return quitReason;
            // 
        

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
                int count = planets.Count;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Travel to: ");

                    PrintLocationAndDistances(selector);

                    var key = UI.UserInput();

                    switch (key)
                    {
                    case ConsoleKey.DownArrow:
                        selector++;
                        selector %= count;
                        break;
                    case ConsoleKey.UpArrow:
                        selector--;
                        selector = (selector + count) % count;
                        break;

                    case ConsoleKey.Q:
                        valid = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.Enter:
                        valid = true;
                        break;
                        YOU.TravelTo(locations[selector]);
                    }
                } while (!valid);
            }

            private void PrintLocationAndDistances(int selector)
            {
                for (int i = 0; i < planets.Count; ++i)
                {
                    Planets destination = planets[i];

                    var distance = YOU.currentPlanet.DistanceTo(destination);


                    Console.Write($"{i + 1}. ");
                    if (i == selector)
                    {
                        UI.Highlight();

                    }

                    Console.WriteLine($"{destination.planetName}: {distance }:ly");
                    UI.ResetColor();
                }
            }



        
    }
}

