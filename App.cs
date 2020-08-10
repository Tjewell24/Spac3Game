using System;
using System.Runtime.CompilerServices;

namespace Spac3Game
{
    //enum QuitReason { DontQuit, UserQuit, Age, OutOfMoney, WorkforDad };

    public class App
    {
        public App()
        {

        }

        public void Run()
        {
            Story.Intro();

            EventLoop();

        }



        private void EventLoop()
        {
            bool quit = false;

            do
            {
                Console.Clear();

                //print current location

                // print a discription of location

                // provide options to the user things they can do


                var key = UI.UserInput();
                quit = HandleInput(key);


            } while (!quit);
        }
        private bool HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Q:

            }
            return true;

        }


    }
}

