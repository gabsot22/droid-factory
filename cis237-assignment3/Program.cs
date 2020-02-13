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
            Droid[] droids = new Droid[100];

            // array to hold droids
            droids[0] = new ProtocolDroid("C3PO", "Protocol", "Gold", "Gold", 5); //droids[0] = new ProtocolDroid("C3PO", "Protocol", "Gold", "Gold", 35.00m, 45.00m);
            droids[1] = new UtilityDroid("BD1", "Utility", "Amethyst", "Red", true, true, true);
            droids[2] = new AstromechDroid("R2D2", "Astromech", "Iron", "Blue", true, true, true, true, 1);   
            droids[3] = new JanitorDroid("A1Z4", "Janitor", "Iron", "Black", true, true, true, true, true);


            // Create an instance of the DroidCollection class
            DroidCollection droidCollection = new DroidCollection(droidCollectionSize);

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
                        string type = ui.GetDroidTypeInformation();
                        // Calls the UI for new Droid info and sets it to an array string
                        if (type == "Protocol")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You selected Protocol");
                            string[] newDroidInformation = ui.GetNewProtocolDroidInformation();
                            droidCollection.AddNewProtocolDroid(newDroidInformation[0],
                                                                newDroidInformation[1], 
                                                                newDroidInformation[2], 
                                                                newDroidInformation[3], 
                                                                int.Parse(newDroidInformation[4]));
                        }
                        if (type == "Utility")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You selected Utility");
                            string[] newDroidInformation = ui.GetNewUtilityDroidInformation();
                            droidCollection.AddNewUtilityDroid(newDroidInformation[0], 
                                                               newDroidInformation[1], 
                                                               newDroidInformation[2], 
                                                               newDroidInformation[3], 
                                                               bool.Parse(newDroidInformation[4]), 
                                                               bool.Parse(newDroidInformation[5]), 
                                                               bool.Parse(newDroidInformation[6]));
                        }
                        if (type == "Janitor")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You selected Janitor");
                            string[] newDroidInformation = ui.GetNewJanitorDroidInformation();
                            droidCollection.AddNewJanitorDroid(newDroidInformation[0],
                                                               newDroidInformation[1],
                                                               newDroidInformation[2],
                                                               newDroidInformation[3],
                                                               bool.Parse(newDroidInformation[4]),
                                                               bool.Parse(newDroidInformation[5]),
                                                               bool.Parse(newDroidInformation[6]),
                                                               bool.Parse(newDroidInformation[7]),
                                                               bool.Parse(newDroidInformation[8]));
                        }
                        if (type == "Astromech")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You selected Astromech");
                            string[] newDroidInformation = ui.GetNewAstromechDroidInformation();
                            droidCollection.AddNewAstromechDroid(newDroidInformation[0],
                                                               newDroidInformation[1],
                                                               newDroidInformation[2],
                                                               newDroidInformation[3],
                                                               bool.Parse(newDroidInformation[4]),
                                                               bool.Parse(newDroidInformation[5]),
                                                               bool.Parse(newDroidInformation[6]),
                                                               bool.Parse(newDroidInformation[7]),
                                                               int.Parse(newDroidInformation[8]));
                        }

                        ui.DisplayAddDroidItemSuccess();

       

                        //if (droidCollection.FindDroidName(newDroidInformation[0]) == null)
                        //{
                        //    droidCollection.AddNewDroid(newDroidInformation[0], newDroidInformation[1], newDroidInformation[2], newDroidInformation[3], int.Parse(), decimal.Parse(newDroidInformation[5]));
                        //    ui.DisplayAddDroidItemSuccess();
                        //}
                        //else
                        //{
                        //    ui.DisplayDroidAlreadyExistsError();
                        //}
                        break;

                    // Print Droid List
                    case 2:
                        string outputString = "";

                        foreach (Droid droid in droids)
                        {
                            if (droid != null)
                            {
                                //Concat to the outputString
                                outputString += droid.GetFullScreenOutput() +
                                    Environment.NewLine;
                            }
                        }


                        //string allDroidsString = droidCollection.ToString();
                        //if (!String.IsNullOrWhiteSpace(allDroidsString))
                        //{
                        //    // Display all of the items
                        //    ui.DisplayAllItems(allDroidsString);
                        //}
                        //else
                        //{
                        //    // Display error message for all items
                        //    ui.DisplayAllItemsError();
                        //}
                        break;
                }

                // Get the new choice of what to do from the user
                choice = ui.DisplayMenuAndGetResponse();
            }

        }
    }
}
