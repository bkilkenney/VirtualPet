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
        private string name;
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

        public string Name
        {
           get
            {
                return this.name;
            } 
             //Can have a get without a set.  Name won't change in this console app.  
        }

        public int Apetite
        {
            get { return apetite; }  //This format is more concise but relies less on reading in a cascading pattern
            set { this.apetite = value; }
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
            apetite -= 5;
            crabiness += 3;
            return apetite;  //Need a return to prevent errors               
        }

        public int Haunt()
        {
            crabiness += 15; //CrabAppleHead's fav activity is to haunt
            apetite -= 3;
            sleepiness += 5;
            return crabiness;
        }

        public int Nap()
        {
            apetite += 5;
            crabiness += 5;
            sleepiness -= 5;
            return apetite; 
        }

     }
}

