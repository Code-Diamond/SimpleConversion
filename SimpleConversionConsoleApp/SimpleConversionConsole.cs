using SimpleConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConversionConsoleApp
{
    class SimpleConversionConsole
    {
        static void Main(string[] args)
        {
            Console.Title= "SimpleConversionConsole v1.0";
            Console.WriteLine("Welcome to Simple Conversion.\n");

            
            string input = "";
            //Create a label for the loop
            Start:
            while (!input.Equals("exit") || !input.Equals("Exit"))
            {
                Console.WriteLine("--------");
                Console.Write("Convert: ");
                input = Console.ReadLine();
                Console.WriteLine("--------");

                if (input.Equals("exit") || input.Equals("Exit"))
                {
                    Environment.Exit(0);
                }

                if(input.Equals("help") || input.Equals("Help"))
                {
                    Console.WriteLine("\nSimpleConversion version 1.0\n" +
                        "\n" +
                        "To get started type in an initial value such as \"100\"\n" +
                        "Then type in the unit of measurement for the initial value,\n" +
                        "For example:   \"100 Pounds\"\n" +
                        "Then follow the initial units, with the resulting units\n" +
                        " typing:   100 Pounds Grams \n" +
                        " will result in:   45359.237" +
                        "\n\nYou may also type short hand\n" +
                        "For example: \ntyping:     \"100 lb g\" \n" +
                        "will also result in: 45359.237\n");
                        //utilize label to over-ride parsing process
                        goto Start;
                }

                string[] arguments = ParseCommandArguments(input);

                ShortHandHelper helperClass = new ShortHandHelper();
                try
                {
                        
                    decimal initialValue = decimal.Parse(arguments[0]);

                    //Turn arguments to uppercase
                    arguments[1] = arguments[1].ToUpper();
                    arguments[2] = arguments[2].ToUpper();

                    //Parse short hand arguments
                    string initialUnits = helperClass.ParseShortHand(arguments[1]);
                    string resultingUnits = helperClass.ParseShortHand(arguments[2]);

                    //Calculate and inform user of conversion

                    //Create calculator object from class library
                    SimpleConversionCalculator calculator = new SimpleConversionCalculator();

                    decimal result = calculator.Convert(initialUnits, resultingUnits, initialValue);    
                        
                    //if the result is equal to the original input
                    if(result == initialValue * 1m)
                    {
                        //Explain there may be wrong units of measurements involved
                        Console.WriteLine("\nSorry unable to detect units of measurements.");
                    Console.WriteLine("\nPlease ensure you select appropriate matching \ncategories of units of measurements to convert." +
                        "\n - For example, you cannot convert meters to days.\n" +
                        "\nOtherwise, type in the full name of the unit of measurement\n such as \"Feet\" instead of \"f\" to make it less ambiguous.\n");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write(initialValue + " " + initialUnits + " = ");
                        Console.WriteLine(result + " " + resultingUnits);
                        Console.WriteLine("");
                    }
                 
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The first argument entered must be a numerical value.");
                    Console.WriteLine("");
                }
                

            }

        }

        public static string[] ParseCommandArguments(string input)
        {
            //Create an array of delimeters for the arguments
            char[] delimiterChars = { ' ', ',', ':', '\t' };
            
            string[] words = input.Split(delimiterChars);

            string[] arguments = new string[3];

            int counter = 0;
            
            foreach (string word in words)
            {
                try
                {
                    if(words.Length<3 || words.Length > 3)
                    {
                        throw new Exception();
                    }
                    arguments[counter] = word;
                    counter++;
                }
                catch(Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please supply 3 arguments.\n" +
                        "For example, typing:  \"45 Feet Meters\" \n" +
                        "Will convert from 45 feet to meters\n" +
                        "resutling in:           = 13.716 meters");
                    Console.WriteLine("");
                    return null;
                }
            }
            return arguments;
        }

    }
}
