using System;
using System.Collections.Generic;
using System.Text;

namespace TheSpaceGame
{
    class Story
    {
        public static void Introduction()
        {
            Console.WriteLine("Welcome to the Space Game! \n\nYour family has run into some trouble. Money is running low and there's only one way to settle your debt.");
            Console.WriteLine("Work your way throughout different planets, make those trades, and find a way to win back your money. \nYour family is depending on it!");
            Console.ReadLine();
            Console.Clear();
        }

        // Git test delete

        /* public static void UserCharacter()
         {
             Console.WriteLine("Choose your characters name: ");
             string userName = Console.ReadLine();
             Console.WriteLine("\nHello " + userName + ", you're almost ready to start your quest. \nLast thing you need to do is choose your ship!");
             Console.ReadLine();
             Console.Clear();
         } */

        public static string UserCharacter()
        {
            Console.WriteLine("Choose your characters name:");
            string userName = Console.ReadLine();
            return userName;
        }
             
        public static void UserGreeting()
        {
            Console.WriteLine($"\nHello {UserCharacter()}, you're almost ready to start your quest. \nLast thing you need to do is choose your ship!");
            Console.ReadLine();
            Console.Clear();
        }


        public static void ShipMessage()
        {
            Console.WriteLine("You have three ships to choose from: ");
            Console.WriteLine("Ship 1: \nSpeed: Fast (between 8-10 times the speed of light \nCapacity: Low");
            Console.WriteLine("\nShip 2: \nSpeed: Medium (between 4-7 times the speed of light) \nCapacity: Medium");
            Console.WriteLine("\nShip 3: \nSpeed: Slow (between 1-3 times the speed of light) \nCapacity: Large");
            Console.WriteLine("Which would you like to choose?");



        }

        public static void TravelMessage()
        {
            Console.WriteLine("Select a planet to travel to:");
            Console.WriteLine("");
            Console.WriteLine("1. Earth");  // TODO May need to go back and use string interpolation here
            Console.WriteLine("2. Alpha Proxima 1");
            Console.WriteLine("3. Venus Prime");
            Console.WriteLine("4. Jupiter X");
            Console.WriteLine("5. New Mars");

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("test 1");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("test 2");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("test 3");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("test 4");
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("test 5");
                    break;
            }


            // Earth starting position 0,0

            // Alpha Proxima 1 position 4.7,0

            // Venus Prime position 5,2

            // Jupiter X position 14,3

            // New Mars p

        }

       
    }
}
