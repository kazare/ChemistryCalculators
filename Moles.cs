using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistryCalculators
{
    class Moles : ICalc
    {
        double grams;
        double mass;
        //create constructor
        public Moles(double grams, double mass)
        {
            this.grams = grams;
            this.mass = mass;
        }
        //user inherited calculator method
        //calculate using formula
        public double Calculator()
        {
            Console.WriteLine($"The moles is: {grams} / {mass} = {grams / mass}");
            return grams / mass;
        }
    }
}
