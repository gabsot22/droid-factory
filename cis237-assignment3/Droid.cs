using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    abstract class Droid : IDroid
    {

        // Constants
        protected const decimal IRON = 5;
        protected const decimal GOLD = 10;
        protected const decimal AMETHYST = 15;

        //*****************************
        // Class level Variables
        //*****************************
        //private string name;


        // Must be protected so that they are available in the child / derived classes.
        protected string name;
        protected string type;

        protected string material;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;


        //****************************
        // Properties
        //****************************
        // Public property to get the Name to search for Droid Name
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        // Forces child classes to make a Salary Property.
        public abstract decimal CalculateTotalCost { get; }

        // LOOK AT THE PRICE ABSTRACT DECMAL AND COMPARE!!!!!!!!!!!!!!!!!

        //***************************
        // Protected Methods
        //***************************
        protected decimal CalculateBaseCost()
        {
            return IRON;
        }

        //***************************
        // Methods
        //***************************
        public override string ToString()
        {
            return name + " " + type + " " + material + " " + color;
        }

        public string GetFullScreenOutput()
        {
            // Even though this class does not have a backing field for the Salary it does
            // have the property declared abstract. This means the following:
            // 1. This class must be abstract and can not make instances of it.
            // 2. Any intstance must therefor override the Salary property and provide
            // an implementation for it.
            // Because of this, this method will always work.
            return name + " " + type + " " + material + " " + color + " " + CalculateBaseCost.ToString("C") + " " + CalculateTotalCost.ToString("C");
        }

        // Made this method virtual so that child classes could provide a different
        // implementation if they would like to. If not, when a call is made to this method
        // it will work up the chain until it finds one with this method.
        public virtual string NameTypeMaterialColor()
        {
            return name + " " + type + " " + material + " " + color;
        }

        // An Abstract method. This means that it MUST be overridden
        // by child classes. It also can not have a method body and
        // can only be declared in a abstract class.

        public abstract decimal GetCalculateTotalCost();



        //***************************************
        // Constructor
        //***************************************
        public Droid(string Name, string Type, string Material, string Color)
        {
            this.name = Name;
            this.type = Type;
            this.material = Material;
            this.color = Color;
        }
        
    }
}
