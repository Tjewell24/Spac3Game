using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spac3Game
{
    static class UI
    {
        public static ConsoleKey UserInput(string prompt = ">")
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write(prompt);
            return Console.ReadKey(true).Key;


        }
    }
}
