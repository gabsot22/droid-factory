using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Droid
    {
        // Private Class Level Variables
        //private string id;
        private string name;
        private string type;
        private decimal price;
        //private string pack;
        //private bool active;

        // Public Property to get the Id
        //public string Id
        //{
        //    get
        //    {
        //        return this.id;
        //    }
        //}

        // Default Constructor
        public Droid() { }

        // 5 Parameter Constructor
        public Droid(string name, string type, decimal price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        // Override ToString Method to concatenate the fields together.
        public override string ToString()
        {
            return String.Format(
                "{0,6} {1,-55} {2,-15}", this.name, this.type, this.price);
        }
    }
}
