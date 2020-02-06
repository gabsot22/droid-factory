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
            droids[0] = new AstromechDroid("R2D2", "Astromech", 50.00m);
            droids[1] = new ProtocolDroid("R2D2", "Protocol", 25.00m);
            droids[2] = new UtilityDroid("R2D2", "Utility", 15.00m);
            droids[3] = new JanitorDroid("A1Z4", "Janitor", 5.00m);


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
                        string[] newItemInformation = ui.GetNewDroidInformation();
                        if (droidCollection.FindById(newItemInformation[0]) == null)
                        {
                            droidCollection.AddNewItem(
                                newItemInformation[0],
                                newItemInformation[1],
                                newItemInformation[2],
                                decimal.Parse(newItemInformation[3]),
                                (newItemInformation[4] == "True")
                            );
                            ui.DisplayAddDroidItemSuccess();
                        }
                        else
                        {
                            ui.DisplayItemAlreadyExistsError();
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
