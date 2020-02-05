using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UserInterface
    {
        //No Variables
        //No Properties
        //No Constructors (but we could if we needed to)

        //******************************
        //Methods
        //******************************
        public int GetUserInput()
        {
            //Print out a menu
            this.PrintMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While the input is not valid re-get the input
            while (input != "1" && input != "2" && input != "3")
            {
                //Print Error message
                this.PrintErrorMessage();

                //Re-print the menu
                this.PrintMenu();

                //Get the input from the console again.
                input = Console.ReadLine();
            }

            //At this point, I know the input is a valid number of either
            //a 1 or a 2.

            return Int32.Parse(input);
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new Droid");
            Console.WriteLine("2. Print Droid List");
            Console.WriteLine("3. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        // Display All Items
        public void DisplayAllItems(string allItemsOutput)
        {
            Console.WriteLine();
            Console.WriteLine("Printing List");
            Console.WriteLine();
            Console.WriteLine(allItemsOutput);
        }

        // Display All Items Error
        public void DisplayAllItemsError()
        {
            Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are no items in the list to print");
            //Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
