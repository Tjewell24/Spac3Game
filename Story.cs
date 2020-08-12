using System;

namespace Spac3Game
{
    public static class Story
    {
        public static string PlayerOne { get; private set; }

        public static void Intro()
        {
            string prompt = "Press any key continue...";

            
            //int spaceCredits = 1000;
            Console.WriteLine("What do I call you spaceCowboy?");
             string playerOne = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"The story so far...\nIn the year 23xx, You are {playerOne}. Your dad is the multigajillion-spaceCredit-air of the\nIntergallatic spaceWeapons department where spaceWar is the business, and business is good. You have just graduated from\nspaceHarvardWarCollege and was set to inherit the company...\nBut {PlayerOne} was never the type to do as you were told. Even finishing spaceCollege was a stretchGoal.\nMoral ambiguity aside, {PlayerOne} decides to take your life savings from odd jobs completed while at spaceCollege and set out to carve out your own \"Space\" in space. {PlayerOne} skipped out on your spaceGraduation to avoid your father.\nSo, with 1000 spaceCredits, a full tank of spaceGas, a halfPack of cigarettes, its dark and you're wearing sunglasses\nyou hop into your beatup spacePinto and set\nout to begin your adventure.");

            UI.UserInput(prompt);

            Console.Clear();
            Console.WriteLine($"The quickest (and sometimes dangerous) way to fortune is through the spaceTrades. Goods, products, and services.\nIf it's in the spaceShop you can buy, sell, trade, or steal. The path you choose is dependant on what you trade.\nOr you could just drop everything change your mind and decide to work for your father. Your choice.");
            UI.UserInput(prompt);

            Console.Clear();
            Console.WriteLine($"So, {playerOne}, do you want to work for \"dear 'ol dad\", or do you want to set out on your spaceAdventure!\nPress 1 Work for dad!\nPress 22 I do What I Want!");
            Console.WriteLine($"Choose your destiny! Press 1, or Press 22");
            ChooseYourAdventure();

            /*UI.UserInput(prompt);

            Console.Clear();
            Console.WriteLine($"Choice 1 = You work for your dad, make millions of spaceCredits.\nYour wallet is fat but feel hollow anempty inside. Game over.");
            UI.UserInput(prompt);

            Console.Clear();
            Console.WriteLine($"Choice 2 = Wise choice 'playerName', LET THE ADVENTURE BEGIN!!");
            UI.UserInput(prompt);
            */


            //Console.Clear();
            //Console.WriteLine($"Choice 1 = You work for your dad, make millions of spaceCredits.\nYour wallet is fat but feel hollow /and /empty inside. Game over.");
            //UI.UserInput(prompt);
            //
            //Console.Clear();
            //Console.WriteLine($"Choice 2 = Wise choice 'playerOne', Lets roll!");
            //UI.UserInput(prompt);


        }

        //Figure out how to user input choices          
        public static void ClosingMessage(QuitReason quitReason)
        {
            switch (quitReason)
            {
                
                case QuitReason.UserQuit:
                    Console.WriteLine($"Goodbye  ..\n\n");
                    break;
                case QuitReason.Age:
                    Console.WriteLine($"Sorry  You are too old to continue.. \n\n");
                    break;
                case QuitReason.OutOfMoney:
                    Console.WriteLine($"YOU BROKE ... Get your money up Space Cowboy");
                    break;
                case QuitReason.DontQuit:
                    throw new NotImplementedException("Shouldn't be quitting with DontQuit");

            }
        }
        public static void ChooseYourAdventure()
        {
            ConsoleKey choice, choice2;
            do
            {
                choice = Console.ReadKey(true).Key;

                switch (choice)
                {
                    // End the game here
                    case ConsoleKey.D1:
                        Console.WriteLine("You work for your dad, make millions of spaceCredits.\nYour wallet is fat but feel hollow and empty inside. Game over.");
                        Console.WriteLine();
                        Console.WriteLine($"{PlayerOne} Do you want to try again?\nPress 3 for \"Yes\"\nPress 1 for \"No\"");
                        Console.WriteLine();
                        //need to loop back after this.
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine($"Wise choice {PlayerOne}', Lets roll!");
                        break;
                }
            }
            while (choice != ConsoleKey.D1 && choice != ConsoleKey.D2);
            do
            {
                choice2 = Console.ReadKey(true).Key;

                switch (choice2)

                {
                    case ConsoleKey.D3:
                        Console.WriteLine($"Ok {PlayerOne}, lets try this again.");
                        Console.WriteLine();
                        Console.WriteLine($"So, {PlayerOne}, do you want to work for \"dear 'ol dad\", or do you want to set out on your spaceAdventure!\nPress 1 Work for dad!\nPress 22 I do What I Want!");
                        ChooseYourAdventure();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine($"Wise choice {PlayerOne}', Lets roll!");
                        break;
                        // Continue the game here with more Blue's Brothers parady
                }
            }
            while (choice != ConsoleKey.D1 && choice != ConsoleKey.D2 && choice2 != ConsoleKey.D3);
        }
    }

}
