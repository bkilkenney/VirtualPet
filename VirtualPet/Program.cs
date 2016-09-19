using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet CrabAppleHead = new VirtualPet(25, 25, 25);

            Console.Clear();

            Console.WriteLine("Hello, I'm Crabapplehead, what would you like to do today?");
            Console.WriteLine();

//Creating loop so user can continue to play until they quit

            while (true)
            {

//Introduction and vitals "Scoreboard":
                Console.WriteLine("*Player1, you must figure out what Crabapplehead likes in order to win*");
                Console.WriteLine();
                CrabAppleHead.Status();
                Console.WriteLine();

//Criteria for winning the game:
                if (CrabAppleHead.Apetite <= 0 || CrabAppleHead.Crabiness >= 50 || CrabAppleHead.Sleepiness >= 50)
                {
                    Console.WriteLine("You win!");
                    break;
                }

//Choices for what to do with your Crabapplehead:
                Console.WriteLine("Select from the following menu: ");
                Console.WriteLine();

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("1: Eat Crabapples");

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("2: Haunt People");

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("3: Nap");

//Actions based on methods in VirtualPet class and users' selection: 
                int answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        CrabAppleHead.FeedME();
                        break;

                    case 2:
                        CrabAppleHead.Haunt();
                        break;

                    case 3:
                        CrabAppleHead.Nap();
                        break;

                    default:
                        Console.WriteLine("Invalid answer, you might be the next victim to haunted by Crabapplehead!");
                        break;
                }

//Tick method also manipulates vital stats:
            CrabAppleHead.Tick();

//Updates vitals(Scoreboard):
            Console.Clear();

            }
        }
    }
}
