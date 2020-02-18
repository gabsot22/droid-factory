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
        // Additional Options
        protected const int TOOL_BOX_CONST = 1;
        protected const int COMPUTER_CONNECTION_CONST = 1;
        protected const int ARM_CONST = 1;
        protected const int FIRE_EXTINGUISHER_CONST = 1;
        protected const int TRASH_COMPACTOR_CONST = 1;
        protected const int VACUUM_CONST = 1;

        protected const int NUMBER_OF_SHIPS_CONST = 3;
        

        //*****************************
        // Class level Variables
        //*****************************
        //private string name;


        // Must be protected so that they are available in the child / derived classes.
        protected string name;
        protected string type;
        protected decimal typeCost;


        protected string material;
        protected decimal materialCost;

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

        // Forces child classes to make a TotalCost Property.
        public virtual decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        // LOOK AT THE PRICE ABSTRACT DECMAL AND COMPARE!!!!!!!!!!!!!!!!!

        //***************************
        // Protected Methods
        //***************************
        protected decimal CalculateBaseCost()
        {
            if (material == "Iron" || material == "iron")
            {
                materialCost = 5;
            }
            if (material == "Gold" || material == "gold")
            {
                materialCost = 10;
            }
            if(material == "Amethyst" || material == "amethyst")
            {
                materialCost = 15;
            }
            if (type == "Protocol" || type == "protocol")
            {
                typeCost = 25;
            }
            if (type == "Astromech" || type == "astromech")
            {
                typeCost = 50;
            }
            if (type == "Utility" || type == "utility")
            {
                typeCost = 15;
            }
            if (type == "Janitor" || type == "janitor")
            {
                typeCost = 5;
            }
            baseCost = typeCost + materialCost;
            return typeCost + materialCost; //decimal.Parse(typeCost + materialCost)
        }

        //***************************
        // Methods
        //***************************
        public override string ToString()
        {
            return name + " " + type + " " + material + " " + color + " " + CalculateBaseCost().ToString("C");
        }


        // An Abstract method. This means that it MUST be overridden
        // by child classes. It also can not have a method body and
        // can only be declared in a abstract class.
        public virtual void CalculateTotalCost()
        {
            totalCost = CalculateBaseCost();
        }




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
