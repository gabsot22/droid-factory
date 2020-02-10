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
        private int numberLanguages;

        // Constant
        private const int costPerLanguage = 2;

        //*****************************
        //Properties
        //*****************************
        public override decimal CalculateTotalCost
        {
            get
            {
                return baseCost + (numberLanguages * costPerLanguage);
            }
        }

        //******************************
        //Public Methods
        //******************************
        public override string ToString()
        {
            return base.ToString() + " " + CalculateTotalCost.ToString("C");
        }

        public string GetTotalCostDetails()
        {
            return baseCost + " + (" + numberLanguages + " * " + costPerLanguage + ") =" + CalculateTotalCost.ToString("C");
        }


    }
}
