using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string userInput;

            bool inGame = false;
            while (1 == 1)
            {
                //Game menu
                while (inGame == false)
                {

                    Console.WriteLine("Virtual Pets Amok");
                    Console.WriteLine("Game Menu");

                    Console.WriteLine("Play Game (p)");

                    Console.WriteLine("Exit Game (e)");


                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "p")
                    {
                        inGame = true;
                    }

                }
                //Playing Game
                while (inGame)
                {

                    Console.WriteLine("To Return to Main Menu: type (m)");

                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "m")
                    {
                        inGame = false;
                    }

                }
            }
        }
    }
}
