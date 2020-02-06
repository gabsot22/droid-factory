using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UserInterface
    {

        const int MAX_MENU_CHOICES = 3;

        //No Variables
        //No Properties
        //No Constructors (but we could if we needed to)

        //******************************
        // PUBLIC METHODS
        //******************************
        // Display Welcome Greeting
        public void DisplayWelcomeGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Droid Factory!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Display Menu And Get Response
        public int DisplayMenuAndGetResponse()
        {
            // Declare variable to hold the selection
            string selection;

            // Display menu, and prompt
            this.DisplayMenu();
            this.DisplayPrompt();

            // Get the selection they enter
            selection = this.GetSelection();

            // While the response is not valid
            while (!this.VerifySelectionIsValid(selection))
            {
                // Display error message
                this.DisplayErrorMessage();

                // Display the prompt again
                this.DisplayPrompt();

                // Get the selection again
                selection = this.GetSelection();
            }
            // Return the selection casted to an integer
            return Int32.Parse(selection);
        }

        // Get New Item Information From The User.
        public string[] GetNewDroidInformation()
        {
            string name = this.GetNameField("Name");
            string type = this.GetTypeField("Type");

            return new string[] { name, type };
        }

        // Display All Items
        public void DisplayAllItems(string allItemsOutput)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Printing List");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(this.GetDroidHeader());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(allItemsOutput);
        }

        // Display All Items Error
        public void DisplayAllItemsError()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are no droids in the list to print");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Display Add Droid Item Success
        public void DisplayAddDroidItemSuccess()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Droid was successfully added");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Display Droid Already Exists Error
        public void DisplayItemAlreadyExistsError()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A Droid With That Name Already Exists");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //**********************
        // PRIVATE METHODS
        //**********************
        private void DisplayMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new Droid");
            Console.WriteLine("2. Print Droid List");
            Console.WriteLine("3. Exit");
        }

        // Display the Prompt
        private void DisplayPrompt()
        {
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");
        }

        // Display the Error Message
        private void DisplayErrorMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That is not a valid option. Please make a valid choice");
        }

        // Get the selection from the user
        private string GetSelection()
        {
            return Console.ReadLine();
        }

        // Verify that a selection from the main menu is valid
        private bool VerifySelectionIsValid(string selection)
        {
            // Declare a returnValue and set it to false
            bool returnValue = false;

            try
            {
                // Parse the selection into a choice variable
                int choice = Int32.Parse(selection);

                // If the choice is between 0 and the maxMenuChoice
                if (choice > 0 && choice <= MAX_MENU_CHOICES)
                {
                    // Set the return value to true
                    returnValue = true;
                }
            }
            // If the selection is not a valid number, this exception will be thrown
            catch (Exception e)
            {
                // Set return value to false even though it should already be false
                returnValue = false;
            }

            // Return the reutrnValue
            return returnValue;
        }

        // Get a valid string field from the console
        private string GetNameField(string fieldName)
        {
            Console.WriteLine("What is the new Droid's {0}", fieldName);
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value))
                {
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a value.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Droid's {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a valid string field from the console
        private string GetTypeField(string fieldName)
        {
            Console.WriteLine("What is the new Droids's {0}", fieldName);
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value))
                {
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a value.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Droids's {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a string formatted as a header for items
        private string GetDroidHeader()
        {
            return String.Format("{0,-6} {1,-55} {2,-15}", "Name", "Type", "Price") +
                Environment.NewLine +
                String.Format("{0,-6} {1,-55} {2,-15}", new String('-', 6), new String('-', 40), new String('-', 15));
        }
    }
}
