using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //Private instance variables - these variables can only be accessed from within the class and can't be manipulated by outside forces
        
        private int apetite;
        private int crabiness;
        private int sleepiness;

        //Public access modifiers can be seen or used from anywhere, even outside the class.  CONSTRUCTORS
        public VirtualPet(string name, int apetite, int crabiness, int sleepiness)
        {            
            this.apetite = apetite;
            this.crabiness = crabiness;
            this.sleepiness = sleepiness;
        }

        //Properties

       
        public int Eat
        {
            get { return Eat; }  //This format is more concise but relies less on reading in a cascading pattern
            set { this.Eat = value; }
        }
        
        public int Mood
        {
            get { return crabiness; }
            set { this.crabiness = value; }
        }
        public int Sleepiness
        {
            get { return sleepiness; }
            set { this.sleepiness = value; }
        }

        //Methods
        public int FeedMe()
        {
            apetite -= 10;
            crabiness += 10;
            return apetite;  //Need a return to prevent errors               
        }

        public int Haunt()
        {
            crabiness += 15; //CrabAppleHead's fav activity is to haunt
            apetite += 10;
            sleepiness += 15;
            return crabiness;
        }

        public int Nap()
        {
            apetite += 5;
            crabiness += 5;
            sleepiness -= 5;
            return apetite; 
        }
        public void Status()
        {
            Console.WriteLine("Apetite = " + apetite);
            Console.WriteLine("Crabiness = " + crabiness);
            Console.WriteLine("Sleepiness = " + sleepiness);
        }

     }
}

