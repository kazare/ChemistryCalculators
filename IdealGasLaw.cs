using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistryCalculators
{
    //Parent class
    class IdealGasLaw
    {
        double gas;

        //Get/Set values to user in child classes
        public double Gas { get { return gas; }  set { gas = 8.314; } }
        public double Mole { get; set; }
        public double Temp { get; set; }

    }
}
