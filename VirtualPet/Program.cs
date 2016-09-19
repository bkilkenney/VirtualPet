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
            System.Threading.Thread.Sleep(1000);

            VirtualPet CrabAppleHead = new VirtualPet("CrabAppleHead", 25, 25, 25);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hello, I'm Crabapplehead, what would you like to do today?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Select from the following menu:");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("1: Eat Crabapples");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("2: Haunt Children");
            System.Threading.Thread.Sleep(2000);
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
                Console.WriteLine("Invalid answer, Crabapplehead doesn't want to be you pet anymore, gave over.");
            }

/*Need to make the game loop until player wins or loses,
add in Tick and then try to implement stretch features*/

        }
     }
}
