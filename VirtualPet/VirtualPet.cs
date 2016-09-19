using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
//private fields(instance variables), which can only be accessed from within the class:      
        private int apetite;
        private int crabiness;
        private int sleepiness;


//properties:
//The following format is concise but doesn't read in the same cascading way, either works, just preference:

        public int Apetite
        {
            get { return this.apetite; }
            set { this.apetite = value; }
        }

        public int Crabiness
        {
            get { return this.crabiness; }
            set { this.crabiness = value; }
        }

        public int Sleepiness
        {
            get { return this.sleepiness; }
            set { this.sleepiness = value; }
        }

//Public access modifiers can be seen or used from anywhere, even outside the class. CONSTRUCTORS:

        public VirtualPet(int apetite, int crabiness, int sleepiness)
        {
            this.apetite = apetite;
            this.crabiness = crabiness;
            this.sleepiness = sleepiness;
        }

//Methods, the action:

        public void Status()
        {
            Console.WriteLine("Apetite = " + apetite);
            Console.WriteLine("Crabiness = " + crabiness);
            Console.WriteLine("Sleepiness = " + sleepiness);
        }

        public void FeedME()
        {
            apetite -= 10;
            crabiness += 10;
            sleepiness += 10;
        }

        public void Haunt()
        {
            crabiness += 15;
            apetite += 10;
            sleepiness -= 10;
        }

        public void Nap()
        {
            apetite += 5;
            crabiness += 5;
            sleepiness -= 5;
        }

        public void Tick()
        {
            sleepiness += 5;
            crabiness -= 5;
            apetite += 5;
        }
    }
}

