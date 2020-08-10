//using System;
//using System.Collections.Generic;
//using System.Text;

/*

internal enum Planets 
    {
        Earth, AlphaProxima1, AlphaCentuariB, Titan, Arad
    };
    
    internal enum Stars
    {
        Sun, ProximaCentauri, AlphaCentuariA, BernardStar
    }

    internal enum Ships
    {
        spacePinto, spacePontiac, spaceLincon, spaceShelby, spaceTesla 
    }

    internal enum Items
    {
        weapons, rations, spaceGas, Food, Ships, Moon, drugs, wallet
    }


The story so far...
You are {playerName}.  Your dad is the multigajillion credit air of the Intergallatic spaceWeapons department where spaceWar is the business, and business
is good.  You have just graduated from spaceHarvardWarCollege and was set to inherit the company...But you never were the type to do as you were told.
Even finishing spaceCollege was a stretchGoal.  Moral ambiguity aside, you decide to take your life savings from odd jobs completed while at spaceCollege
and set out to carve out your own "Space" in space. You skipped out on your spaceGraduation to avoid your father. So, with 1000 spaceCredits, a full tank of 
spaceGas, a halfPack of ciggs, its dark and you're wearing sunglasses, you hop into your beatup spacePinto and set out on your adventure.

2. The quickest (and sometimes dangerous) way to fortune is through the spaceTrades.  Goods, products, and services.  If it's in the shop, you can buy,
trade, or steal.  The path you choose is dependant on what you trade.  Or you could just drop everything change your mind and decide to work for your father.
Your choice. 

3. So, do you want to work for your dad, or do you want to set out on your spaceAdventure!.
1 work for dad
2 continue
Choice 1 = Console.WriteLine($"You work for your dad, make millions but feel hollow and empty inside.  Game over.");
Choice 2 = Console.WriteLine($"Wise choice.  {playerName}, LET THE ADVENTURE BEGIN!!");

class/enums:  Planets(Star) w/ Distance from Earth
Earth(Earth's Sun), Proximab (Proxima Centauri) 4.2, AlphaCentuariB (AlphaCentuari) 4.367, Titan (AlphaCentuari) 4.367, Arad (BernardStar) 5.978
Player - Console.ReadLine($"Enter Player Name: {playerName}");
currency - spaceCredits
ships -  Pinto  Pontiac  Lincon  Shelby  Tesla
wallet = spaceCreditsAvailable
itemForSale - Product1 Product2 weapons rations spaceGas Food Ships Moon(retirementEnding) 
purchasePrice Sale price for each item
actions on selection - buyItem(dowhile check wallet)

Stretch goals - Map for sale required to travel to certain planets, multiple jobs, change jobs, additional endings, hire on other crew members
negotiate price(success based on exp/lvl), adjustable cargo holds based on ships storage(ie how much cargo can each ship hold per trip), additinal spaceGas 
units cost based on current load. Races to choose from(ie Terran, Alien etc each with bonus attributed to race which will translate to skills). Skills 
which translate to success in negotations and stealing. Weapons for ship =  new rabbit hole.  Shoot at cops to escape. Random bool t/f



possible 2nd string prompt = "Choose 1 press the 'A' key, Choose 2 press the 'B' key. To quit, press 'Q'."
private bool HandleUserInput(ConsoleKey)
{
var key = GetInputFromUser();

switch (key)
{
case ConsoleKey.A:
 Console.WriteLine($"You work for your dad, make millins of spaceCredits.\nYour wallet is fat but feel hollow and empty inside. Game Over.); 
 break;
case ConsoleKey.B 
 Console.WriteLine($"Wise choice 'playerName', LET THE ADVENTURE BEGIN!!"); 
 break;
case ConsoleKey.Q:
 return true; 
need to figure out how to link this "return true" to quit. maybe something like:
private void PrintUsageOptions()
{
if (tasks.Any())
{
Console.WriteLine("a: add | d: delete | n: next page | \u2193: select | enter: action | q: quit");
}

Console.Write("Input: ");
}
}

return false;
}

static void Main(string[] args)
{
    bool showMenu = true;
    while (showMenu)
   {
        showMenu = MainMenu();
   }
}
 {
                var key = GetInputFromUser();
           
                switch (key)
                {
                    case ConsoleKey.A:
                        Console.Write($"You work for your dad, make millins of spaceCredits.\nYour wallet is fat but feel hollow and empty inside. Game Over.); 
                        break;
                    case ConsoleKey.B
                 Console.Write($"Wise choice 'playerName', LET THE ADVENTURE BEGIN!!");
                        break;
                    case ConsoleKey.Q:
                        return true;
                }
           
                return false;
            }
*/
