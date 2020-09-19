using System;

namespace ChemistryCalculators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Validatoin method that determines if argument is a number.
            bool Validation(string num)
            {
                if (Double.TryParse(num, out double number))
                {
                    return true;
                }
                else
                {
                    Console.Write($" \"{num}\" is not a number. Try again: "); //tell user their mistake
                    return false;
                }
            }

            bool running = true;
            //Allow program to continoulsy run
            while (running)
            {
                //Menu
                Console.WriteLine("\nChoose your formula:");
                Console.WriteLine(@"[1] Density
[2] Moles
[3] Energy of a Wave
[4] Ideal Gas Law
[exit] End program");
                Console.Write("Enter: ");
                string menuSelect = Console.ReadLine();

                //switch case for menyu options
                switch (menuSelect)
                {
                    case "1": //Density
                        Console.WriteLine("\nDensity: p = mass /volume");
                        Console.Write("Mass: ");
                        string Dmass = Console.ReadLine();

                        //take user input into validation method
                        //if not a number ask user again until value returns true
                        while (!Validation(Dmass))
                        {
                            Dmass = Console.ReadLine();
                        }

                        Console.Write("Volume: ");
                        string Dvolume = Console.ReadLine();

                        while (!Validation(Dvolume))
                        {
                            Dvolume = Console.ReadLine();
                        }

                        //if all inputs are numbers create object
                        //convert to double
                        //call function
                        Density density = new Density(Double.Parse(Dmass), Double.Parse(Dvolume));
                        density.Calculator();
                        break;

                    case "2": //Moles
                        Console.WriteLine("\nMoles: moles = grams / mass ");

                        Console.Write("Grams: ");
                        string grams = Console.ReadLine();
                        while (!Validation(grams))
                        {
                            grams = Console.ReadLine();
                        }

                        Console.Write("Mass: ");
                        string Mmass = Console.ReadLine();
                        while (!Validation(Mmass))
                        {
                            Mmass = Console.ReadLine();
                        }

                        Moles moles = new Moles(Double.Parse(grams), Double.Parse(Mmass));
                        moles.Calculator();
                        break;

                    case "3": //Energy of a Wave
                        Console.WriteLine("\nEnergy of a Wave: E = hv");
                        Console.Write("Frequency: ");
                        string frequency = Console.ReadLine();

                        while (!Validation(frequency))
                        {
                            frequency = Console.ReadLine();
                        }

                        EnergyWave energywave = new EnergyWave(Double.Parse(frequency));
                        energywave.Calculator();
                        break;

                    case "4": //Ideal Gas Law
                        bool gaschoose = true;
                        string mole;
                        string temp;

                        //menu option
                        Console.WriteLine("\nIdeal Gas Law: PV = nRT");
                        Console.WriteLine(@"Solve for: 
[1] Pressure
[2] Volume ");
                        Console.Write("Enter: ");
                        string choice = Console.ReadLine();

                       
                        while (gaschoose)
                        {
                            if (choice == "1")//Pressure
                            {
                                Console.WriteLine("\nSolving for Pressure:");
                                Console.Write("Mole: ");
                                mole = Console.ReadLine();
                                while (!Validation(mole))
                                {
                                    mole = Console.ReadLine();
                                }

                                Console.Write("Temp (K): ");
                                temp = Console.ReadLine();
                                while (!Validation(temp))
                                {
                                    temp = Console.ReadLine();
                                }

                                Console.Write("Volume: ");
                                string volume = Console.ReadLine();
                                while (!Validation(volume))
                                {
                                    volume = Console.ReadLine();
                                }

                                IdealGasP gasP = new IdealGasP(Double.Parse(mole), Double.Parse(temp), Double.Parse(volume));
                                gasP.Calculator();
                                gaschoose = false;//stop prompting
                            }
                            else if (choice == "2") //Volume
                            {
                                //Solve for Volume
                                Console.WriteLine("\nSolving for Volume:");
                                Console.Write("Mole: ");
                                mole = Console.ReadLine();
                                while (!Validation(mole))
                                {
                                    mole = Console.ReadLine();
                                }

                                Console.Write("Temp (K): ");
                                temp = Console.ReadLine();
                                while (!Validation(temp))
                                {
                                    temp = Console.ReadLine();
                                }

                                Console.Write("Pressure: ");
                                string pressure = Console.ReadLine();
                                while (!Validation(pressure))
                                {
                                    pressure = Console.ReadLine();
                                }

                                IdealGasV gasV = new IdealGasV(Double.Parse(mole), Double.Parse(temp), Double.Parse(pressure));
                                gasV.Calculator();
                                gaschoose = false;
                            }
                            else
                            {
                                //if user inputs incorrect option, prompt again
                                Console.WriteLine("Please a choose number 1 or 2: ");
                                Console.Write("Enter: ");
                                choice = Console.ReadLine().ToLower();
                                gaschoose = true;
                            }
                        }
                        break;

                    case "exit":
                        running = false; //end program
                        break;
                    default:
                        Console.WriteLine("Please a choose a number 1-4");//tell user their mistake
                        break;
                }
            }
        }
    }
}
