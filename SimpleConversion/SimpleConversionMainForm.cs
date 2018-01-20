using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * Final Project C#

Created by Jamin Ghata

*/

namespace SimpleConversion
{
    public partial class SimpleConversionMainForm : Form
    {
        
        //Create the units of measurements in an array of strings
        private static string[] distanceUnits = { "Inches", "Feet", "Centimeters", "Meters", "Kilometers", "Miles" };
        private string[] massUnits = { "Grams", "Kilograms", "Pounds", "Ounces" };
        private string[] timeUnits = { "Seconds", "Minutes", "Hours", "Days", "Weeks", "Years" };
        private string[] temperatureUnits = { "Celsius", "Fahrenheit", "Kelvin" };

        //Create an SimpleConversionCalculator object to later utilize the method containing the calculate algorithm
        private SimpleConversionCalculator calculator = new SimpleConversionCalculator();

        //Initializes the main form component
        public SimpleConversionMainForm()
        {
            InitializeComponent();
        }




        //---------------------------------------------
        //Event methods for main menu button navigations
        //---------------------------------------------

        //Distance Main Menu Navigation Button Event (Hides the main menu and brings up the converter with measurement menu field filled)
        private void DistanceMainMenu_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Distance");
            
        }
        //Mass Main Menu Navigation Button Event (Hides the main menu and brings up the converter with measurement menu field filled)
        private void MassMainMenu_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Mass");
        }
        //Time Main Menu Navigation Button Event (Hides the main menu and brings up the converter with measurement menu field filled)
        private void TimeMainMenu_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Time");
        }
        //Temperature Main Menu Navigation Button Event (Hides the main menu and brings up the converter with measurement menu field filled)
        private void TemperatureMainMenu_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Temperature");
        }




        //---------------------------------------------
        //       Menu Tool Strip Event Methods
        //---------------------------------------------

        //Navigates back to main menu (Hides converter, shows main menu buttons)
        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideConverter();
            ShowMainMenu();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (process.ProcessName == "SimpleConversionConsoleApp")
                {

                    process.CloseMainWindow();

                }

            }

        }
        
        private void DistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Distance");
        }

        private void MassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Mass");
        }

        private void TimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Time");
        }

        private void TemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowConverter("Temperature");
        }





        //---------------------------------------------
        //            Visibility Methods
        //---------------------------------------------

        //Hides Main Menu Navigation Buttons
        private void HideMainMenu()
        {
            DistanceMainMenu.Hide();
            MassMainMenu.Hide();
            TimeMainMenu.Hide();
            TemperatureMainMenu.Hide();
            //When navigating back to the main menu its important to clear the field values for the ComboBoxes
            ClearUnitsComboBoxes();

        }
        //Shows Main Menu Navigation Buttons
        private void ShowMainMenu()
        {
            DistanceMainMenu.Show();
            MassMainMenu.Show();
            TimeMainMenu.Show();
            TemperatureMainMenu.Show();
            //When navigating back to the main menu its important to clear the field values for the ComboBoxes
            ClearUnitsComboBoxes();
        }

        //Hides Converter Menu
        private void HideConverter()
        {
            CategoryLabel.Hide();
            CategoryComboBox.Hide();
            InstructionLabel.Hide();
            ValueOfLabel.Hide();
            UserInputTextBox.Hide();
            FromLabel.Hide();
            InitialUnitsComboBox.Hide();
            ToLabel.Hide();
            ResultingUnitsComboBox.Hide();
            ConvertSubmissionButton.Hide();
            BackButtonLabel.Hide();
            BackButton.Hide();
            DividerLabel.Hide();
            InitialValueLabel.Hide();
            InitialUnitsLabel.Hide();
            EqualsLabel.Hide();
            ResultingUnitsLabel.Hide();
            ResultingValueLabel.Hide();
            //When navigating back to the main menu its important to clear the field values for the ComboBoxes
            ClearUnitsComboBoxes();
        }

        //Shows Converter Menu
        private void ShowConverter()
        {
            //Show the converter menu's controls and labels
            CategoryLabel.Show();
            CategoryComboBox.Show();
            InstructionLabel.Show();
            ValueOfLabel.Show();
            UserInputTextBox.Show();
            FromLabel.Show();
            InitialUnitsComboBox.Show();
            ToLabel.Show();
            ResultingUnitsComboBox.Show();
            BackButtonLabel.Show();
            BackButton.Show();
            DividerLabel.Show();

            UserInputTextBox.Focus();
        }

        //Overrided method accepting a category parameter obtained from menu selection
        private void ShowConverter(String category)
        {

            //Shows the converter menu's controls and labels
            CategoryLabel.Show();
            CategoryComboBox.Show();
            InstructionLabel.Show();
            ValueOfLabel.Show();
            UserInputTextBox.Show();
            FromLabel.Show();
            InitialUnitsComboBox.Show();
            ToLabel.Show();
            ResultingUnitsComboBox.Show();
            ConvertSubmissionButton.Show();
            BackButtonLabel.Show();
            BackButton.Show();
            DividerLabel.Show();
            //Selects the category field in the converter
            CategoryComboBox.SelectedIndex = CategoryComboBox.FindStringExact(category);
            //Shows the default units of measurement
            ShowDefaultUnits(category);

            UserInputTextBox.Focus();
        }
        //Changes the unit of measurement combo boxes. Accepts the category from menu navigation buttons.
        private void ShowDefaultUnits(String category)
        {
            //When navigating back to the main menu its important to clear the field values for the ComboBoxes
            ClearUnitsComboBoxes();
            //Switch statement selects the category and default field values
            switch (category)
            {
                case "Distance":
                    //Add distance units to the comboboxes
                    AddDistanceUnitsOfMeasurements();
                    //Set the default selected units
                    InitialUnitsComboBox.SelectedIndex = 4;
                    ResultingUnitsComboBox.SelectedIndex = 5;
                    break;
                case "Mass":
                    //Add mass units to the comboboxes
                    AddMassUnitsOfMeasurements();
                    //Set the default selected units
                    InitialUnitsComboBox.SelectedIndex = 1; 
                    ResultingUnitsComboBox.SelectedIndex = 2;
                    break;
                case "Time":
                    //Add time units to the comboboxes
                    AddTimeUnitsOfMeasurements();
                    //Set the default selected units
                    InitialUnitsComboBox.SelectedIndex = 3;
                    ResultingUnitsComboBox.SelectedIndex = 5;
                    break;
                case "Temperature":
                    //Add temperature units to the comboboxes
                    AddTemperatureUnitsOfMeasurements();
                    //Set the default selected units
                    InitialUnitsComboBox.SelectedIndex = 0;
                    ResultingUnitsComboBox.SelectedIndex = 1;
                    break;
                            
            }
        }
        //Adds the distance units of measurements to the combo boxes
        private void AddDistanceUnitsOfMeasurements()
        {
            //Loops through distanceUnits array
            for(int i = 0; i<distanceUnits.Length; i++)
            {
                //Adds each element of array to the comboboxes
                InitialUnitsComboBox.Items.Add(distanceUnits[i]);
                ResultingUnitsComboBox.Items.Add(distanceUnits[i]);
            }
        }
        //Adds the mass units of measurements to the combo boxes
        private void AddMassUnitsOfMeasurements()
        {
            //Loops through massUnits array
            for (int i = 0; i < massUnits.Length; i++)
            {
                //Adds each element of array to the comboboxes
                InitialUnitsComboBox.Items.Add(massUnits[i]);
                ResultingUnitsComboBox.Items.Add(massUnits[i]);
            }
        }
        //Adds the time units of measurements to the combo boxes
        private void AddTimeUnitsOfMeasurements()
        {
            //Loops through timeUnits array
            for (int i = 0; i < timeUnits.Length; i++)
            {
                //Adds each element of array to the comboboxes
                InitialUnitsComboBox.Items.Add(timeUnits[i]);
                ResultingUnitsComboBox.Items.Add(timeUnits[i]);
            }
        }
        //Adds the temperature units of measurements to the combo boxes
        private void AddTemperatureUnitsOfMeasurements()
        {
            //Loops through timeUnits array
            for (int i = 0; i < temperatureUnits.Length; i++)
            {
                //Adds each element of array to the comboboxes
                InitialUnitsComboBox.Items.Add(temperatureUnits[i]);
                ResultingUnitsComboBox.Items.Add(temperatureUnits[i]);
            }
        }
        //Clears the unit of measurement combo boxes
        private void ClearUnitsComboBoxes()
        {
            InitialUnitsComboBox.Items.Clear();
            ResultingUnitsComboBox.Items.Clear();
        }


 
        //The user can also navigate through the category ComboBox
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearUnitsComboBoxes();
            ShowConverter(CategoryComboBox.Text);
        }
        //The user can navigate using the back button
        private void BackButton_Click(object sender, EventArgs e)
        {
            ClearUnitsComboBoxes();
            HideConverter();
            ShowMainMenu();
        }

        //The user clicks the convert button
        private void ConvertSubmissionButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal userInput = Decimal.Parse(UserInputTextBox.Text);
                string initialUnits = InitialUnitsComboBox.SelectedItem.ToString();
                string resultingUnits = ResultingUnitsComboBox.SelectedItem.ToString();
                
                //Format the initial value label to include commas and rounding
                InitialValueLabel.Text = String.Format("{0:#,##0.####}", Decimal.Parse(userInput.ToString())); 
                InitialUnitsLabel.Text = initialUnits;

                ResultingValueLabel.Text = resultingUnits;
                ResultingUnitsLabel.Text = resultingUnits;

                decimal result = calculator.Convert(initialUnits, resultingUnits, userInput);

                //Perform rounding operations
                result = decimal.Round(result, 4, MidpointRounding.AwayFromZero);
                string resultString = result.ToString("0.####");
                //Format the result label to include commas 
                ResultingValueLabel.Text = String.Format("{0:#,##0.####}", Decimal.Parse(resultString));

                InitialValueLabel.Show();
                InitialUnitsLabel.Show();
                EqualsLabel.Show();
                ResultingUnitsLabel.Show();
                ResultingValueLabel.Show();
            }
            catch(Exception exception)
            {
                //Inform developers about exception in gui through console
                //Console.WriteLine(exception.ToString());
            }
        }

        private void Convert()
        {
            try
            {
                decimal userInput = Decimal.Parse(UserInputTextBox.Text);
                string initialUnits = InitialUnitsComboBox.SelectedItem.ToString();
                string resultingUnits = ResultingUnitsComboBox.SelectedItem.ToString();

                //Format the initial value label to include commas and rounding
                InitialValueLabel.Text = String.Format("{0:#,##0.####}", Decimal.Parse(userInput.ToString()));
                InitialUnitsLabel.Text = initialUnits;

                ResultingValueLabel.Text = resultingUnits;
                ResultingUnitsLabel.Text = resultingUnits;

                decimal result = calculator.Convert(initialUnits, resultingUnits, userInput);

                //Perform rounding operations
                result = decimal.Round(result, 4, MidpointRounding.AwayFromZero);
                string resultString = result.ToString("0.####");
                //Format the result label to include commas 
                ResultingValueLabel.Text = String.Format("{0:#,##0.####}", Decimal.Parse(resultString));

                InitialValueLabel.Show();
                InitialUnitsLabel.Show();
                EqualsLabel.Show();
                ResultingUnitsLabel.Show();
                ResultingValueLabel.Show();
            }
            catch (Exception exception)
            {
                //Inform developer about exception in gui
                Console.WriteLine(exception.ToString());
            }
        }

        private void UserInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Convert();
            }
        }

        private void ClearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInputTextBox.Clear();

            InitialValueLabel.Hide();
            InitialUnitsLabel.Hide();
            EqualsLabel.Hide();
            ResultingUnitsLabel.Hide();
            ResultingValueLabel.Hide();

            UserInputTextBox.Focus();

        }

        private void SimpleConversionMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
