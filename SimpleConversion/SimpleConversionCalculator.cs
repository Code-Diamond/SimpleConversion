
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConversion
{
    public class SimpleConversionCalculator
    {
        private static decimal[] distanceConversionFactors =
        {
            .083333m,             // [0] Inches to Feet
            2.54m,                // [1] Inches to Centimeters
            .0254m,               // [2] Inches to Meters
            .0000254m,            // [3] Inches to Kilometers
            .0000157828282828m,   // [4] Inches to Miles
            12,                   // [5] Feet to Inches
            30.48m,               // [6] Feet to Centimetes
            .3048m,               // [7] Feet to Meters
            .0003048m,            // [8] Feet to Kilometers
            .000189394m,          // [9] Feet to Miles
            .3937009133858m,      // [10] Centimeters to Inches
            .03280840944882m,     // [11] Centimeters to Feet
            .01m,                 // [12] Centimeters to Meters
            .00001m,              // [13] Centimeters to Kilometers
            .0000062137m,         // [14] Centimeters to Miles
            39.3701m,             // [15] Meters to Inches
            3.28084m,             // [16] Meters to Feet
            100,                  // [17] Meters to Centimeters
            .001m,                // [18] Meters to Kilometers
            .000621371m,          // [19] Meters to Miles
            39370.1m,             // [20] Kilometers to Inches
            3280.84m,             // [21] Kilometers to Feet
            100000,               // [22] Kilometers to Centimeters
            1000,                 // [23] Kilometers to Meters
            .621371m,             // [24] Kilometers to Miles
            63360,                // [25] Miles to Inches
            5280,                 // [26] Miles to Feet
            160934,               // [27] Miles to Centimeters
            1609.34m,             // [28] Miles to Meters
            1.60934m              // [29] Miles to Kilometers
        };

        private static decimal[] massConversionFactors =
        {
            .001m,               // [0] Grams to KiloGrams
            .00220462m,          // [1] Grams to Pounds
            .035274m,            // [2] Grams to Ounces
            1000,                // [3] KiloGrams to Grams
            2.20462m,            // [4] KiloGrams to Pounds
            35.274m,             // [5] KiloGrams to Ounces
            453.59237m,            // [6] Pounds to Grams
            .453592m,            // [7] Pounds to Kilograms
            16,                  // [8] Pounds to Ounces
            28.3495m,            // [9] Ounces to Grams
            0.0283495m,          // [10]  Ounces to Kilogram
            .0625m               // [11] Ounces to Pounds
         };

        private static decimal[] timeConversionFactors =
        {
            .0166667m,               // [0] Seconds to Minutes
            .000277778m,             // [1] Seconds to Hours
            1.157409722e-5m,         // [2] Seconds to Days
            1.65344246e-6m,          // [3] Seconds to Weeks
            3.170985539726028e-8m,   // [4] Seconds to Years
            60,                      // [5] Minutes to Seconds
            .0166667m,               // [6] Minutes to Hours
            .00069444583333m,        // [7] Minutes to Days
            9.920654761857141876e-5m,// [8] Minutes to Weeks
            1.902591324191780625e-6m,// [9] Minutes to Years
            3600,                    // [10] Hours to Seconds
            60,                      // [11] Hours to Minutes
            .0416667m,               // [12] Hours to Days
            .00595238571429m,        // [13] Hours to Weeks
            .0001141553424658356045m,// [14] Hours to Years
            86400,                   // [15] Days to Seconds
            1440,                    // [16] Days to Minutes
            24,                      // [17] Days to Hours
            0.142857m,               // [18] Days to Weeks
            0.0027397232877m,        // [19] Days to Years
            604800,                  // [20] Weeks to Seconds
            10080,                   // [21] Weeks to Minutes
            168,                     // [22] Weeks to Hours
            7,                       // [23] Weeks to Days
            0.0191781m,              // [24] Weeks to Years
            3.154e+7m,               // [25] Years to Seconds
            525600,                  // [26] Years to Minutes
            8760,                    // [27] Years to Hours
            365.2422m,               // [28] Years to Days
            52.1429m,                // [29] Years to Weeks
        };

        public decimal Convert(string initialUnit, string resultingUnit, decimal userInput)
        {
            decimal conversionFactor = 1;

            //A nested switch algorithm I created to control conversion
            switch (initialUnit)
            {
                case "Inches":
                    switch (resultingUnit)
                    {
                        case "Inches":
                            conversionFactor = 1;
                            break;
                        case "Feet":
                            conversionFactor = distanceConversionFactors[0];
                            break;
                        case "Centimeters":
                            conversionFactor = distanceConversionFactors[1];
                            break;
                        case "Meters":
                            conversionFactor = distanceConversionFactors[2];
                            break;
                        case "Kilometers":
                            conversionFactor = distanceConversionFactors[3];
                            break;
                        case "Miles":
                            conversionFactor = distanceConversionFactors[4];
                            break;
                    }
                    break;
                case "Feet":
                    switch (resultingUnit)
                    {
                        case "Inches":
                            conversionFactor = distanceConversionFactors[5];
                            break;
                        case "Feet":
                            conversionFactor = 1;
                            break;
                        case "Centimeters":
                            conversionFactor = distanceConversionFactors[6];
                            break;
                        case "Meters":
                            conversionFactor = distanceConversionFactors[7];
                            break;
                        case "Kilometers":
                            conversionFactor = distanceConversionFactors[8];
                            break;
                        case "Miles":
                            conversionFactor = distanceConversionFactors[9];
                            break;

                    }
                    break;
                case "Centimeters":
                    switch (resultingUnit)
                    {
                        case "Inches":
                            conversionFactor = distanceConversionFactors[10];
                            break;
                        case "Feet":
                            conversionFactor = distanceConversionFactors[11];
                            break;
                        case "Centimeters":
                            conversionFactor = 1;
                            break;
                        case "Meters":
                            conversionFactor = distanceConversionFactors[12];
                            break;
                        case "Kilometers":
                            conversionFactor = distanceConversionFactors[13];
                            break;
                        case "Miles":
                            conversionFactor = distanceConversionFactors[14];
                            break;
                    }
                    break;
                case "Meters":
                    switch (resultingUnit)
                    {
                        case "Inches":
                            conversionFactor = distanceConversionFactors[15];
                            break;

                        case "Feet":
                            conversionFactor = distanceConversionFactors[16];
                            break;

                        case "Centimeters":
                            conversionFactor = distanceConversionFactors[17];
                            break;

                        case "Meters":
                            conversionFactor = 1;
                            break;
                        case "Kilometers":
                            conversionFactor = distanceConversionFactors[18];
                            break;

                        case "Miles":
                            conversionFactor = distanceConversionFactors[19];
                            break;

                    }
                    break;
                case "Kilometers":
                    switch (resultingUnit)
                    {
                        case "Inches":
                            conversionFactor = distanceConversionFactors[20];
                            break;

                        case "Feet":
                            conversionFactor = distanceConversionFactors[21];
                            break;

                        case "Centimeters":
                            conversionFactor = distanceConversionFactors[22];
                            break;

                        case "Meters":
                            conversionFactor = distanceConversionFactors[23];
                            break;

                        case "Kilometers":
                            conversionFactor = 1;
                            break;
                        case "Miles":
                            conversionFactor = distanceConversionFactors[24];
                            break;


                    }
                    break;
                case "Miles":
                    switch (resultingUnit)
                    {
                        case "Inches":
                            conversionFactor = distanceConversionFactors[25];
                            break;

                        case "Feet":
                            conversionFactor = distanceConversionFactors[26];
                            break;

                        case "Centimeters":
                            conversionFactor = distanceConversionFactors[27];
                            break;

                        case "Meters":
                            conversionFactor = distanceConversionFactors[28];
                            break;

                        case "Kilometers":
                            conversionFactor = distanceConversionFactors[29];
                            break;

                        case "Miles":
                            conversionFactor = 1;
                            break;
                    }
                    break;
                case "Grams":
                    switch (resultingUnit)
                    {
                        case "Grams":
                            conversionFactor = 1;
                            break;
                        case "Kilograms":
                            conversionFactor = massConversionFactors[0];
                            break;
                        case "Pounds":
                            conversionFactor = massConversionFactors[1];
                            break;
                        case "Ounces":
                            conversionFactor = massConversionFactors[2];
                            break;
                    }
                    break;
                case "Kilograms":
                    switch (resultingUnit)
                    {
                        case "Grams":
                            conversionFactor = massConversionFactors[3];
                            break;
                        case "Kilograms":
                            conversionFactor = 1;
                            break;
                        case "Pounds":
                            conversionFactor = massConversionFactors[4];
                            break;
                        case "Ounces":
                            conversionFactor = massConversionFactors[5];
                            break;
                    }
                    break;
                case "Pounds":
                    switch (resultingUnit)
                    {
                        case "Grams":
                            conversionFactor = massConversionFactors[6];
                            break;
                        case "Kilograms":
                            conversionFactor = massConversionFactors[7];
                            break;
                        case "Pounds":
                            conversionFactor = 1;
                            break;
                        case "Ounces":
                            conversionFactor = massConversionFactors[8];
                            break;
                    }
                    break;
                case "Ounces":
                    switch (resultingUnit)
                    {
                        case "Grams":
                            conversionFactor = massConversionFactors[9];
                            break;
                        case "Kilograms":
                            conversionFactor = massConversionFactors[10];
                            break;
                        case "Pounds":
                            conversionFactor = massConversionFactors[11];
                            break;
                        case "Ounces":
                            conversionFactor = 1;
                            break;
                    }
                    break;
                case "Seconds":
                    switch (resultingUnit)
                    {
                        case "Seconds":
                            conversionFactor = 1;
                            break;
                        case "Minutes":
                            conversionFactor = timeConversionFactors[0];
                            break;
                        case "Hours":
                            conversionFactor = timeConversionFactors[1];
                            break;
                        case "Days":
                            conversionFactor = timeConversionFactors[2];
                            break;
                        case "Weeks":
                            conversionFactor = timeConversionFactors[3];
                            break;
                        case "Years":
                            conversionFactor = timeConversionFactors[4];
                            break;
                    }
                    break;
                case "Minutes":
                    switch (resultingUnit)
                    {
                        case "Seconds":
                            conversionFactor = timeConversionFactors[5];
                            break;
                        case "Minutes":
                            conversionFactor = 1;
                            break;
                        case "Hours":
                            conversionFactor = timeConversionFactors[6];
                            break;
                        case "Days":
                            conversionFactor = timeConversionFactors[7];
                            break;
                        case "Weeks":
                            conversionFactor = timeConversionFactors[8];
                            break;
                        case "Years":
                            conversionFactor = timeConversionFactors[9];
                            break;
                    }
                    break;
                case "Hours":
                    switch (resultingUnit)
                    {
                        case "Seconds":
                            conversionFactor = timeConversionFactors[10];
                            break;
                        case "Minutes":
                            conversionFactor = timeConversionFactors[11];
                            break;
                        case "Hours":
                            conversionFactor = 1;
                            break;
                        case "Days":
                            conversionFactor = timeConversionFactors[12];
                            break;
                        case "Weeks":
                            conversionFactor = timeConversionFactors[13];
                            break;
                        case "Years":
                            conversionFactor = timeConversionFactors[14];
                            break;
                    }
                    break;
                case "Days":
                    switch (resultingUnit)
                    {
                        case "Seconds":
                            conversionFactor = timeConversionFactors[15];
                            break;
                        case "Minutes":
                            conversionFactor = timeConversionFactors[16];
                            break;
                        case "Hours":
                            conversionFactor = timeConversionFactors[17];
                            break;
                        case "Days":
                            conversionFactor = 1;
                            break;
                        case "Weeks":
                            conversionFactor = timeConversionFactors[18];
                            break;
                        case "Years":
                            conversionFactor = timeConversionFactors[19];
                            break;
                    }
                    break;
                case "Weeks":
                    switch (resultingUnit)
                    {

                        case "Seconds":
                            conversionFactor = timeConversionFactors[20];
                            break;
                        case "Minutes":
                            conversionFactor = timeConversionFactors[21];
                            break;
                        case "Hours":
                            conversionFactor = timeConversionFactors[22];
                            break;
                        case "Days":
                            conversionFactor = timeConversionFactors[23];
                            break;
                        case "Weeks":
                            conversionFactor = 1;
                            break;
                        case "Years":
                            conversionFactor = timeConversionFactors[24];
                            break;

                    }
                    break;
                case "Years":
                    switch (resultingUnit)
                    {
                        case "Seconds":
                            conversionFactor = timeConversionFactors[25];
                            break;
                        case "Minutes":
                            conversionFactor = timeConversionFactors[26];
                            break;
                        case "Hours":
                            conversionFactor = timeConversionFactors[27];
                            break;
                        case "Days":
                            conversionFactor = timeConversionFactors[28];
                            break;
                        case "Weeks":
                            conversionFactor = timeConversionFactors[29];
                            break;
                        case "Years":
                            conversionFactor = 1;
                            break;

                    }
                    break;
                case "Celsius":
                    switch (resultingUnit)
                    {

                        case "Celsius":
                            conversionFactor = 1;
                            break;
                        case "Fahrenheit":

                            //Celsius to Fahrenheit formula
                            //Celsius = userInput;
                            decimal fahrenheit = (userInput * (decimal)1.8m) + 32;   // Celsius * 9/5 + 32

                            return fahrenheit;
                        case "Kelvin":

                            //Celsius to Kelvin formula
                            decimal kelvin = (userInput - (decimal)273.15m);

                            return kelvin;
                    }
                    break;
                case "Fahrenheit":
                    switch (resultingUnit)
                    {

                        case "Celsius":

                            //Fahrenheit to Celcius formula
                            decimal celsius = ((decimal)5 / 9) * (userInput - 32);  // 5/9 (F-32)

                            return celsius;
                        case "Fahrenheit":
                            conversionFactor = 1;
                            break;
                        case "Kelvin":
                            //Fahrenheit to Kelvin formula
                            decimal kelvin = (userInput + (decimal) 459.67m) * ((decimal) 5/9);

                            return kelvin;
                    }
                    break;
                case "Kelvin":
                    switch (resultingUnit)
                    {

                        case "Celsius":
                            decimal celsius = userInput + (decimal)273.15m;
                            return celsius;
                        case "Fahrenheit":
                            decimal fahrenheit = (decimal)1.8m * (userInput - 273.15m) + 32;
                            return fahrenheit;
                        case "Kelvin":
                            conversionFactor = 1;
                            break;
                    }
                    break;




            }
            decimal result = userInput * conversionFactor;
            
            return result;
        }
    }
}
