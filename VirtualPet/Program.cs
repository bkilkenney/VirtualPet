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
            VirtualPet CrabAppleHead = new VirtualPet("CrabAppleHead", 25, 25, 25);
            Console.WriteLine("Hello, I'm Crabapplehead, what would you like to do today?");
            Console.WriteLine("Select from the following menu:");
            Console.WriteLine();
            Console.WriteLine("1: Eat Crabapples");
            Console.WriteLine("2: Haunt Children");
            Console.WriteLine("3: Nap");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                CrabAppleHead.FeedMe();
                Console.WriteLine(CrabAppleHead.FeedMe());
            }
            else if (answer == 2)
            {
                CrabAppleHead.Haunt();
                Console.WriteLine(CrabAppleHead.Haunt());
            }
            else if (answer == 3)
            {
                CrabAppleHead.Nap();
                Console.WriteLine(CrabAppleHead.Nap());
            }
            else
            {
                Console.WriteLine("Invalid answer, please select again");
            }

/*Need to make the game loop until player wins or loses, keep the current score on the screen,
add in Tick and then try to implement stretch features*/

        }
     }
}
