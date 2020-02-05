using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class DroidCollection
    {
        // Makes an array to hold instances of droids in DroidCollection class
        DroidCollection[] droids = new DroidCollection[100];

        //string[] droids;
        
        public void StoreDroids()
        {
            droids[0] = new DroidCollection("d");
        }

    }
}
