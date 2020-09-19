using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistryCalculators
{
    class Density : ICalc
    {
        double mass;
        double volume;

        //create constructor
        public Density(double mass, double volume)
        {
            this.mass = mass;
            this.volume = volume;
        }

        //user inherited calculator method
        //calculate using formula
        public double Calculator()
        {
            Console.WriteLine($"The density is: {mass} / {volume} = {mass / volume}");
            return mass / volume;
        }
    }
}
