using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistryCalculators
{
    class EnergyWave : ICalc
    {
        double frequency;
        
        //create constructor
        public EnergyWave(double frequency)
        {
            this.frequency = frequency;
        }
        double planck = 6.626 * Math.Pow(10, -34); //save Planck's Constant to variable

        //user inherited calculator method
        //calculate using formula
        public double Calculator()
        {
            Console.WriteLine($"The energy of a wave is: {planck} * {frequency} = {planck * frequency}");
            return planck * frequency;
        }
    }
}
