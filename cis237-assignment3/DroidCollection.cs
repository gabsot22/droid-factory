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
        public void AddNewProtocolDroid(string name, string type, string material, string color)
        {
            droids[droidLength] = new ProtocolDroid(name, type, material, color, 1);
            droidLength++;
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

        // Find an item by Droid's Name
        public string FindDroidName(string name)
        {
            // Declare return string for the possible found item
            string returnString = null;

            // For each Droid in droids
            foreach (Droid droid in droids)
            {
                // If the beverage is not null
                if (droid != null)
                {
                    // If the droid Name is the same as the search Name{
                    if (droid.Name == name)
                    {
                        // Set the return string to the result of the droid's ToString method
                        returnString = droid.ToString();
                    }
                }
            }
            // Return the returnString
            return returnString;
        }
         
    }
}
