using System;

namespace cis237_assignment3
{
    interface IDroid
    {

        string NameTypeMaterialColor();

        string GetFullScreenOutput();

        // Method to calculate the total cost of a droid
        string CalculateTotalCost();

        // Property to get the total cost of a droid
        decimal TotalCost { get; }
    }
}
