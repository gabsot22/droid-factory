using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();

            DroidCollection droidCollection = new DroidCollection();

       

            // Get input from the user
            int choice = ui.GetUserInput();

            // While the choice selected is not 2, continue to do work
            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        // Print Droid List
                        string allDroidsString = droidCollection.ToString();
                        if (!String.IsNullOrWhiteSpace(allDroidsString))
                        {
                            // Display all of the items
                            ui.DisplayAllItems(allDroidsString);
                        }
                        else
                        {
                            // Display error message for all items
                            ui.DisplayAllItemsError();
                        }
                        break;
                }
                
            }

        }
    }
}
