using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistryCalculators
{
    //Ideal Gas Law solve for Volume
 
    class IdealGasV : IdealGasLaw, ICalc
    {
        double pressure;
        //create constructor
        public IdealGasV(double mole, double temp, double pressure)
        {
            this.Mole = mole;//inherited from base
            this.Gas = Gas;
            this.Temp = temp;
            this.pressure = pressure;
        }
        //user inherited calculator method
        //calculate using formula
        public double Calculator()
        {
            Console.WriteLine($"Gas constant: {Gas}");
            Console.WriteLine($"The volume is: {Mole} * {Gas} * {Temp} / {pressure} = {Mole * Gas * Temp / pressure}");
            return Mole * Gas * Temp / pressure;
        }
    }
}
