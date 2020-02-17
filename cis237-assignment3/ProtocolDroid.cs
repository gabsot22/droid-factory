using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    // To inherit from a class use of a : and then the class name.
    // These are called parent class, or super class, or base class.
    class ProtocolDroid : Droid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        public int numberLanguages;

        // Constant
        private const int costPerLanguage = 2;

        //*****************************
        //Properties
        //*****************************
        public override decimal TotalCost
        {
            get
            {
                return CalculateBaseCost() + (numberLanguages * costPerLanguage);
            }
        }

        //******************************
        //Public Methods
        //******************************
        public override string ToString()
        {
            // Ask the parent to do the first and last name part by
            // calling ToString on the parent/base class
            return base.ToString() + " " + TotalCost.ToString("C");
            // Does not have to be the same method. Could be a different one.
            // This would work too.
            // return base.FirstAndLastName() + " " + Salary.ToString("C");
        }

        public string GetTotalCostDetails()
        {
            return CalculateBaseCost() + " + (" + numberLanguages + " * " + costPerLanguage + ") =" + TotalCost.ToString("C");
        }

        // Added this so that we override the abstract method in the parent.
        // We were required to do so because the method was abstract.
        public override decimal CalculateTotalCost()
        {
            return TotalCost;
        }

        //*****************************
        //Constructors
        //*****************************
        public ProtocolDroid(
            string Name,
            string Type,
            string Material,
            string Color,
            int NumberLanguages
        // Call the parent constructor with the base keyword and send it
        // the first and last name we just collected from the parameters
        // above this comment.
        ) : base(Name, Type, Material, Color)
        {
            // No need to set the first and last name variables.
            // will be handled by the parent/base constructor.
            this.numberLanguages = NumberLanguages;
        }


    }
}
