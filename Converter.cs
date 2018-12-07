// Program creates UnitConverter Type used to convert measurements. 
// Program uses OOP with no static members. 

// Our CS 101 teacher, Harold, asked how long our hair grows in Miles. 
// I resolved the problem here using code.

// Original converter class code from C# 4.0 in a Nutshell, Ch.1 p.14
// Added inches (hair growth length) to miles converter
//Trevor Heehs, 10/31/18

using System;

namespace Haircut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate UnitConverter objects, pass units of conversion as args.
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            // Instantiate inchesToMiles object for Hair Length in Miles. 
            UnitConverter inchesToMilesConverter = new UnitConverter(63360);

            Console.WriteLine($"1 foot is: {feetToInchesConverter.Convert(1)} inches");

            Console.WriteLine($"1 mile is: {milesToFeetConverter.Convert(1)} feet");

            // Inner method called first, then outer method

            Console.WriteLine($"1 mile is: {feetToInchesConverter.Convert(milesToFeetConverter.Convert(1))} inches");

            // Printed result of 1 inch of hair growth in miles using exponential form.
            Console.WriteLine($"1 inch of hair is: {inchesToMilesConverter.ConvertMiles(1).ToString("E10")} miles.");
        }

    }
    // Create UnitConverter Type to handle all conversions.    
    class UnitConverter
    {
        // Field.
        private int ratio;

        // Constructor.
        public UnitConverter(int unitRatio)
        {
            ratio = unitRatio;
        }

        // Generic Convert Method declaration.
        public int Convert(int unit)  
        {
            return unit * ratio;
        }
        
        // Harold's method for hair growth to miles conversion.
        // Inches to Miles requires division not multiplication, so  
        // declared new method. 
        public decimal ConvertMiles(int numberOfInches)
        {
            // Cast to decimal required for printing in exponential form.
            decimal result = (decimal)numberOfInches / (decimal)ratio;
            return result;
        }
    }
}