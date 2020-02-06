using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class DroidCollection
    {
        


        

        // Private Variables
        private Droid[] droids;
        private int droidLength;

        // Constructor. Must pass the size of the collection
        public DroidCollection(int size)
        {
            this.droids = new Droid[size];
            this.droidLength = 0;
        }

        // Add a new Droid to the collection
        public void AddNewDroid(string name, string type, decimal price)
        {
            droidLength++;
            droids[droidLength] = new Droid(name, type, price);
            
        }

        // ToString override method to convert the collection to a string
        public override string ToString()
        {
            // Declare a return string
            string returnString = "";

            // Loop through all of the beverages
            foreach (Droid droid in droids)
            {
                // If the current beverage is not null, concat it to the return string
                if (droid != null)
                {
                    returnString += droid.ToString() + Environment.NewLine;
                }
            }
            // Return the return string
            return returnString;
        }
        
    }
}
