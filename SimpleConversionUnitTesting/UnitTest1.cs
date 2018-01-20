using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleConversion;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleConversionUnitTesting
{
    [TestClass]
    public class UnitTests
    {
        //Create SimpleConversionCalculator object
        public SimpleConversionCalculator calculator = new SimpleConversionCalculator();

        //Demonstrates a unit test on Meters to Kilometers
        [TestMethod]
        public void TestDistanceMetersToKilometers()
        {
            //-------
            //Arrange 
            //-------


            decimal[] inputValues =
            {
                //Positive Cases 1-20
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
                //Negative Cases -1 through -20
                -1,-2,-3,-4,-5,-6,-7,-8,-9,-10,-11,-12,-13,-14,-15,-16,-17,-18,-19,-20,
                //Edge Cases
                0, -1000000000000, 1000000000000 //positive and negative 1 trillion
                //99999999999999999, -99999999999999999  
            };
            decimal[] expectedResults =
            {
                //Positive Case Expected Results 1-20
                .001m,.002m,.003m,.004m,.005m,.006m,.007m,.008m,.009m,.01m,.011m,.012m,.013m,.014m,.015m,.016m,.017m,.018m,.019m,.020m,
                //Negative Cases Expected Results -1 through -20
                -.001m,-.002m,-.003m,-.004m,-.005m,-.006m,-.007m,-.008m,-.009m,-.01m,-.011m,-.012m,-.013m,-.014m,-.015m,-.016m,-.017m,-.018m,-.019m,-.020m,
                //Edge Cases
                0, -1000000000, 1000000000, //positive and negative 1 billion
                
            };

            //-------
            //  Act
            //-------
            decimal inputValue;
            string initialUnits = "Meters";
            string resultingUnits = "Kilometers";
            decimal expectedResult;

            for (int i = 0; i < inputValues.Length; i++)
            {
                inputValue = inputValues[i];

                expectedResult = expectedResults[i];
                //  The main conversion action
                decimal actualResult = calculator.Convert(initialUnits, resultingUnits, inputValue);
                // The rounding operation
                actualResult = decimal.Round(actualResult, 4, MidpointRounding.AwayFromZero);
                string resultString = actualResult.ToString("0.####");
                actualResult = decimal.Parse(resultString);
                //-------
                // Assert
                //-------
                Assert.AreEqual(expectedResult, actualResult);
            }
        }


        //Demonstrates a unit test on Celsius to Fahrenheit
        [TestMethod]
        public void TestTemperatureCelsiusToFahrenheit()
        {
            //-------
            //Arrange 
            //-------


            decimal[] inputValues =
            {
                //Positive Cases 1-20
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
                //Negative Cases -1 through -20
                -1,-2,-3,-4,-5,-6,-7,-8,-9,-10,-11,-12,-13,-14,-15,-16,-17,-18,-19,-20,
                //Edge Cases
                0, -1000000000000, 1000000000000 //positive and negative 1 trillion
              
            };
            decimal[] expectedResults =
            {
                //Positive Case Expected Results 1-20
                33.8m, 35.6m, 37.4m, 39.2m, 41.0m, 42.8m, 44.6m, 46.4m, 48.2m, 50.0m, 51.8m, 53.6m, 55.4m, 57.2m, 59, 60.8m, 62.6m, 64.4m, 66.2m, 68,
                //Negative Cases Expected Results -1 through -20
                30.2m, 28.4m, 26.6m, 24.8m, 23.0m, 21.2m, 19.4m, 17.6m, 15.8m, 14.0m, 12.2m, 10.4m, 8.6m, 6.8m, 5, 3.2m, 1.4m, -0.4m, -2.2m, -4m,
                //Edge Cases
                32.0m, -1799999999968, 1800000000032, 
                
            };

            //-------
            //  Act
            //-------
            decimal inputValue;
            string initialUnits = "Celsius";
            string resultingUnits = "Fahrenheit";
            decimal expectedResult;

            for (int i = 0; i < inputValues.Length; i++)
            {
                inputValue = inputValues[i];

                expectedResult = expectedResults[i];
                //  The main conversion action
                decimal actualResult = calculator.Convert(initialUnits, resultingUnits, inputValue);
                // The rounding operation
                actualResult = decimal.Round(actualResult, 4, MidpointRounding.AwayFromZero);
                string resultString = actualResult.ToString("0.####");
                actualResult = decimal.Parse(resultString);
                //-------
                // Assert
                //-------
                
                Assert.AreEqual(expectedResult, actualResult);

                Trace.WriteLine("lets see");
            }
        }


        //Demonstrates unit testing on converting from pounds to grams
        [TestMethod]
        public void TestMassPoundsToGrams()
        {
            //-------
            //Arrange 
            //-------


            decimal[] inputValues =
            {
                1,2 
            };
            decimal[] expectedResults =
            {
                453.5924m, 907.1847m,
            };

            //-------
            //  Act
            //-------
            decimal inputValue;
            string initialUnits = "Pounds";
            string resultingUnits = "Grams";
            decimal expectedResult;

            for (int i = 0; i < inputValues.Length; i++)
            {
                inputValue = inputValues[i];

                expectedResult = expectedResults[i];
                //  The main conversion action
                decimal actualResult = calculator.Convert(initialUnits, resultingUnits, inputValue);
                // The rounding operation
                actualResult = decimal.Round(actualResult, 4, MidpointRounding.AwayFromZero);
                string resultString = actualResult.ToString("0.####");
                actualResult = decimal.Parse(resultString);
                //-------
                // Assert
                //-------
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        //Demonstrates unit testing on converting from pounds to grams
        [TestMethod]
        public void TestTimeYearsToDays()
        {
            //-------
            //Arrange 
            //-------

            //Years are technically closer to "365.2422" than 365.25  Because leap years skip every 400 yrs, and a day has 86,400 sec
            decimal[] inputValues =
            {
                1, 2, 3, 4
            };
            decimal[] expectedResults =
            {
                365.2422m,730.4844m, 1095.7266m, 1460.9688m  // as you can see a year is neither exactly 1460 or 1461 days
            };

            //-------
            //  Act
            //-------
            decimal inputValue;
            string initialUnits = "Years";
            string resultingUnits = "Days";
            decimal expectedResult;

            for (int i = 0; i < inputValues.Length; i++)
            {
                inputValue = inputValues[i];

                expectedResult = expectedResults[i];
                //  The main conversion action
                decimal actualResult = calculator.Convert(initialUnits, resultingUnits, inputValue);
                // The rounding operation
                actualResult = decimal.Round(actualResult, 4, MidpointRounding.AwayFromZero);
                string resultString = actualResult.ToString("0.####");
                actualResult = decimal.Parse(resultString);
                //-------
                // Assert
                //-------
                Assert.AreEqual(expectedResult, actualResult);
            }
        }



    }
}
