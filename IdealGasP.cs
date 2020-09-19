using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistryCalculators
{
    //Ideal Gas Law solve for Pressure
    class IdealGasP : IdealGasLaw, ICalc
    {
        double volume;
        //create constructor
        public IdealGasP(double mole, double temp, double volume)
        {
            this.Mole = mole; //inherit from base
            this.Gas = Gas;
            this.Temp = temp;
            this.volume = volume;
        }
        //user inherited calculator method
        //calculate using formula
        public double Calculator()
        {
            Console.WriteLine($"Gas constant: {Gas}");
            Console.WriteLine($"The pressure is: {Mole} * {Gas} * {Temp} / {volume} = {Mole * Gas * Temp / volume}");
            return Mole * Gas * Temp / volume;
        }
    }
}
