// Author: Katherine Bellman
// Last Modified: May 26, 2021
//
// Original Author: Kyle Chapman
// Created:  January 2021
// Modified: May 25, 2021
//
// Description:
//  A form that allows entry of 7 days of temperature values.
//  Each week an average is calculated. After week 1, the average temperature
//  value is compared to the average temperature value from the previous week
//  and a message is generated based on this. Functionality to reset and exit
//  the form is also available.
    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyTemperature
{
    public partial class formWeeklyTemperature : Form
    {
        public formWeeklyTemperature()
        {
            InitializeComponent();
        }

        #region "Variable Declarations"
        // Variable declarations
        // Declare an array referring to the list of textboxes on the form.
        // This allows these to be quickly validated and/or cleared iteratively.
        TextBox[] inputTextBoxArray;

        int week = 1;
        double totalTemperature = 0;
        double lastWeekAverage = 0;

        #endregion

        #region "Event Handlers"
        /// <summary>
        /// When the form loads, assign values to the arrays based on the textboxes on the form.
        /// Note that assigning this would not work before the form was loaded, so it is done on load.
        /// </summary>
        private void FormLoad(object sender, EventArgs e)
        {
            inputTextBoxArray = new TextBox[] {textBoxDay1, textBoxDay2, textBoxDay3, textBoxDay4, textBoxDay5, textBoxDay6, textBoxDay7 };
            SetDefaults();
        }

        /// <summary>
        /// Calculates the sum of all 7 valid inputs, calculates the total average and displays result to user.
        /// </summary>
        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            // Note that this code is DONE, but it is very dependent on the completion of the
            // ValidateTextbox function included below.
            // This event handler should not need to be modified at all. PROBABLY.

            // Variable declarations.
            double averageTemperature = 0;
            int validTextboxes = 0;

            // Loop through the inputTextBoxArray and check that each textbox is valid.
            // Note that this uses the ValidateTextbox() function.
            foreach(TextBox textBoxToCheck in inputTextBoxArray)
            {
                // If the textbox is valid, count it. If not, just don't.
                if (ValidateTextbox(textBoxToCheck))
                {
                    validTextboxes++;
                }
            }

            // Check if the Textboxes all have valid content.
            if (validTextboxes == inputTextBoxArray.Length)
            {
                // Clear the error messages.
                textBoxResult.Clear();

                // Make sure totalTemperature has been incremented to include all entered values.
                // I chose to do it as part of ValidateTextbox but you could also do it here.

                // Textboxes are valid; calculate the average temperature!
                averageTemperature = Math.Round(totalTemperature / inputTextBoxArray.Length, 2);

                // Check if it's after week 1.
                if (week > 1)
                {
                    // Determine whether this week is warmer or colder and output a message.
                    if (averageTemperature > lastWeekAverage)
                    {
                        textBoxResult.Text = "The week " + week + " average of " + averageTemperature + " is higher than the previous average of " + lastWeekAverage + ".";
                    }
                    else if (averageTemperature < lastWeekAverage)
                    {
                        textBoxResult.Text = "The week " + week + " average of " + averageTemperature + " is lower than the previous average of " + lastWeekAverage + ".";
                    }
                    else
                    {
                        textBoxResult.Text = "The week " + week + " average of " + averageTemperature + " is the same as last week's average.";
                    }
                }

                // Increment the week.
                week += 1;
                labelWeek.Text = "Week " + week;

                // Display the week's average, and store it for next week.
                textBoxAverageOutput.Text = averageTemperature.ToString();
                lastWeekAverage = averageTemperature;

                // Disable input controls until the form is reset.
                buttonCalculate.Enabled = false;
                SetControlsEnabled(inputTextBoxArray, false);
                buttonReset.Focus();
            }
            
            // You could write an "else" statement here indicating what would happen
            // if the validation failed, but you don't need to if you've done error
            // messaging and/or other things like that in the ValidateTextbox()
            // function.
        }

        /// <summary>
        /// Clears all fields
        /// </summary>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region "Functions"

        /// <summary>
        /// Function to clear text input collected within the array.
        /// </summary>
        /// <param name="controlArray">An array of controls with a text property to clear</param>
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        /// <summary>
        /// Function which can enable or disable input controls for form
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">true to enable, false to disable</param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            foreach (Control controlToSet in controlArray)
            {
                controlToSet.Enabled = enabledStatus;
            }
        }

        /// <summary>
        /// Clears input and output, re-enables controls, sets the form to its default state.
        /// </summary>
        private void SetDefaults()
        {
            // Clear input and output fields.
            ClearControls(inputTextBoxArray); // Calls a function to empty all input textboxes.
            textBoxAverageOutput.Clear();
            textBoxResult.Clear();

            // Don't reset the week to 1; that really messes up the "last week's temperature" feature.
            // Consider using the SetControlsEnabled for part of this.
            // Re-enables disabled controls. 
            SetControlsEnabled(inputTextBoxArray, true);
            buttonCalculate.Enabled = true;

            // Set focus in some kind of useful way.
            textBoxDay1.Focus();
        }

        /// <summary>
        /// This validates a single textbox on the form.
        /// </summary>
        /// <param name="textBoxInput">Textbox to validate</param>
        /// <returns>true if the textbox is valid, false if not</returns>
        private bool ValidateTextbox(TextBox textBoxInput)
        {
            // Variable declarations.
            double inputTemperature;
            
            // The variable isValid represents the return value of this function.
            // You could start it as "true" or "false".
            // I wrote "false" here but I might change my mind during class.
            bool isValid = false;

            if (textBoxInput.Text.Trim() == String.Empty)
            {
                textBoxResult.Text += "A temperature value has returned blank.\r\n";
            }
            // Check whether textBoxInput.Text is a valid number and attempt to store it in inputTemperature.
            else if (Double.TryParse(textBoxInput.Text, out inputTemperature)) 
            {
                // If it is, return true.
                isValid = true;
                totalTemperature += inputTemperature;
            }
            // If not, write an error message and then return false.
            else
            {   
                textBoxResult.Text += "The entered value of '" + textBoxInput.Text + "' is not valid. Please enter a numeric temperature.\r\n";               
            }
             return isValid;
            
        }

        #endregion

    }
}
