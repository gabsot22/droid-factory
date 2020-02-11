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
            // Set a constant for the size of the droidCollection
            const int droidCollectionSize = 100;

            // Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();

            //Let's make an array to hold a bunch of instances of the Employee class
            IDroid[] droids = new IDroid[100];

            // array to hold droids
            droids[0] = new ProtocolDroid("C3PO", "Protocol", "Gold", "Gold", 35.00m, 45.00m);
            droids[1] = new UtilityDroid("BD1", "Utility", "Amethyst", "Red", 30.00m, 33.00m);
            droids[2] = new AstromechDroid("R2D2", "Astromech", "Iron", "Blue", 55.00m, 57.00m);   
            droids[3] = new JanitorDroid("A1Z4", "Janitor", "Iron", "Black", 10.00m, 12.00m);


            // Create an instance of the DroidCollection class
            DroidCollection droidCollection = new DroidCollection(droidCollectionSize);

            // Add some droids to the array



            // Display the Welcome Message to the user
            ui.DisplayWelcomeGreeting();

            // Display the Menu and get the response. Store the response in the choice integer
            // This is the 'primer' run of displaying and getting.
            int choice = ui.DisplayMenuAndGetResponse();

            // While the choice selected is not 2, continue to do work
            while (choice != 3)
            {
                switch (choice)
                {
                    // Add A New Droid To The List
                    case 1:
                        // Calls the UI for new Droid info and sets it to an array string
                        string[] newDroidInformation = ui.GetNewDroidInformation();
                        // NEED TO CALCULATE THE COSTS HERE OR DURING THE UI STEPS AFTER ASKING WHAT COLOR USER WANTS

                        if (droidCollection.FindDroidName(newDroidInformation[0]) == null)
                        {
                            //droidCollection.AddNewDroid(newDroidInformation[0], newDroidInformation[1], newDroidInformation[2], newDroidInformation[3], decimal.Parse(newDroidInformation[4]), decimal.Parse(newDroidInformation[5]));
                            ui.DisplayAddDroidItemSuccess();
                        }
                        else
                        {
                            ui.DisplayDroidAlreadyExistsError();
                        }
                        break;

                    // Print Droid List
                    case 2:
                        
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

                // Get the new choice of what to do from the user
                choice = ui.DisplayMenuAndGetResponse();
            }

        }
    }
}
