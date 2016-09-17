using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //Private access modifiers - these variables can only be accessed from within the class
        private string name;
        private int apetite;
        private int mood;

        //Public access modifiers can be seen or used from anywhere, even outside the class.  CONSTRUCTORS
        public VirtualPet(string name, int apetite, int mood)
        {
            this.name = name;
            this.apetite = apetite;
            this.mood = mood;
        }

        //Properties

        public string Name
            {
            get { return this.name; }
            set { this.name = value; }
            }

        public int Apetite
        {
            get { return this.apetite; }
            set { this.apetite = value; }
        }
        
        public int Mood
        {
            get { return this.mood; }
            set { this.mood = value; }
        }

        //Methods
        public int FeedMe()
        {
            apetite += 3;
            mood += 3;
            return apetite;
                     
        }

        public int Haunt()
        {
            mood += 100;
            apetite -= 3;
            return mood;
        }

        public int Nap()
        {
            apetite += 5;
            mood += 5;
            return apetite;
        }

     }
}

