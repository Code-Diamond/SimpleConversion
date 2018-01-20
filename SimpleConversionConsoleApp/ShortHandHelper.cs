using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConversionConsoleApp
{
    public class ShortHandHelper
    {
        //The helper class is a switch statement that detects possible user inputs
        public string ParseShortHand(string initialUnits)
        {
            switch (initialUnits)
            {

                case "C":
                    return "Celsius";
                case "CE":
                    return "Celsius";
                case "CEL":
                    return "Celsius";
                case "CELS":
                    return "Celsius";

                case "CM":
                    return "Centimeters";
                case "CMS":
                    return "Centimeters";
                case "CEN":
                    return "Centimeters";
                case "CENT":
                    return "Centimeters";
                case "CENTI":
                    return "Centimeters";
                case "CEMTIM":
                    return "Meters";
                case "CEMTIME":
                    return "Meters";
                case "CEMTIMET":
                    return "Meters";
                case "CEMTIMETE":
                    return "Meters";
                case "CEMTIMETER":
                    return "Meters";
                case "CEMTIMETERS":
                    return "Meters";

                case "D":
                    return "Days";
                case "DA":
                    return "Days";
                case "DAY":
                    return "Days";
                case "DAYS":
                    return "Days";

                case "F":
                    return "Fahrenheit";

                case "FT":
                    return "Feet";
                case "FTS":
                    return "Feet";
                case "FE":
                    return "Feet";
                case "FEE":
                    return "Feet";
                case "FEET":
                    return "Feet";
                case "FEETS":
                    return "Feet";
                case "FOOT":
                    return "Feet";

                case "G":
                    return "Grams";
                case "GS":
                    return "Grams";
                case "GR":
                    return "Grams";
                case "GRA":
                    return "Grams";
                case "GRAM":
                    return "Grams";
                case "GRAMS":
                    return "Grams";

                case "H":
                    return "Hours";
                case "HR":
                    return "Hours";
                case "HRS":
                    return "Hours";
                case "HO":
                    return "Hours";
                case "HOU":
                    return "Hours";
                case "HOUR":
                    return "Hours";
                case "HOURS":
                    return "Hours";

                case "I":
                    return "Inches";
                case "IS":
                    return "Inches";
                case "IN":
                    return "Inches";
                case "INS":
                    return "Inches";
                case "INC":
                    return "Inches";
                case "INCH":
                    return "Inches";
                case "INCHS":
                    return "Inches";
                case "INCHES":
                    return "Inches";


                case "K":
                    return "Kelvin";
                case "KE":
                    return "Kelvin";
                case "KEL":
                    return "Kelvin";
                case "KELV":
                    return "Kelvin";
                case "KELVI":
                    return "Kelvin";
                case "KELVIN":
                    return "Kelvin";
                case "KELVINS":
                    return "Kelvin";



                case "KM":
                    return "Kilometers";
                case "KMS":
                    return "Kilometers";
                case "KILOM":
                    return "Kilometers";
                case "KILOME":
                    return "Kilometers";
                case "KILOMET":
                    return "Kilometers";
                case "KILOMETE":
                    return "Kilometers";
                case "KILOMETER":
                    return "Kilometers";
                case "KILOMETERS":
                    return "Kilometers";


                case "KG":
                    return "Kilograms";
                case "KGS":
                    return "Kilograms";
                case "KILOG":
                    return "Kilograms";
                case "KILOGR":
                    return "Kilograms";
                case "KILOGRA":
                    return "Kilograms";
                case "KILOGRAM":
                    return "Kilograms";
                case "KILOGRAMS":
                    return "Kilograms";


                case "M":
                    return "Meters";
                case "MS":
                    return "Meters";
                case "ME":
                    return "Meters";
                case "MET":
                    return "Meters";
                case "METE":
                    return "Meters";
                case "METER":
                    return "Meters";
                case "METERS":
                    return "Meters";

                case "MIN":
                    return "Minutes";
                case "MINS":
                    return "Minutes";
                case "MINU":
                    return "Minutes";
                case "MINUT":
                    return "Minutes";
                case "MINUTE":
                    return "Minutes";
                case "MINUTES":
                    return "Minutes";

                case "MI":
                    return "Miles";
                case "MIS":
                    return "Miles";
                case "MIL":
                    return "Miles";
                case "MILE":
                    return "Miles";
                case "MILES":
                    return "Miles";

                case "OZ":
                    return "Ounces";
                case "OU":
                    return "Ounces";
                case "OUN":
                    return "Ounces";
                case "OUNC":
                    return "Ounces";
                case "OUNCE":
                    return "Ounces";
                case "OUNCES":
                    return "Ounces";

                case "P":
                    return "Pounds";
                case "PO":
                    return "Pounds";
                case "POU":
                    return "Pounds";
                case "POUN":
                    return "Pounds";
                case "POUND":
                    return "Pounds";
                case "POUNDS":
                    return "Pounds";
                case "PON":
                    return "Pounds";
                case "LBS":
                    return "Pounds";
                case "LB":
                    return "Pounds";


                case "S":
                    return "Seconds";
                case "SE":
                    return "Seconds";
                case "SEC":
                    return "Seconds";
                case "SECO":
                    return "Seconds";
                case "SECON":
                    return "Seconds";
                case "SECOND":
                    return "Seconds";
                case "SECONDS":
                    return "Seconds";




                case "W":
                    return "Weeks";
                case "WK":
                    return "Weeks";
                case "WKS":
                    return "Weeks";
                case "WE":
                    return "Weeks";
                case "WEE":
                    return "Weeks";
                case "WEEK":
                    return "Weeks";
                case "WEEKS":
                    return "Weeks";

                case "Y":
                    return "Years";
                case "YR":
                    return "Years";
                case "YRS":
                    return "Years";
                case "YE":
                    return "Years";
                case "YEA":
                    return "Years";
                case "YEAR":
                    return "Years";
                case "YEARS":
                    return "Years";


                default:
                    return "Unknown";
            }
        }
    }
}
